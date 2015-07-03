using System;
using System.Linq;
using System.Windows.Forms;
using Castle.Windsor;
using MetroFramework;
using MetroFramework.Forms;
using Phonebook.CastleWindsor;
using Phonebook.Contracts;
using Phonebook.Model;
using Phonebook.UserInterface.Properties;

namespace Phonebook.UserInterface
{
    public partial class MainForm : MetroForm
    {
        private readonly IManagerAsync<Person> _personManager;
        private readonly IManagerAsync<Phone> _phoneManager; 
        
        public MainForm() {
            InitializeComponent();

            StyleManager = metroStyleManager;

            var container = new WindsorContainer().Install(new MainInstaller());
            _personManager = container.Resolve<IManagerAsync<Person>>();
            _phoneManager = container.Resolve<IManagerAsync<Phone>>();

            FillStyleList();
            FillPhoneTypesList();
            FillPersonGrid();
        }

        #region Visual Customization Methods

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

        private void FillPhoneTypesList() {
            foreach (var item in Enum.GetValues(typeof(PhoneType))) {
                phoneTypeComboBox.Items.Add(item);
            }
        }

        #endregion

        #region Events

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e) {
            FillPersonGrid();
            ClearPhoneGrid();
            ClearPhoneEditForm();
            ClearPersonDetails();
            ClearPersonEditForm();
            ClearPersonDetailsUpdateForm();
        }

