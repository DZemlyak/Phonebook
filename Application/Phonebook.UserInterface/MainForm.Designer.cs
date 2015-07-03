namespace Phonebook.UserInterface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.personGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.phoneGrid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.personDetailsLabel = new MetroFramework.Controls.MetroLabel();
            this.themeSwitchTile = new MetroFramework.Controls.MetroTile();
            this.styleListComboBox = new MetroFramework.Controls.MetroComboBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.personGridEdit = new MetroFramework.Controls.MetroGrid();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.phoneEditGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.lastNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.firstNameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.addPersonButton = new MetroFramework.Controls.MetroButton();
            this.updatePersonButton = new MetroFramework.Controls.MetroButton();
            this.deletePersonButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.tabControl.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneGrid)).BeginInit();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personGridEdit)).BeginInit();
            this.metroPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEditGrid)).BeginInit();
            this.metroPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.metroTabPage1);
            this.tabControl.Controls.Add(this.metroTabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(20, 60);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 1;
            this.tabControl.ShowToolTips = true;
            this.tabControl.Size = new System.Drawing.Size(860, 420);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel3);
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(5);
            this.metroTabPage1.Size = new System.Drawing.Size(852, 378);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "View";
            this.metroTabPage1.ToolTipText = "Here you can view all information about people in phonebook.";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroPanel6);
            this.metroTabPage2.Controls.Add(this.metroPanel5);
            this.metroTabPage2.Controls.Add(this.metroPanel4);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(10);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(5);
            this.metroTabPage2.Size = new System.Drawing.Size(852, 378);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Edit";
            this.metroTabPage2.ToolTipText = "Here you can edit all person information.";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.Location = new System.Drawing.Point(10, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Person list";
            this.metroLabel1.UseStyleColors = true;
            // 
            // personGrid
            // 
            this.personGrid.AllowUserToAddRows = false;
            this.personGrid.AllowUserToDeleteRows = false;
            this.personGrid.AllowUserToResizeRows = false;
            this.personGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.personGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.personGrid.ColumnHeadersHeight = 30;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personGrid.DefaultCellStyle = dataGridViewCellStyle5;
            this.personGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personGrid.EnableHeadersVisualStyles = false;
            this.personGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.personGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personGrid.Location = new System.Drawing.Point(10, 29);
            this.personGrid.Name = "personGrid";
            this.personGrid.ReadOnly = true;
            this.personGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.personGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.personGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.personGrid.Size = new System.Drawing.Size(186, 329);
            this.personGrid.TabIndex = 3;
            this.personGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personGrid_CellClick);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.personGrid);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(5, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel1.Size = new System.Drawing.Size(206, 368);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.phoneGrid);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(211, 5);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel2.Size = new System.Drawing.Size(636, 130);
            this.metroPanel2.TabIndex = 5;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.Location = new System.Drawing.Point(10, 10);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(108, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Person phone list";
            this.metroLabel2.UseStyleColors = true;
            // 
            // phoneGrid
            // 
            this.phoneGrid.AllowUserToAddRows = false;
            this.phoneGrid.AllowUserToDeleteRows = false;
            this.phoneGrid.AllowUserToResizeRows = false;
            this.phoneGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.phoneGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.phoneGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.phoneGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneGrid.EnableHeadersVisualStyles = false;
            this.phoneGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneGrid.Location = new System.Drawing.Point(10, 29);
            this.phoneGrid.Name = "phoneGrid";
            this.phoneGrid.ReadOnly = true;
            this.phoneGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.phoneGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.phoneGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phoneGrid.Size = new System.Drawing.Size(616, 91);
            this.phoneGrid.TabIndex = 3;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.personDetailsLabel);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(211, 187);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel3.Size = new System.Drawing.Size(636, 186);
            this.metroPanel3.TabIndex = 6;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.Location = new System.Drawing.Point(10, 10);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(89, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Person details";
            this.metroLabel3.UseStyleColors = true;
            // 
            // personDetailsLabel
            // 
            this.personDetailsLabel.AutoSize = true;
            this.personDetailsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personDetailsLabel.Location = new System.Drawing.Point(10, 29);
            this.personDetailsLabel.Name = "personDetailsLabel";
            this.personDetailsLabel.Size = new System.Drawing.Size(0, 0);
            this.personDetailsLabel.TabIndex = 3;
            // 
            // themeSwitchTile
            // 
            this.themeSwitchTile.ActiveControl = null;
            this.themeSwitchTile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.themeSwitchTile.Location = new System.Drawing.Point(755, 33);
            this.themeSwitchTile.Name = "themeSwitchTile";
            this.themeSwitchTile.Size = new System.Drawing.Size(125, 30);
            this.themeSwitchTile.TabIndex = 2;
            this.themeSwitchTile.Text = "Switch theme";
            this.themeSwitchTile.UseSelectable = true;
            this.themeSwitchTile.Click += new System.EventHandler(this.themeSwitchTile_Click);
            // 
            // styleListComboBox
            // 
            this.styleListComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.styleListComboBox.FormattingEnabled = true;
            this.styleListComboBox.ItemHeight = 23;
            this.styleListComboBox.Location = new System.Drawing.Point(605, 34);
            this.styleListComboBox.Name = "styleListComboBox";
            this.styleListComboBox.Size = new System.Drawing.Size(144, 29);
            this.styleListComboBox.TabIndex = 4;
            this.styleListComboBox.UseSelectable = true;
            this.styleListComboBox.SelectedIndexChanged += new System.EventHandler(this.styleListComboBox_SelectedIndexChanged);
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroLabel9);
            this.metroPanel4.Controls.Add(this.firstNameTextBox);
            this.metroPanel4.Controls.Add(this.metroLabel8);
            this.metroPanel4.Controls.Add(this.lastNameTextBox);
            this.metroPanel4.Controls.Add(this.personGridEdit);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.addPersonButton);
            this.metroPanel4.Controls.Add(this.updatePersonButton);
            this.metroPanel4.Controls.Add(this.deletePersonButton);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(5, 5);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel4.Size = new System.Drawing.Size(206, 368);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // personGridEdit
            // 
            this.personGridEdit.AllowUserToAddRows = false;
            this.personGridEdit.AllowUserToDeleteRows = false;
            this.personGridEdit.AllowUserToResizeColumns = false;
            this.personGridEdit.AllowUserToResizeRows = false;
            this.personGridEdit.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.personGridEdit.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personGridEdit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.personGridEdit.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.personGridEdit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personGridEdit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.personGridEdit.ColumnHeadersHeight = 30;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.personGridEdit.DefaultCellStyle = dataGridViewCellStyle11;
            this.personGridEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.personGridEdit.EnableHeadersVisualStyles = false;
            this.personGridEdit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.personGridEdit.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.personGridEdit.Location = new System.Drawing.Point(10, 29);
            this.personGridEdit.Name = "personGridEdit";
            this.personGridEdit.ReadOnly = true;
            this.personGridEdit.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.personGridEdit.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.personGridEdit.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.personGridEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.personGridEdit.Size = new System.Drawing.Size(186, 169);
            this.personGridEdit.TabIndex = 3;
            this.personGridEdit.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.personGrid_CellClick);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel4.Location = new System.Drawing.Point(10, 10);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(67, 19);
            this.metroLabel4.TabIndex = 2;
            this.metroLabel4.Text = "Person list";
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroPanel5
            // 
            this.metroPanel5.Controls.Add(this.phoneEditGrid);
            this.metroPanel5.Controls.Add(this.metroLabel5);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(211, 5);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel5.Size = new System.Drawing.Size(636, 130);
            this.metroPanel5.TabIndex = 6;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // phoneEditGrid
            // 
            this.phoneEditGrid.AllowUserToAddRows = false;
            this.phoneEditGrid.AllowUserToDeleteRows = false;
            this.phoneEditGrid.AllowUserToResizeRows = false;
            this.phoneEditGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneEditGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneEditGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.phoneEditGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneEditGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.phoneEditGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.phoneEditGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.phoneEditGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.phoneEditGrid.EnableHeadersVisualStyles = false;
            this.phoneEditGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.phoneEditGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.phoneEditGrid.Location = new System.Drawing.Point(10, 29);
            this.phoneEditGrid.Name = "phoneEditGrid";
            this.phoneEditGrid.ReadOnly = true;
            this.phoneEditGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.phoneEditGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.phoneEditGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.phoneEditGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.phoneEditGrid.Size = new System.Drawing.Size(616, 91);
            this.phoneEditGrid.TabIndex = 3;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel5.Location = new System.Drawing.Point(10, 10);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 2;
            this.metroLabel5.Text = "Person phone list";
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this.metroLabel6);
            this.metroPanel6.Controls.Add(this.metroLabel7);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(211, 187);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Padding = new System.Windows.Forms.Padding(10);
            this.metroPanel6.Size = new System.Drawing.Size(636, 186);
            this.metroPanel6.TabIndex = 7;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroLabel6.Location = new System.Drawing.Point(10, 29);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(0, 0);
            this.metroLabel6.TabIndex = 3;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel7.Location = new System.Drawing.Point(10, 10);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(89, 19);
            this.metroLabel7.TabIndex = 2;
            this.metroLabel7.Text = "Person details";
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel8.Location = new System.Drawing.Point(10, 247);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(68, 19);
            this.metroLabel8.TabIndex = 4;
            this.metroLabel8.Text = "Last name";
            this.metroLabel8.UseStyleColors = true;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lastNameTextBox.Lines = new string[0];
            this.lastNameTextBox.Location = new System.Drawing.Point(10, 266);
            this.lastNameTextBox.MaxLength = 32767;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.PasswordChar = '\0';
            this.lastNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lastNameTextBox.SelectedText = "";
            this.lastNameTextBox.Size = new System.Drawing.Size(186, 23);
            this.lastNameTextBox.TabIndex = 5;
            this.lastNameTextBox.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel9.Location = new System.Drawing.Point(10, 205);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(70, 19);
            this.metroLabel9.TabIndex = 6;
            this.metroLabel9.Text = "First name";
            this.metroLabel9.UseStyleColors = true;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.firstNameTextBox.Lines = new string[0];
            this.firstNameTextBox.Location = new System.Drawing.Point(10, 224);
            this.firstNameTextBox.MaxLength = 32767;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.PasswordChar = '\0';
            this.firstNameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.firstNameTextBox.SelectedText = "";
            this.firstNameTextBox.Size = new System.Drawing.Size(186, 23);
            this.firstNameTextBox.TabIndex = 7;
            this.firstNameTextBox.UseSelectable = true;
            // 
            // addPersonButton
            // 
            this.addPersonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.addPersonButton.Location = new System.Drawing.Point(10, 289);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(186, 23);
            this.addPersonButton.TabIndex = 8;
            this.addPersonButton.Text = "Add";
            this.addPersonButton.UseSelectable = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click);
            // 
            // updatePersonButton
            // 
            this.updatePersonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.updatePersonButton.Location = new System.Drawing.Point(10, 312);
            this.updatePersonButton.Name = "updatePersonButton";
            this.updatePersonButton.Size = new System.Drawing.Size(186, 23);
            this.updatePersonButton.TabIndex = 9;
            this.updatePersonButton.Text = "Update";
            this.updatePersonButton.UseSelectable = true;
            this.updatePersonButton.Click += new System.EventHandler(this.updatePersonButton_Click);
            // 
            // deletePersonButton
            // 
            this.deletePersonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.deletePersonButton.Location = new System.Drawing.Point(10, 335);
            this.deletePersonButton.Name = "deletePersonButton";
            this.deletePersonButton.Size = new System.Drawing.Size(186, 23);
            this.deletePersonButton.TabIndex = 10;
            this.deletePersonButton.Text = "Delete";
            this.deletePersonButton.UseSelectable = true;
            this.deletePersonButton.Click += new System.EventHandler(this.deletePersonButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.styleListComboBox);
            this.Controls.Add(this.themeSwitchTile);
            this.Controls.Add(this.tabControl);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "MainForm";
            this.Style = MetroFramework.MetroColorStyle.Default;
            this.Text = "Phonebook";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneGrid)).EndInit();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personGridEdit)).EndInit();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEditGrid)).EndInit();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroGrid personGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroGrid phoneGrid;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel personDetailsLabel;
        private MetroFramework.Controls.MetroTile themeSwitchTile;
        private MetroFramework.Controls.MetroComboBox styleListComboBox;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroGrid phoneEditGrid;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroGrid personGridEdit;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox lastNameTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroTextBox firstNameTextBox;
        private MetroFramework.Controls.MetroButton addPersonButton;
        private MetroFramework.Controls.MetroButton updatePersonButton;
        private MetroFramework.Controls.MetroButton deletePersonButton;

    }
}

