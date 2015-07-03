using System;
using System.Linq;
using System.Windows.Forms;
using Castle.Windsor;
using MetroFramework;
using MetroFramework.Forms;
using Phonebook.CastleWindsor;
using Phonebook.Contracts;
using Phonebook.Model;

namespace Phonebook.UserInterface
{
    public partial class MainForm : MetroForm
    {
        private readonly IWindsorContainer _container;
        private readonly IManagerAsync<Person> _personManager; 

        public MainForm() {
            InitializeComponent();

            StyleManager = metroStyleManager;

            _container = new WindsorContainer().Install(new MainInstaller());
            _personManager = _container.Resolve<IManagerAsync<Person>>();

            FillStyleList();
            FillPersonGrid();
        }

        #region Visual Customization

        private void themeSwitchTile_Click(object sender, EventArgs e) {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light 
                ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void styleListComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            metroStyleManager.Style = (MetroColorStyle)styleListComboBox.SelectedIndex;
        }

        private void FillStyleList() {
            foreach (var item in Enum.GetValues(typeof(MetroColorStyle))) {
                styleListComboBox.Items.Add(item);
            }
            styleListComboBox.SelectedIndex = (int) metroStyleManager.Style;
        }

        #endregion

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            FillPersonGrid();
            ClearPhoneGrid();
            ClearPersonDetails();
        }

        private async void personGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            var id = (long) ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
            var person = await _personManager.GetByPrimaryKeyAsync(id);
            FillPhoneGrid(person);
            if (!IsEditingPage())
                FillPersonDetails(person);
            if (IsEditingPage())
                FillPersonUpdateForm();
        }

        #region FillMethods

        private async void FillPersonGrid() {
            var list = await _personManager.GetAllAsync();
            var data = list.OrderBy(s => s.Id)
                .Select(s => new {ID = s.Id, Person = s.LastName + " " + s.FirstName});
            var grid = GetShownPersonGrid();
            grid.DataSource = data.ToList();
            grid.Columns[0].Width = 25;
        }
        
        private void FillPhoneGrid(Person person) {
            var phones = person.Phones.Select(s => new { s.PhoneType, s.Number });
            var grid = GetShownPhoneGrid();
            grid.DataSource = phones.ToList();
        }

        private void FillPersonDetails(Person person) {
            personDetailsLabel.Text = person.PersonDetails != null
                ? person.PersonDetails.ToString()
                : string.Format("No additional data found.");
        }

        private async void FillPersonUpdateForm() {
            var id = GetSelectedPersonId();
            var person = await _personManager.GetByPrimaryKeyAsync(id);
            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
        }

        #endregion

        #region Clear Methods

        private void ClearPhoneGrid() {
            var grid = GetShownPhoneGrid();
            grid.DataSource = null;
            grid.Rows.Clear();
        }

        private void ClearPersonDetails() {
            personDetailsLabel.Text = String.Empty;
        }

        #endregion

        #region Get Elements and Data Methods

        private DataGridView GetShownPersonGrid() {
            switch (tabControl.SelectedIndex) {
                case 0:
                    return personGrid;
                case 1:
                    return personGridEdit;
                default:
                    return null;
            }
        }

        private DataGridView GetShownPhoneGrid() {
            switch (tabControl.SelectedIndex) {
                case 0:
                    return phoneGrid;
                case 1:
                    return phoneEditGrid;
                default:
                    return null;
            }
        }

        private long GetSelectedPersonId() {
            var grid = GetShownPersonGrid();
            if (grid.SelectedRows.Count == 0) return -1;
            var row = grid.SelectedRows[0];
            return (long)row.Cells["ID"].Value;
        }

        #endregion

        private void SelectPerson(long id) {
            var grid = GetShownPersonGrid();
            var row = grid.Rows.Cast<DataGridViewRow>().First(s => (long) s.Cells["ID"].Value == id);
            row.Selected = true;
        }

        private bool IsEditingPage() {
            return tabControl.SelectedIndex == 1;
        }

        #region Person crud

        private async void addPersonButton_Click(object sender, EventArgs e) {
            try {
                if (String.IsNullOrEmpty(firstNameTextBox.Text)
                    || String.IsNullOrEmpty(lastNameTextBox.Text))
                    throw new ArgumentException("First Name or Last Name can't be empty.");
                var person = new Person {
                    FirstName = firstNameTextBox.Text.Trim(),
                    LastName = lastNameTextBox.Text.Trim()
                };
                await _personManager.AddAsync(person);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, "Error");
            }
            finally { 
                FillPersonGrid();
                ClearPhoneGrid();
            }
        }

        private async void updatePersonButton_Click(object sender, EventArgs e) {
            long id = 0;
            try {
                if (String.IsNullOrEmpty(firstNameTextBox.Text)
                    || String.IsNullOrEmpty(lastNameTextBox.Text))
                    throw new ArgumentException("First Name or Last Name can't be empty.");
                id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                person.LastName = lastNameTextBox.Text.Trim();
                person.FirstName = firstNameTextBox.Text.Trim();
                await _personManager.UpdateAsync(person);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, "Error");
            }
            finally { 
                FillPersonGrid();
                ClearPhoneGrid();
                SelectPerson(id);
            }
        }

        private async void deletePersonButton_Click(object sender, EventArgs e) {
            try {
                var id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                await _personManager.RemoveAsync(person);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, "Error");
            }
            finally { 
                FillPersonGrid();
                ClearPhoneGrid();
            }
        }

        #endregion



    }
}