        private async void personGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            var id = (long) ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
            try {
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                FillPhoneGrid(person);
                FillPersonDetails(person);
                if (!IsEditingPage()) return;
                FillPersonUpdateForm();
                FillPersonDetailsUpdateForm();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, Resources.Message_Error,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void phoneEditGrid_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex < 0) return;
            var id = (long)((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value;
            var phone = await _phoneManager.GetByPrimaryKeyAsync(id);
            phoneTypeComboBox.SelectedIndex = ((int) phone.PhoneType - 1);
            phoneNumberTextBox.Text = phone.Number;
        }

        private bool IsEditingPage() {
            return tabControl.SelectedIndex == 1;
        }

        #endregion

        #region FillMethods

        private async void FillPersonGrid() {
            var list = await _personManager.GetAllAsync();
            var data = list.OrderBy(s => s.Id)
                .Select(s => new {ID = s.Id, Person = s.LastName + " " + s.FirstName});
            var grid = GetShownPersonGrid();
            grid.DataSource = data.ToList();
            grid.Columns[0].Width = 25;
        }

        private async void FillPhoneGrid(long id) {
            var person = await _personManager.GetByPrimaryKeyAsync(id);
            FillPhoneGrid(person);
        }

        private void FillPhoneGrid(Person person) {
            var phones = person.Phones.Select(s => new { ID = s.Id, s.PhoneType, s.Number });
            var grid = GetShownPhoneGrid();
            grid.DataSource = phones.ToList();
            grid.Columns[0].Visible = false;
        }

        private void FillPersonDetails(Person person) {
            var details = GetPersonDetailsLabel();
            details.Text = person.PersonDetails != null
                ? person.PersonDetails.ToString()
                : string.Format("No additional data found.");
        }

        private async void FillPersonDetailsUpdateForm() {
            var id = GetSelectedPersonId();
            if (id == -1) return;
            var person = await _personManager.GetByPrimaryKeyAsync(id);
            if (person.PersonDetails != null) {
                addressTextBox.Text = person.PersonDetails.Address;
                descriptionTextBox.Text = person.PersonDetails.Description;
            }
            else
                ClearPersonDetailsUpdateForm();
        }

        private async void FillPersonUpdateForm() {
            var id = GetSelectedPersonId();
            if (id == -1) return; 
            var person = await _personManager.GetByPrimaryKeyAsync(id);
            firstNameTextBox.Text = person.FirstName;
            lastNameTextBox.Text = person.LastName;
        }

        private void SelectPerson(long id) {
            var grid = GetShownPersonGrid();
            var row = grid.Rows.Cast<DataGridViewRow>().First(s => (long)s.Cells["ID"].Value == id);
            row.Selected = true;
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
            personDetailsLabel1.Text = String.Empty;
        }

        private void ClearPhoneEditForm() {
            phoneTypeComboBox.SelectedIndex = -1;
            phoneNumberTextBox.Text = String.Empty;
        }

        private void ClearPersonEditForm() {
            firstNameTextBox.Text = String.Empty;
            lastNameTextBox.Text = String.Empty;
        }

        private void ClearPersonDetailsUpdateForm() {
            addressTextBox.Text = String.Empty;
            descriptionTextBox.Text = String.Empty;
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

        private long GetSelectedPhoneId() {
            var grid = GetShownPhoneGrid();
            if (grid.SelectedRows.Count == 0) return -1;
            var row = grid.SelectedRows[0];
            return (long)row.Cells["ID"].Value;
        }

        private Label GetPersonDetailsLabel() {
            switch (tabControl.SelectedIndex) {
                case 0:
                    return personDetailsLabel;
                case 1:
                    return personDetailsLabel1;
                default:
                    return null;
            }
        }

        #endregion
        
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
            catch (ArgumentException) {
                MetroMessageBox.Show(this, "You entered incorrect data", "Note",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                FillPersonGrid();
                ClearPhoneGrid();
            }
        }

        private async void updatePersonButton_Click(object sender, EventArgs e) {
            try {
                if (String.IsNullOrEmpty(firstNameTextBox.Text)
                    || String.IsNullOrEmpty(lastNameTextBox.Text))
                    throw new ArgumentException("First Name or Last Name can't be empty.");
                var id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                person.LastName = lastNameTextBox.Text.Trim();
                person.FirstName = firstNameTextBox.Text.Trim();
                await _personManager.UpdateAsync(person);
                SelectPerson(id);
            }
            catch (ArgumentException) {
                MetroMessageBox.Show(this, "You entered incorrect data", "Note",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                FillPersonGrid();
                ClearPhoneGrid();
                ClearPersonEditForm();
            }
        }

        private async void deletePersonButton_Click(object sender, EventArgs e) {
            try {
                var id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                await _personManager.RemoveAsync(person);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { 
                FillPersonGrid();
                ClearPhoneGrid();
                ClearPersonEditForm();
            }
        }

        #endregion

        #region Phone crud

        private async void addPhoneButton_Click(object sender, EventArgs e) {
            try {
                var id = GetSelectedPersonId();
                var phone = new Phone {
                    PersonId = id,
                    Number = phoneNumberTextBox.Text,
                    PhoneType = (PhoneType) (phoneTypeComboBox.SelectedIndex + 1)
                };
                await _phoneManager.AddAsync(phone);
                FillPhoneGrid(id);
            }
            catch (ArgumentException) {
                MetroMessageBox.Show(this, "You entered incorrect data", "Note",
                     MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error,
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                ClearPhoneEditForm();
            }
        }

        private async void updatePhoneButton_Click(object sender, EventArgs e) {
            try {
                var id = GetSelectedPhoneId();
                var phone = await _phoneManager.GetByPrimaryKeyAsync(id);
                phone.Number = phoneNumberTextBox.Text.Trim();
                phone.PhoneType = (PhoneType)(phoneTypeComboBox.SelectedIndex + 1);
                await _phoneManager.UpdateAsync(phone);
                var person = GetSelectedPersonId();
                FillPhoneGrid(person);
                ClearPhoneEditForm();
            }
            catch (ArgumentException) {
                MetroMessageBox.Show(this, "You entered incorrect data", "Note",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error);
            }
            finally  {
                ClearPhoneEditForm();
            }
        }

        private async void deletePhoneButton_Click(object sender, EventArgs e) {
            try {
                var id = GetSelectedPhoneId();
                var phone = await _phoneManager.GetByPrimaryKeyAsync(id);
                await _phoneManager.RemoveAsync(phone);
                var person = GetSelectedPersonId();
                FillPhoneGrid(person);
                ClearPhoneEditForm();
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally {
                ClearPhoneEditForm();
            }
        }

        #endregion

        #region Person Details crud

        private async void addPersonDetailsButton_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrEmpty(addressTextBox.Text))
                    throw new ArgumentException("Address can't be empty.");
                var id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                if (person.PersonDetails != null)
                    throw new ArgumentException("Person can have only one details record");
                person.PersonDetails = new PersonDetails {
                    Address = addressTextBox.Text.Trim(),
                    Description = descriptionTextBox.Text.Trim()
                };
                await _personManager.UpdateAsync(person);
                ClearPersonDetailsUpdateForm();
                FillPersonDetails(person);
            }
            catch (ArgumentException ex) {
                MetroMessageBox.Show(this, ex.Message, "Note",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void updatePersonDetailsButton_Click(object sender, EventArgs e)
        {
            try {
                if (String.IsNullOrEmpty(addressTextBox.Text))
                    throw new ArgumentException("Address can't be empty.");
                var id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                if (person.PersonDetails == null)
                    throw new ArgumentException("Person do not have details record to update");
                person.PersonDetails.Description = descriptionTextBox.Text.Trim();
                person.PersonDetails.Address = addressTextBox.Text.Trim();
                await _personManager.UpdateAsync(person);
                ClearPersonDetailsUpdateForm();
                FillPersonDetails(person);
            }
            catch (ArgumentException ex) {
                MetroMessageBox.Show(this, ex.Message, "Note",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deletePersonDetailsButton_Click(object sender, EventArgs e)
        {
            try {
                var id = GetSelectedPersonId();
                var person = await _personManager.GetByPrimaryKeyAsync(id);
                if (person.PersonDetails == null)
                    throw new ArgumentException("Person do not have details to be deleted");
                person.PersonDetails = null;
                await _personManager.UpdateAsync(person);
                ClearPersonDetailsUpdateForm();
                FillPersonDetails(person);
            }
            catch (ArgumentException ex) {
                MetroMessageBox.Show(this, ex.Message, "Note",
                         MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) {
                MetroMessageBox.Show(this, ex.Message, Resources.Message_Error, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

    }
}
