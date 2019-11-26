namespace AzureDentalDev.Forms
{
    partial class AdminHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            this.AdminHomeFormWelcomeLabel = new System.Windows.Forms.Label();
            this.AdminHomeFormCloseLabel = new System.Windows.Forms.Label();
            this.AdminHomeFormMainPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminHomeLogoutLabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminHomeFormTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.AccountsTabPage = new System.Windows.Forms.TabPage();
            this.AdminFormCreateButton = new System.Windows.Forms.Button();
            this.ScheduleTabPage = new System.Windows.Forms.TabPage();
            this.AdminOpenDayLabel = new System.Windows.Forms.Label();
            this.AdminCloseDayLabel = new System.Windows.Forms.Label();
            this.AdminCloseDayButton = new System.Windows.Forms.Button();
            this.AdminOpenDayButton = new System.Windows.Forms.Button();
            this.HoursUpdatedLabel = new System.Windows.Forms.Label();
            this.HoursUpdateButton = new System.Windows.Forms.Button();
            this.CloseTimeComboBox = new System.Windows.Forms.ComboBox();
            this.ToLabel = new System.Windows.Forms.Label();
            this.StartTimeComboBox = new System.Windows.Forms.ComboBox();
            this.AdminHomeFormChangeHoursLabel = new System.Windows.Forms.Label();
            this.AdminDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.HoursLabel = new System.Windows.Forms.Label();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.AdminHomeUserSearch = new System.Windows.Forms.Label();
            this.AdminHomeSearchTextBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminHomeUserSearchButton = new System.Windows.Forms.Button();
            this.AdminSearchPanel = new System.Windows.Forms.Panel();
            this.AdminHomeFullNameLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.AdminUserNameLabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AdminHomeUserTopLabel = new System.Windows.Forms.Label();
            this.AdminHomeTypeTopLabel = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.AdminHomeTypeLabel = new System.Windows.Forms.Label();
            this.AdminHomeActiveTopLabel = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.AdminHomeStatusLabel = new System.Windows.Forms.Label();
            this.AdminActiveButton = new System.Windows.Forms.Button();
            this.AdminHomeDeleteButton = new System.Windows.Forms.Button();
            this.AdminHomeHelpPictureBox = new System.Windows.Forms.PictureBox();
            this.AdminHomeErrorPanel = new System.Windows.Forms.Panel();
            this.AdminErrorMessageLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.AdminErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.AppointmentTab = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeFormMainPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdminHomeFormTabControl.SuspendLayout();
            this.AccountsTabPage.SuspendLayout();
            this.ScheduleTabPage.SuspendLayout();
            this.AdminSearchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeHelpPictureBox)).BeginInit();
            this.AdminHomeErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminErrorPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminHomeFormWelcomeLabel
            // 
            this.AdminHomeFormWelcomeLabel.AutoSize = true;
            this.AdminHomeFormWelcomeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeFormWelcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminHomeFormWelcomeLabel.Location = new System.Drawing.Point(73, 17);
            this.AdminHomeFormWelcomeLabel.Name = "AdminHomeFormWelcomeLabel";
            this.AdminHomeFormWelcomeLabel.Size = new System.Drawing.Size(130, 32);
            this.AdminHomeFormWelcomeLabel.TabIndex = 0;
            this.AdminHomeFormWelcomeLabel.Text = "Welcome";
            // 
            // AdminHomeFormCloseLabel
            // 
            this.AdminHomeFormCloseLabel.AutoSize = true;
            this.AdminHomeFormCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminHomeFormCloseLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeFormCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminHomeFormCloseLabel.Location = new System.Drawing.Point(885, 8);
            this.AdminHomeFormCloseLabel.Name = "AdminHomeFormCloseLabel";
            this.AdminHomeFormCloseLabel.Size = new System.Drawing.Size(19, 18);
            this.AdminHomeFormCloseLabel.TabIndex = 1;
            this.AdminHomeFormCloseLabel.Text = "X";
            this.AdminHomeFormCloseLabel.Click += new System.EventHandler(this.AdminHomeFormCloseLabel_Click);
            // 
            // AdminHomeFormMainPictureBox
            // 
            this.AdminHomeFormMainPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminHomeFormMainPictureBox.BackgroundImage")));
            this.AdminHomeFormMainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AdminHomeFormMainPictureBox.Name = "AdminHomeFormMainPictureBox";
            this.AdminHomeFormMainPictureBox.Size = new System.Drawing.Size(64, 62);
            this.AdminHomeFormMainPictureBox.TabIndex = 2;
            this.AdminHomeFormMainPictureBox.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.AdminHomeLogoutLabel);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.AdminHomeFormMainPictureBox);
            this.panel1.Controls.Add(this.AdminHomeFormWelcomeLabel);
            this.panel1.Controls.Add(this.AdminHomeFormCloseLabel);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 67);
            this.panel1.TabIndex = 3;
            // 
            // AdminHomeLogoutLabel
            // 
            this.AdminHomeLogoutLabel.AutoSize = true;
            this.AdminHomeLogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminHomeLogoutLabel.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeLogoutLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminHomeLogoutLabel.Location = new System.Drawing.Point(814, 10);
            this.AdminHomeLogoutLabel.Name = "AdminHomeLogoutLabel";
            this.AdminHomeLogoutLabel.Size = new System.Drawing.Size(57, 16);
            this.AdminHomeLogoutLabel.TabIndex = 4;
            this.AdminHomeLogoutLabel.Text = "Logout";
            this.AdminHomeLogoutLabel.Click += new System.EventHandler(this.AdminHomeLogoutLabel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Location = new System.Drawing.Point(877, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 18);
            this.panel2.TabIndex = 3;
            // 
            // AdminHomeFormTabControl
            // 
            this.AdminHomeFormTabControl.Controls.Add(this.AccountsTabPage);
            this.AdminHomeFormTabControl.Controls.Add(this.ScheduleTabPage);
            this.AdminHomeFormTabControl.Controls.Add(this.AppointmentTab);
            this.AdminHomeFormTabControl.Depth = 0;
            this.AdminHomeFormTabControl.Location = new System.Drawing.Point(3, 102);
            this.AdminHomeFormTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminHomeFormTabControl.Name = "AdminHomeFormTabControl";
            this.AdminHomeFormTabControl.SelectedIndex = 0;
            this.AdminHomeFormTabControl.Size = new System.Drawing.Size(916, 428);
            this.AdminHomeFormTabControl.TabIndex = 4;
            // 
            // AccountsTabPage
            // 
            this.AccountsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountsTabPage.Controls.Add(this.AdminSearchPanel);
            this.AccountsTabPage.Controls.Add(this.AdminHomeUserSearchButton);
            this.AccountsTabPage.Controls.Add(this.panel3);
            this.AccountsTabPage.Controls.Add(this.AdminHomeSearchTextBox);
            this.AccountsTabPage.Controls.Add(this.AdminHomeUserSearch);
            this.AccountsTabPage.Controls.Add(this.AdminFormCreateButton);
            this.AccountsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AccountsTabPage.Name = "AccountsTabPage";
            this.AccountsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsTabPage.Size = new System.Drawing.Size(908, 402);
            this.AccountsTabPage.TabIndex = 0;
            this.AccountsTabPage.Text = "Accounts";
            // 
            // AdminFormCreateButton
            // 
            this.AdminFormCreateButton.BackColor = System.Drawing.Color.Aqua;
            this.AdminFormCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminFormCreateButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFormCreateButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdminFormCreateButton.Location = new System.Drawing.Point(712, 178);
            this.AdminFormCreateButton.Name = "AdminFormCreateButton";
            this.AdminFormCreateButton.Size = new System.Drawing.Size(131, 126);
            this.AdminFormCreateButton.TabIndex = 0;
            this.AdminFormCreateButton.Text = "Create Account";
            this.AdminFormCreateButton.UseVisualStyleBackColor = false;
            this.AdminFormCreateButton.Click += new System.EventHandler(this.AdminFormCreateButton_Click);
            // 
            // ScheduleTabPage
            // 
            this.ScheduleTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScheduleTabPage.Controls.Add(this.AdminOpenDayLabel);
            this.ScheduleTabPage.Controls.Add(this.AdminCloseDayLabel);
            this.ScheduleTabPage.Controls.Add(this.AdminCloseDayButton);
            this.ScheduleTabPage.Controls.Add(this.AdminOpenDayButton);
            this.ScheduleTabPage.Controls.Add(this.HoursUpdatedLabel);
            this.ScheduleTabPage.Controls.Add(this.HoursUpdateButton);
            this.ScheduleTabPage.Controls.Add(this.CloseTimeComboBox);
            this.ScheduleTabPage.Controls.Add(this.ToLabel);
            this.ScheduleTabPage.Controls.Add(this.StartTimeComboBox);
            this.ScheduleTabPage.Controls.Add(this.AdminHomeFormChangeHoursLabel);
            this.ScheduleTabPage.Controls.Add(this.AdminDateTimePicker);
            this.ScheduleTabPage.Controls.Add(this.label1);
            this.ScheduleTabPage.Controls.Add(this.HoursLabel);
            this.ScheduleTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScheduleTabPage.Name = "ScheduleTabPage";
            this.ScheduleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduleTabPage.Size = new System.Drawing.Size(908, 402);
            this.ScheduleTabPage.TabIndex = 1;
            this.ScheduleTabPage.Text = "Schedule";
            // 
            // AdminOpenDayLabel
            // 
            this.AdminOpenDayLabel.AutoSize = true;
            this.AdminOpenDayLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminOpenDayLabel.ForeColor = System.Drawing.Color.Lime;
            this.AdminOpenDayLabel.Location = new System.Drawing.Point(401, 113);
            this.AdminOpenDayLabel.Name = "AdminOpenDayLabel";
            this.AdminOpenDayLabel.Size = new System.Drawing.Size(180, 16);
            this.AdminOpenDayLabel.TabIndex = 12;
            this.AdminOpenDayLabel.Text = "We are now open on this day!";
            this.AdminOpenDayLabel.Visible = false;
            // 
            // AdminCloseDayLabel
            // 
            this.AdminCloseDayLabel.AutoSize = true;
            this.AdminCloseDayLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCloseDayLabel.ForeColor = System.Drawing.Color.Red;
            this.AdminCloseDayLabel.Location = new System.Drawing.Point(401, 135);
            this.AdminCloseDayLabel.Name = "AdminCloseDayLabel";
            this.AdminCloseDayLabel.Size = new System.Drawing.Size(192, 16);
            this.AdminCloseDayLabel.TabIndex = 11;
            this.AdminCloseDayLabel.Text = "We are now closed on this Day!";
            this.AdminCloseDayLabel.Visible = false;
            // 
            // AdminCloseDayButton
            // 
            this.AdminCloseDayButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCloseDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminCloseDayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCloseDayButton.ForeColor = System.Drawing.Color.Aqua;
            this.AdminCloseDayButton.Location = new System.Drawing.Point(536, 154);
            this.AdminCloseDayButton.Name = "AdminCloseDayButton";
            this.AdminCloseDayButton.Size = new System.Drawing.Size(124, 36);
            this.AdminCloseDayButton.TabIndex = 10;
            this.AdminCloseDayButton.Text = "Close Day";
            this.AdminCloseDayButton.UseVisualStyleBackColor = false;
            this.AdminCloseDayButton.Click += new System.EventHandler(this.AdminCloseDayButton_Click);
            // 
            // AdminOpenDayButton
            // 
            this.AdminOpenDayButton.BackColor = System.Drawing.Color.Aqua;
            this.AdminOpenDayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminOpenDayButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminOpenDayButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminOpenDayButton.Location = new System.Drawing.Point(404, 154);
            this.AdminOpenDayButton.Name = "AdminOpenDayButton";
            this.AdminOpenDayButton.Size = new System.Drawing.Size(124, 35);
            this.AdminOpenDayButton.TabIndex = 9;
            this.AdminOpenDayButton.Text = "Open Day";
            this.AdminOpenDayButton.UseVisualStyleBackColor = false;
            this.AdminOpenDayButton.Click += new System.EventHandler(this.AdminOpenDayButton_Click);
            // 
            // HoursUpdatedLabel
            // 
            this.HoursUpdatedLabel.AutoSize = true;
            this.HoursUpdatedLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursUpdatedLabel.ForeColor = System.Drawing.Color.Lime;
            this.HoursUpdatedLabel.Location = new System.Drawing.Point(168, 154);
            this.HoursUpdatedLabel.Name = "HoursUpdatedLabel";
            this.HoursUpdatedLabel.Size = new System.Drawing.Size(159, 16);
            this.HoursUpdatedLabel.TabIndex = 8;
            this.HoursUpdatedLabel.Text = "Hours have been Updated!";
            this.HoursUpdatedLabel.Visible = false;
            // 
            // HoursUpdateButton
            // 
            this.HoursUpdateButton.BackColor = System.Drawing.Color.Aqua;
            this.HoursUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HoursUpdateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursUpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HoursUpdateButton.Location = new System.Drawing.Point(11, 154);
            this.HoursUpdateButton.Name = "HoursUpdateButton";
            this.HoursUpdateButton.Size = new System.Drawing.Size(124, 36);
            this.HoursUpdateButton.TabIndex = 7;
            this.HoursUpdateButton.Text = "Update";
            this.HoursUpdateButton.UseVisualStyleBackColor = false;
            this.HoursUpdateButton.Click += new System.EventHandler(this.HoursUpdateButton_Click);
            // 
            // CloseTimeComboBox
            // 
            this.CloseTimeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseTimeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseTimeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseTimeComboBox.ForeColor = System.Drawing.Color.Gray;
            this.CloseTimeComboBox.FormattingEnabled = true;
            this.CloseTimeComboBox.Location = new System.Drawing.Point(168, 103);
            this.CloseTimeComboBox.Name = "CloseTimeComboBox";
            this.CloseTimeComboBox.Size = new System.Drawing.Size(121, 26);
            this.CloseTimeComboBox.TabIndex = 6;
            this.CloseTimeComboBox.Text = "17:00";
            // 
            // ToLabel
            // 
            this.ToLabel.AutoSize = true;
            this.ToLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToLabel.ForeColor = System.Drawing.Color.Gray;
            this.ToLabel.Location = new System.Drawing.Point(138, 111);
            this.ToLabel.Name = "ToLabel";
            this.ToLabel.Size = new System.Drawing.Size(24, 18);
            this.ToLabel.TabIndex = 5;
            this.ToLabel.Text = "To";
            // 
            // StartTimeComboBox
            // 
            this.StartTimeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StartTimeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartTimeComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeComboBox.ForeColor = System.Drawing.Color.Gray;
            this.StartTimeComboBox.FormattingEnabled = true;
            this.StartTimeComboBox.Location = new System.Drawing.Point(11, 103);
            this.StartTimeComboBox.Name = "StartTimeComboBox";
            this.StartTimeComboBox.Size = new System.Drawing.Size(121, 26);
            this.StartTimeComboBox.TabIndex = 4;
            this.StartTimeComboBox.Text = "9:00";
            // 
            // AdminHomeFormChangeHoursLabel
            // 
            this.AdminHomeFormChangeHoursLabel.AutoSize = true;
            this.AdminHomeFormChangeHoursLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeFormChangeHoursLabel.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeFormChangeHoursLabel.Location = new System.Drawing.Point(400, 56);
            this.AdminHomeFormChangeHoursLabel.Name = "AdminHomeFormChangeHoursLabel";
            this.AdminHomeFormChangeHoursLabel.Size = new System.Drawing.Size(245, 22);
            this.AdminHomeFormChangeHoursLabel.TabIndex = 3;
            this.AdminHomeFormChangeHoursLabel.Text = "Open/Close a specific date:";
            // 
            // AdminDateTimePicker
            // 
            this.AdminDateTimePicker.Location = new System.Drawing.Point(404, 82);
            this.AdminDateTimePicker.Name = "AdminDateTimePicker";
            this.AdminDateTimePicker.Size = new System.Drawing.Size(256, 20);
            this.AdminDateTimePicker.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Open Monday-Friday from";
            // 
            // HoursLabel
            // 
            this.HoursLabel.AutoSize = true;
            this.HoursLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursLabel.ForeColor = System.Drawing.Color.Aqua;
            this.HoursLabel.Location = new System.Drawing.Point(7, 56);
            this.HoursLabel.Name = "HoursLabel";
            this.HoursLabel.Size = new System.Drawing.Size(242, 22);
            this.HoursLabel.TabIndex = 0;
            this.HoursLabel.Text = "Current Hours of Operation:";
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.materialTabSelector1.BaseTabControl = this.AdminHomeFormTabControl;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 72);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(919, 23);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // AdminHomeUserSearch
            // 
            this.AdminHomeUserSearch.AutoSize = true;
            this.AdminHomeUserSearch.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeUserSearch.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeUserSearch.Location = new System.Drawing.Point(6, 13);
            this.AdminHomeUserSearch.Name = "AdminHomeUserSearch";
            this.AdminHomeUserSearch.Size = new System.Drawing.Size(127, 18);
            this.AdminHomeUserSearch.TabIndex = 1;
            this.AdminHomeUserSearch.Text = "Search for a user";
            // 
            // AdminHomeSearchTextBox
            // 
            this.AdminHomeSearchTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminHomeSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminHomeSearchTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeSearchTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.AdminHomeSearchTextBox.Location = new System.Drawing.Point(9, 35);
            this.AdminHomeSearchTextBox.Name = "AdminHomeSearchTextBox";
            this.AdminHomeSearchTextBox.Size = new System.Drawing.Size(164, 22);
            this.AdminHomeSearchTextBox.TabIndex = 2;
            this.AdminHomeSearchTextBox.Text = "Enter a Username";
            this.AdminHomeSearchTextBox.Enter += new System.EventHandler(this.AdminHomeSearchTextBox_Enter);
            this.AdminHomeSearchTextBox.Leave += new System.EventHandler(this.AdminHomeSearchTextBox_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Cyan;
            this.panel3.Location = new System.Drawing.Point(9, 63);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 1);
            this.panel3.TabIndex = 3;
            // 
            // AdminHomeUserSearchButton
            // 
            this.AdminHomeUserSearchButton.BackColor = System.Drawing.Color.Cyan;
            this.AdminHomeUserSearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminHomeUserSearchButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeUserSearchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminHomeUserSearchButton.Location = new System.Drawing.Point(191, 40);
            this.AdminHomeUserSearchButton.Name = "AdminHomeUserSearchButton";
            this.AdminHomeUserSearchButton.Size = new System.Drawing.Size(75, 23);
            this.AdminHomeUserSearchButton.TabIndex = 4;
            this.AdminHomeUserSearchButton.Text = "Search";
            this.AdminHomeUserSearchButton.UseVisualStyleBackColor = false;
            this.AdminHomeUserSearchButton.Click += new System.EventHandler(this.AdminHomeUserSearchButton_Click);
            // 
            // AdminSearchPanel
            // 
            this.AdminSearchPanel.Controls.Add(this.AdminHomeDeleteButton);
            this.AdminSearchPanel.Controls.Add(this.AdminActiveButton);
            this.AdminSearchPanel.Controls.Add(this.AdminHomeActiveTopLabel);
            this.AdminSearchPanel.Controls.Add(this.panel8);
            this.AdminSearchPanel.Controls.Add(this.AdminHomeStatusLabel);
            this.AdminSearchPanel.Controls.Add(this.AdminHomeTypeTopLabel);
            this.AdminSearchPanel.Controls.Add(this.panel7);
            this.AdminSearchPanel.Controls.Add(this.AdminHomeTypeLabel);
            this.AdminSearchPanel.Controls.Add(this.AdminHomeUserTopLabel);
            this.AdminSearchPanel.Controls.Add(this.panel6);
            this.AdminSearchPanel.Controls.Add(this.AdminUserNameLabel);
            this.AdminSearchPanel.Controls.Add(this.panel5);
            this.AdminSearchPanel.Controls.Add(this.AdminHomeFullNameLabel);
            this.AdminSearchPanel.Location = new System.Drawing.Point(9, 71);
            this.AdminSearchPanel.Name = "AdminSearchPanel";
            this.AdminSearchPanel.Size = new System.Drawing.Size(697, 323);
            this.AdminSearchPanel.TabIndex = 5;
            this.AdminSearchPanel.Visible = false;
            // 
            // AdminHomeFullNameLabel
            // 
            this.AdminHomeFullNameLabel.AutoSize = true;
            this.AdminHomeFullNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeFullNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.AdminHomeFullNameLabel.Location = new System.Drawing.Point(21, 22);
            this.AdminHomeFullNameLabel.Name = "AdminHomeFullNameLabel";
            this.AdminHomeFullNameLabel.Size = new System.Drawing.Size(106, 24);
            this.AdminHomeFullNameLabel.TabIndex = 0;
            this.AdminHomeFullNameLabel.Text = "First Last";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Cyan;
            this.panel5.Location = new System.Drawing.Point(25, 45);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(180, 1);
            this.panel5.TabIndex = 4;
            // 
            // AdminUserNameLabel
            // 
            this.AdminUserNameLabel.AutoSize = true;
            this.AdminUserNameLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUserNameLabel.ForeColor = System.Drawing.Color.Gray;
            this.AdminUserNameLabel.Location = new System.Drawing.Point(21, 100);
            this.AdminUserNameLabel.Name = "AdminUserNameLabel";
            this.AdminUserNameLabel.Size = new System.Drawing.Size(112, 24);
            this.AdminUserNameLabel.TabIndex = 5;
            this.AdminUserNameLabel.Text = "Username";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Cyan;
            this.panel6.Location = new System.Drawing.Point(25, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(180, 1);
            this.panel6.TabIndex = 6;
            // 
            // AdminHomeUserTopLabel
            // 
            this.AdminHomeUserTopLabel.AutoSize = true;
            this.AdminHomeUserTopLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeUserTopLabel.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeUserTopLabel.Location = new System.Drawing.Point(22, 82);
            this.AdminHomeUserTopLabel.Name = "AdminHomeUserTopLabel";
            this.AdminHomeUserTopLabel.Size = new System.Drawing.Size(80, 18);
            this.AdminHomeUserTopLabel.TabIndex = 7;
            this.AdminHomeUserTopLabel.Text = "Username";
            // 
            // AdminHomeTypeTopLabel
            // 
            this.AdminHomeTypeTopLabel.AutoSize = true;
            this.AdminHomeTypeTopLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeTypeTopLabel.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeTypeTopLabel.Location = new System.Drawing.Point(22, 159);
            this.AdminHomeTypeTopLabel.Name = "AdminHomeTypeTopLabel";
            this.AdminHomeTypeTopLabel.Size = new System.Drawing.Size(78, 18);
            this.AdminHomeTypeTopLabel.TabIndex = 10;
            this.AdminHomeTypeTopLabel.Text = "User Type";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Cyan;
            this.panel7.Location = new System.Drawing.Point(25, 204);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(180, 1);
            this.panel7.TabIndex = 9;
            // 
            // AdminHomeTypeLabel
            // 
            this.AdminHomeTypeLabel.AutoSize = true;
            this.AdminHomeTypeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeTypeLabel.ForeColor = System.Drawing.Color.Gray;
            this.AdminHomeTypeLabel.Location = new System.Drawing.Point(21, 177);
            this.AdminHomeTypeLabel.Name = "AdminHomeTypeLabel";
            this.AdminHomeTypeLabel.Size = new System.Drawing.Size(103, 24);
            this.AdminHomeTypeLabel.TabIndex = 8;
            this.AdminHomeTypeLabel.Text = "UserType";
            // 
            // AdminHomeActiveTopLabel
            // 
            this.AdminHomeActiveTopLabel.AutoSize = true;
            this.AdminHomeActiveTopLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeActiveTopLabel.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeActiveTopLabel.Location = new System.Drawing.Point(22, 249);
            this.AdminHomeActiveTopLabel.Name = "AdminHomeActiveTopLabel";
            this.AdminHomeActiveTopLabel.Size = new System.Drawing.Size(99, 18);
            this.AdminHomeActiveTopLabel.TabIndex = 13;
            this.AdminHomeActiveTopLabel.Text = "Active Status";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Cyan;
            this.panel8.Location = new System.Drawing.Point(25, 294);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(180, 1);
            this.panel8.TabIndex = 12;
            // 
            // AdminHomeStatusLabel
            // 
            this.AdminHomeStatusLabel.AutoSize = true;
            this.AdminHomeStatusLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeStatusLabel.ForeColor = System.Drawing.Color.Gray;
            this.AdminHomeStatusLabel.Location = new System.Drawing.Point(21, 267);
            this.AdminHomeStatusLabel.Name = "AdminHomeStatusLabel";
            this.AdminHomeStatusLabel.Size = new System.Drawing.Size(74, 24);
            this.AdminHomeStatusLabel.TabIndex = 11;
            this.AdminHomeStatusLabel.Text = "Active";
            // 
            // AdminActiveButton
            // 
            this.AdminActiveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminActiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminActiveButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminActiveButton.ForeColor = System.Drawing.Color.Aqua;
            this.AdminActiveButton.Location = new System.Drawing.Point(283, 106);
            this.AdminActiveButton.Name = "AdminActiveButton";
            this.AdminActiveButton.Size = new System.Drawing.Size(129, 127);
            this.AdminActiveButton.TabIndex = 14;
            this.AdminActiveButton.Text = "Re-Activate Account";
            this.AdminActiveButton.UseVisualStyleBackColor = false;
            // 
            // AdminHomeDeleteButton
            // 
            this.AdminHomeDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminHomeDeleteButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AdminHomeDeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminHomeDeleteButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeDeleteButton.ForeColor = System.Drawing.Color.White;
            this.AdminHomeDeleteButton.Location = new System.Drawing.Point(504, 107);
            this.AdminHomeDeleteButton.Name = "AdminHomeDeleteButton";
            this.AdminHomeDeleteButton.Size = new System.Drawing.Size(129, 126);
            this.AdminHomeDeleteButton.TabIndex = 15;
            this.AdminHomeDeleteButton.Text = "Delete Account";
            this.AdminHomeDeleteButton.UseVisualStyleBackColor = false;
            // 
            // AdminHomeHelpPictureBox
            // 
            this.AdminHomeHelpPictureBox.BackgroundImage = global::AzureDentalDev.Properties.Resources.info_512pxGREY_2_28x28;
            this.AdminHomeHelpPictureBox.Location = new System.Drawing.Point(872, 536);
            this.AdminHomeHelpPictureBox.Name = "AdminHomeHelpPictureBox";
            this.AdminHomeHelpPictureBox.Size = new System.Drawing.Size(28, 28);
            this.AdminHomeHelpPictureBox.TabIndex = 6;
            this.AdminHomeHelpPictureBox.TabStop = false;
            // 
            // AdminHomeErrorPanel
            // 
            this.AdminHomeErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.AdminHomeErrorPanel.Controls.Add(this.AdminErrorPictureBox);
            this.AdminHomeErrorPanel.Controls.Add(this.AdminErrorMessageLabel);
            this.AdminHomeErrorPanel.Location = new System.Drawing.Point(0, 545);
            this.AdminHomeErrorPanel.Name = "AdminHomeErrorPanel";
            this.AdminHomeErrorPanel.Size = new System.Drawing.Size(916, 33);
            this.AdminHomeErrorPanel.TabIndex = 7;
            this.AdminHomeErrorPanel.Visible = false;
            // 
            // AdminErrorMessageLabel
            // 
            this.AdminErrorMessageLabel.AutoSize = true;
            this.AdminErrorMessageLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminErrorMessageLabel.ForeColor = System.Drawing.Color.White;
            this.AdminErrorMessageLabel.Location = new System.Drawing.Point(416, 5);
            this.AdminErrorMessageLabel.Name = "AdminErrorMessageLabel";
            this.AdminErrorMessageLabel.Size = new System.Drawing.Size(125, 20);
            this.AdminErrorMessageLabel.TabIndex = 0;
            this.AdminErrorMessageLabel.Text = "ERROR MESSAGE";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AdminErrorPictureBox
            // 
            this.AdminErrorPictureBox.BackgroundImage = global::AzureDentalDev.Properties.Resources.error_1_32x32;
            this.AdminErrorPictureBox.Location = new System.Drawing.Point(16, 0);
            this.AdminErrorPictureBox.Name = "AdminErrorPictureBox";
            this.AdminErrorPictureBox.Size = new System.Drawing.Size(32, 32);
            this.AdminErrorPictureBox.TabIndex = 1;
            this.AdminErrorPictureBox.TabStop = false;
            // 
            // AppointmentTab
            // 
            this.AppointmentTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AppointmentTab.Location = new System.Drawing.Point(4, 22);
            this.AppointmentTab.Name = "AppointmentTab";
            this.AppointmentTab.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentTab.Size = new System.Drawing.Size(908, 402);
            this.AppointmentTab.TabIndex = 2;
            this.AppointmentTab.Text = "Appointments";
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(916, 575);
            this.Controls.Add(this.AdminHomeErrorPanel);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.AdminHomeHelpPictureBox);
            this.Controls.Add(this.AdminHomeFormTabControl);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome!";
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeFormMainPictureBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.AdminHomeFormTabControl.ResumeLayout(false);
            this.AccountsTabPage.ResumeLayout(false);
            this.AccountsTabPage.PerformLayout();
            this.ScheduleTabPage.ResumeLayout(false);
            this.ScheduleTabPage.PerformLayout();
            this.AdminSearchPanel.ResumeLayout(false);
            this.AdminSearchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeHelpPictureBox)).EndInit();
            this.AdminHomeErrorPanel.ResumeLayout(false);
            this.AdminHomeErrorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminErrorPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AdminHomeFormWelcomeLabel;
        private System.Windows.Forms.Label AdminHomeFormCloseLabel;
        private System.Windows.Forms.PictureBox AdminHomeFormMainPictureBox;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTabControl AdminHomeFormTabControl;
        private System.Windows.Forms.TabPage AccountsTabPage;
        private System.Windows.Forms.TabPage ScheduleTabPage;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private System.Windows.Forms.Button AdminFormCreateButton;
        private System.Windows.Forms.Label AdminHomeFormChangeHoursLabel;
        private System.Windows.Forms.DateTimePicker AdminDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label HoursLabel;
        private System.Windows.Forms.ComboBox StartTimeComboBox;
        private System.Windows.Forms.ComboBox CloseTimeComboBox;
        private System.Windows.Forms.Label ToLabel;
        private System.Windows.Forms.Button HoursUpdateButton;
        private System.Windows.Forms.Label HoursUpdatedLabel;
        private System.Windows.Forms.Button AdminCloseDayButton;
        private System.Windows.Forms.Button AdminOpenDayButton;
        private System.Windows.Forms.Label AdminOpenDayLabel;
        private System.Windows.Forms.Label AdminCloseDayLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label AdminHomeLogoutLabel;
        private System.Windows.Forms.PictureBox AdminHomeHelpPictureBox;
        private System.Windows.Forms.Panel AdminSearchPanel;
        private System.Windows.Forms.Button AdminHomeDeleteButton;
        private System.Windows.Forms.Button AdminActiveButton;
        private System.Windows.Forms.Label AdminHomeActiveTopLabel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label AdminHomeStatusLabel;
        private System.Windows.Forms.Label AdminHomeTypeTopLabel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label AdminHomeTypeLabel;
        private System.Windows.Forms.Label AdminHomeUserTopLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label AdminUserNameLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label AdminHomeFullNameLabel;
        private System.Windows.Forms.Button AdminHomeUserSearchButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AdminHomeSearchTextBox;
        private System.Windows.Forms.Label AdminHomeUserSearch;
        private System.Windows.Forms.Panel AdminHomeErrorPanel;
        private System.Windows.Forms.Label AdminErrorMessageLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox AdminErrorPictureBox;
        private System.Windows.Forms.TabPage AppointmentTab;
    }
}