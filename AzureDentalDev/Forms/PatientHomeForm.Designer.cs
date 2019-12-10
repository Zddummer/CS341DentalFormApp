/**
 * 
 * Auto-generated code used to construct the patient home form
 * 
 * 
 */
namespace AzureDentalDev.Forms
{
    partial class PatientHomeForm
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
            this.PatientHomeFormWelcome = new System.Windows.Forms.Label();
            this.AppointmentsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ScheduleAppointmentButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.AppointmentConfirmationPanel = new System.Windows.Forms.Panel();
            this.DenyConfirmationButton = new System.Windows.Forms.Button();
            this.ConfirmationMessage = new System.Windows.Forms.Label();
            this.AppointmentConfirmationButton = new System.Windows.Forms.Button();
            this.PickTimeComboBox = new System.Windows.Forms.ComboBox();
            this.ClosePatientHomeFormButton = new System.Windows.Forms.Button();
            this.ScheduleDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DentistHygeinistComboBox = new System.Windows.Forms.ComboBox();
            this.AppointmentTypeComboBox = new System.Windows.Forms.ComboBox();
            this.ErrorMessageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PatientHomeLogoutLabel = new System.Windows.Forms.Label();
            this.AppointmentDetailsPanel = new System.Windows.Forms.Panel();
            this.ConfirmCancelAppointmentPanel = new System.Windows.Forms.Panel();
            this.ConfirmCancelAppointmentButton = new System.Windows.Forms.Button();
            this.DenyCancelAppointmentButton = new System.Windows.Forms.Button();
            this.CancelAppointmentConfirmationLabel = new System.Windows.Forms.Label();
            this.CloseAppointmentDetailsButton = new System.Windows.Forms.Button();
            this.CancelAppointmentButton = new System.Windows.Forms.Button();
            this.AppointmentDetailsLabel = new System.Windows.Forms.Label();
            this.HelpPictureBox = new System.Windows.Forms.PictureBox();
            this.AppointmentConfirmationPanel.SuspendLayout();
            this.AppointmentDetailsPanel.SuspendLayout();
            this.ConfirmCancelAppointmentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientHomeFormWelcome
            // 
            this.PatientHomeFormWelcome.AutoSize = true;
            this.PatientHomeFormWelcome.Font = new System.Drawing.Font("Arial", 22F);
            this.PatientHomeFormWelcome.ForeColor = System.Drawing.Color.Aqua;
            this.PatientHomeFormWelcome.Location = new System.Drawing.Point(13, 13);
            this.PatientHomeFormWelcome.Name = "PatientHomeFormWelcome";
            this.PatientHomeFormWelcome.Size = new System.Drawing.Size(139, 35);
            this.PatientHomeFormWelcome.TabIndex = 0;
            this.PatientHomeFormWelcome.Text = "Welcome";
            // 
            // AppointmentsList
            // 
            this.AppointmentsList.BackColor = System.Drawing.Color.DimGray;
            this.AppointmentsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.AppointmentsList.HideSelection = false;
            this.AppointmentsList.Location = new System.Drawing.Point(12, 91);
            this.AppointmentsList.Name = "AppointmentsList";
            this.AppointmentsList.Size = new System.Drawing.Size(308, 336);
            this.AppointmentsList.TabIndex = 1;
            this.AppointmentsList.TileSize = new System.Drawing.Size(150, 80);
            this.AppointmentsList.UseCompatibleStateImageBehavior = false;
            this.AppointmentsList.View = System.Windows.Forms.View.Tile;
            this.AppointmentsList.ItemActivate += new System.EventHandler(this.AppointmentsList_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 173;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 215;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Width = 210;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Width = 195;
            // 
            // ScheduleAppointmentButton
            // 
            this.ScheduleAppointmentButton.BackColor = System.Drawing.Color.Aqua;
            this.ScheduleAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScheduleAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ScheduleAppointmentButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleAppointmentButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ScheduleAppointmentButton.Location = new System.Drawing.Point(552, 69);
            this.ScheduleAppointmentButton.Name = "ScheduleAppointmentButton";
            this.ScheduleAppointmentButton.Size = new System.Drawing.Size(142, 78);
            this.ScheduleAppointmentButton.TabIndex = 2;
            this.ScheduleAppointmentButton.Text = "Schedule Appointment";
            this.ScheduleAppointmentButton.UseVisualStyleBackColor = false;
            this.ScheduleAppointmentButton.Click += new System.EventHandler(this.ScheduleAppointmentButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.Font = new System.Drawing.Font("Arial", 9F);
            this.dateTimePicker1.Location = new System.Drawing.Point(372, 246);
            this.dateTimePicker1.MaxDate = new System.DateTime(9998, 10, 19, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(242, 21);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2019, 12, 7, 12, 34, 37, 78);
            this.dateTimePicker1.Visible = false;
            // 
            // AppointmentConfirmationPanel
            // 
            this.AppointmentConfirmationPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AppointmentConfirmationPanel.Controls.Add(this.DenyConfirmationButton);
            this.AppointmentConfirmationPanel.Controls.Add(this.ConfirmationMessage);
            this.AppointmentConfirmationPanel.Controls.Add(this.AppointmentConfirmationButton);
            this.AppointmentConfirmationPanel.Location = new System.Drawing.Point(506, 289);
            this.AppointmentConfirmationPanel.Name = "AppointmentConfirmationPanel";
            this.AppointmentConfirmationPanel.Size = new System.Drawing.Size(200, 100);
            this.AppointmentConfirmationPanel.TabIndex = 4;
            this.AppointmentConfirmationPanel.Visible = false;
            // 
            // DenyConfirmationButton
            // 
            this.DenyConfirmationButton.BackColor = System.Drawing.Color.Aqua;
            this.DenyConfirmationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DenyConfirmationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DenyConfirmationButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenyConfirmationButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.DenyConfirmationButton.Location = new System.Drawing.Point(17, 63);
            this.DenyConfirmationButton.Name = "DenyConfirmationButton";
            this.DenyConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.DenyConfirmationButton.TabIndex = 2;
            this.DenyConfirmationButton.Text = "Cancel";
            this.DenyConfirmationButton.UseVisualStyleBackColor = false;
            this.DenyConfirmationButton.Click += new System.EventHandler(this.DenyConfirmationButton_Click);
            // 
            // ConfirmationMessage
            // 
            this.ConfirmationMessage.AutoSize = true;
            this.ConfirmationMessage.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmationMessage.ForeColor = System.Drawing.Color.Aqua;
            this.ConfirmationMessage.Location = new System.Drawing.Point(23, 16);
            this.ConfirmationMessage.Name = "ConfirmationMessage";
            this.ConfirmationMessage.Size = new System.Drawing.Size(156, 18);
            this.ConfirmationMessage.TabIndex = 1;
            this.ConfirmationMessage.Text = "Confirm Appointment";
            // 
            // AppointmentConfirmationButton
            // 
            this.AppointmentConfirmationButton.BackColor = System.Drawing.Color.Aqua;
            this.AppointmentConfirmationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentConfirmationButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AppointmentConfirmationButton.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentConfirmationButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AppointmentConfirmationButton.Location = new System.Drawing.Point(113, 63);
            this.AppointmentConfirmationButton.Name = "AppointmentConfirmationButton";
            this.AppointmentConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentConfirmationButton.TabIndex = 0;
            this.AppointmentConfirmationButton.Text = "Okay";
            this.AppointmentConfirmationButton.UseVisualStyleBackColor = false;
            this.AppointmentConfirmationButton.Click += new System.EventHandler(this.AppointmentConfirmationButton_Click);
            // 
            // PickTimeComboBox
            // 
            this.PickTimeComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PickTimeComboBox.Font = new System.Drawing.Font("Arial", 8.25F);
            this.PickTimeComboBox.FormattingEnabled = true;
            this.PickTimeComboBox.Location = new System.Drawing.Point(644, 245);
            this.PickTimeComboBox.Name = "PickTimeComboBox";
            this.PickTimeComboBox.Size = new System.Drawing.Size(144, 22);
            this.PickTimeComboBox.TabIndex = 5;
            this.PickTimeComboBox.Text = "Select Appointment Time";
            this.PickTimeComboBox.Visible = false;
            this.PickTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.PickTimeComboBox_SelectedIndexChanged);
            // 
            // ClosePatientHomeFormButton
            // 
            this.ClosePatientHomeFormButton.BackColor = System.Drawing.Color.DimGray;
            this.ClosePatientHomeFormButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClosePatientHomeFormButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClosePatientHomeFormButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClosePatientHomeFormButton.ForeColor = System.Drawing.Color.Aqua;
            this.ClosePatientHomeFormButton.Location = new System.Drawing.Point(713, 13);
            this.ClosePatientHomeFormButton.Name = "ClosePatientHomeFormButton";
            this.ClosePatientHomeFormButton.Size = new System.Drawing.Size(52, 32);
            this.ClosePatientHomeFormButton.TabIndex = 6;
            this.ClosePatientHomeFormButton.Text = "X";
            this.ClosePatientHomeFormButton.UseVisualStyleBackColor = false;
            this.ClosePatientHomeFormButton.Click += new System.EventHandler(this.ClosePatientHomeFormButton_Click);
            // 
            // ScheduleDescriptionTextBox
            // 
            this.ScheduleDescriptionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScheduleDescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScheduleDescriptionTextBox.Font = new System.Drawing.Font("Arial", 10F);
            this.ScheduleDescriptionTextBox.ForeColor = System.Drawing.Color.Gray;
            this.ScheduleDescriptionTextBox.Location = new System.Drawing.Point(372, 195);
            this.ScheduleDescriptionTextBox.Name = "ScheduleDescriptionTextBox";
            this.ScheduleDescriptionTextBox.Size = new System.Drawing.Size(242, 23);
            this.ScheduleDescriptionTextBox.TabIndex = 7;
            this.ScheduleDescriptionTextBox.Text = "Description of Appointment";
            this.ScheduleDescriptionTextBox.Visible = false;
            this.ScheduleDescriptionTextBox.Click += new System.EventHandler(this.ScheduleDescriptionTextBox_Click);
            // 
            // DentistHygeinistComboBox
            // 
            this.DentistHygeinistComboBox.FormattingEnabled = true;
            this.DentistHygeinistComboBox.Location = new System.Drawing.Point(644, 196);
            this.DentistHygeinistComboBox.Name = "DentistHygeinistComboBox";
            this.DentistHygeinistComboBox.Size = new System.Drawing.Size(144, 21);
            this.DentistHygeinistComboBox.TabIndex = 8;
            this.DentistHygeinistComboBox.Text = "Select Dentist/Hygeinist";
            this.DentistHygeinistComboBox.Visible = false;
            // 
            // AppointmentTypeComboBox
            // 
            this.AppointmentTypeComboBox.FormattingEnabled = true;
            this.AppointmentTypeComboBox.Location = new System.Drawing.Point(550, 153);
            this.AppointmentTypeComboBox.Name = "AppointmentTypeComboBox";
            this.AppointmentTypeComboBox.Size = new System.Drawing.Size(144, 21);
            this.AppointmentTypeComboBox.TabIndex = 9;
            this.AppointmentTypeComboBox.Text = "Select Appointment Type";
            this.AppointmentTypeComboBox.Visible = false;
            // 
            // ErrorMessageLabel
            // 
            this.ErrorMessageLabel.AutoSize = true;
            this.ErrorMessageLabel.BackColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Black;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(369, 392);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(338, 16);
            this.ErrorMessageLabel.TabIndex = 3;
            this.ErrorMessageLabel.Text = "You tried to create an appointment but it didn\'t work";
            this.ErrorMessageLabel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Turquoise;
            this.label1.Location = new System.Drawing.Point(9, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Your Upcoming Appointments";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(704, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 35);
            this.panel2.TabIndex = 11;
            // 
            // PatientHomeLogoutLabel
            // 
            this.PatientHomeLogoutLabel.AutoSize = true;
            this.PatientHomeLogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientHomeLogoutLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientHomeLogoutLabel.ForeColor = System.Drawing.Color.Aqua;
            this.PatientHomeLogoutLabel.Location = new System.Drawing.Point(642, 20);
            this.PatientHomeLogoutLabel.Name = "PatientHomeLogoutLabel";
            this.PatientHomeLogoutLabel.Size = new System.Drawing.Size(56, 18);
            this.PatientHomeLogoutLabel.TabIndex = 12;
            this.PatientHomeLogoutLabel.Text = "Logout";
            this.PatientHomeLogoutLabel.Click += new System.EventHandler(this.PatientHomeLogoutLabel_Click);
            // 
            // AppointmentDetailsPanel
            // 
            this.AppointmentDetailsPanel.BackColor = System.Drawing.Color.DimGray;
            this.AppointmentDetailsPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.AppointmentDetailsPanel.Controls.Add(this.ConfirmCancelAppointmentPanel);
            this.AppointmentDetailsPanel.Controls.Add(this.CloseAppointmentDetailsButton);
            this.AppointmentDetailsPanel.Controls.Add(this.CancelAppointmentButton);
            this.AppointmentDetailsPanel.Controls.Add(this.AppointmentDetailsLabel);
            this.AppointmentDetailsPanel.Location = new System.Drawing.Point(326, 51);
            this.AppointmentDetailsPanel.Name = "AppointmentDetailsPanel";
            this.AppointmentDetailsPanel.Size = new System.Drawing.Size(462, 357);
            this.AppointmentDetailsPanel.TabIndex = 13;
            this.AppointmentDetailsPanel.Visible = false;
            // 
            // ConfirmCancelAppointmentPanel
            // 
            this.ConfirmCancelAppointmentPanel.BackColor = System.Drawing.Color.Aqua;
            this.ConfirmCancelAppointmentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmCancelAppointmentPanel.Controls.Add(this.ConfirmCancelAppointmentButton);
            this.ConfirmCancelAppointmentPanel.Controls.Add(this.DenyCancelAppointmentButton);
            this.ConfirmCancelAppointmentPanel.Controls.Add(this.CancelAppointmentConfirmationLabel);
            this.ConfirmCancelAppointmentPanel.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmCancelAppointmentPanel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.ConfirmCancelAppointmentPanel.Location = new System.Drawing.Point(237, 239);
            this.ConfirmCancelAppointmentPanel.Name = "ConfirmCancelAppointmentPanel";
            this.ConfirmCancelAppointmentPanel.Size = new System.Drawing.Size(200, 100);
            this.ConfirmCancelAppointmentPanel.TabIndex = 14;
            this.ConfirmCancelAppointmentPanel.Visible = false;
            // 
            // ConfirmCancelAppointmentButton
            // 
            this.ConfirmCancelAppointmentButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ConfirmCancelAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ConfirmCancelAppointmentButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmCancelAppointmentButton.ForeColor = System.Drawing.Color.Aqua;
            this.ConfirmCancelAppointmentButton.Location = new System.Drawing.Point(109, 65);
            this.ConfirmCancelAppointmentButton.Name = "ConfirmCancelAppointmentButton";
            this.ConfirmCancelAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.ConfirmCancelAppointmentButton.TabIndex = 2;
            this.ConfirmCancelAppointmentButton.Text = "Yes";
            this.ConfirmCancelAppointmentButton.UseVisualStyleBackColor = false;
            this.ConfirmCancelAppointmentButton.Click += new System.EventHandler(this.ConfirmCancelAppointmentButton_Click);
            // 
            // DenyCancelAppointmentButton
            // 
            this.DenyCancelAppointmentButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DenyCancelAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DenyCancelAppointmentButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DenyCancelAppointmentButton.ForeColor = System.Drawing.Color.Aqua;
            this.DenyCancelAppointmentButton.Location = new System.Drawing.Point(19, 65);
            this.DenyCancelAppointmentButton.Name = "DenyCancelAppointmentButton";
            this.DenyCancelAppointmentButton.Size = new System.Drawing.Size(75, 23);
            this.DenyCancelAppointmentButton.TabIndex = 1;
            this.DenyCancelAppointmentButton.Text = "No";
            this.DenyCancelAppointmentButton.UseVisualStyleBackColor = false;
            this.DenyCancelAppointmentButton.Click += new System.EventHandler(this.DenyCancelAppointmentButton_Click);
            // 
            // CancelAppointmentConfirmationLabel
            // 
            this.CancelAppointmentConfirmationLabel.AutoSize = true;
            this.CancelAppointmentConfirmationLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAppointmentConfirmationLabel.Location = new System.Drawing.Point(5, 9);
            this.CancelAppointmentConfirmationLabel.Name = "CancelAppointmentConfirmationLabel";
            this.CancelAppointmentConfirmationLabel.Size = new System.Drawing.Size(187, 30);
            this.CancelAppointmentConfirmationLabel.TabIndex = 0;
            this.CancelAppointmentConfirmationLabel.Text = "Are you sure you would\r\nlike to cancel this appointment?";
            this.CancelAppointmentConfirmationLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // CloseAppointmentDetailsButton
            // 
            this.CloseAppointmentDetailsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(84)))), ((int)(((byte)(84)))));
            this.CloseAppointmentDetailsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseAppointmentDetailsButton.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAppointmentDetailsButton.ForeColor = System.Drawing.Color.Aqua;
            this.CloseAppointmentDetailsButton.Location = new System.Drawing.Point(424, 3);
            this.CloseAppointmentDetailsButton.Name = "CloseAppointmentDetailsButton";
            this.CloseAppointmentDetailsButton.Size = new System.Drawing.Size(31, 31);
            this.CloseAppointmentDetailsButton.TabIndex = 2;
            this.CloseAppointmentDetailsButton.Text = " X";
            this.CloseAppointmentDetailsButton.UseVisualStyleBackColor = false;
            this.CloseAppointmentDetailsButton.Click += new System.EventHandler(this.CloseAppointmentDetailsButton_Click);
            // 
            // CancelAppointmentButton
            // 
            this.CancelAppointmentButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelAppointmentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelAppointmentButton.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelAppointmentButton.ForeColor = System.Drawing.Color.Aqua;
            this.CancelAppointmentButton.Location = new System.Drawing.Point(60, 262);
            this.CancelAppointmentButton.Name = "CancelAppointmentButton";
            this.CancelAppointmentButton.Size = new System.Drawing.Size(112, 45);
            this.CancelAppointmentButton.TabIndex = 1;
            this.CancelAppointmentButton.Text = "Cancel Appointment";
            this.CancelAppointmentButton.UseVisualStyleBackColor = false;
            this.CancelAppointmentButton.Click += new System.EventHandler(this.CancelAppointmentButton_Click);
            // 
            // AppointmentDetailsLabel
            // 
            this.AppointmentDetailsLabel.AutoSize = true;
            this.AppointmentDetailsLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppointmentDetailsLabel.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.AppointmentDetailsLabel.Location = new System.Drawing.Point(22, 20);
            this.AppointmentDetailsLabel.Name = "AppointmentDetailsLabel";
            this.AppointmentDetailsLabel.Size = new System.Drawing.Size(139, 15);
            this.AppointmentDetailsLabel.TabIndex = 0;
            this.AppointmentDetailsLabel.Text = "Appointment Details";
            // 
            // HelpPictureBox
            // 
            this.HelpPictureBox.Image = global::AzureDentalDev.Properties.Resources.info_512pxGREY_2_28x28;
            this.HelpPictureBox.Location = new System.Drawing.Point(750, 414);
            this.HelpPictureBox.Name = "HelpPictureBox";
            this.HelpPictureBox.Size = new System.Drawing.Size(33, 34);
            this.HelpPictureBox.TabIndex = 14;
            this.HelpPictureBox.TabStop = false;
            this.HelpPictureBox.Click += new System.EventHandler(this.HelpPictureBox_Click);
            // 
            // PatientHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.HelpPictureBox);
            this.Controls.Add(this.AppointmentDetailsPanel);
            this.Controls.Add(this.PatientHomeLogoutLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ErrorMessageLabel);
            this.Controls.Add(this.AppointmentTypeComboBox);
            this.Controls.Add(this.DentistHygeinistComboBox);
            this.Controls.Add(this.ScheduleDescriptionTextBox);
            this.Controls.Add(this.ClosePatientHomeFormButton);
            this.Controls.Add(this.PickTimeComboBox);
            this.Controls.Add(this.AppointmentConfirmationPanel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.ScheduleAppointmentButton);
            this.Controls.Add(this.AppointmentsList);
            this.Controls.Add(this.PatientHomeFormWelcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PatientHomeForm";
            this.AppointmentConfirmationPanel.ResumeLayout(false);
            this.AppointmentConfirmationPanel.PerformLayout();
            this.AppointmentDetailsPanel.ResumeLayout(false);
            this.AppointmentDetailsPanel.PerformLayout();
            this.ConfirmCancelAppointmentPanel.ResumeLayout(false);
            this.ConfirmCancelAppointmentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PatientHomeFormWelcome;
        private System.Windows.Forms.ListView AppointmentsList;
        private System.Windows.Forms.Button ScheduleAppointmentButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel AppointmentConfirmationPanel;
        private System.Windows.Forms.Label ConfirmationMessage;
        private System.Windows.Forms.Button AppointmentConfirmationButton;
        private System.Windows.Forms.Button DenyConfirmationButton;
        private System.Windows.Forms.ComboBox PickTimeComboBox;
        private System.Windows.Forms.Button ClosePatientHomeFormButton;
        private System.Windows.Forms.TextBox ScheduleDescriptionTextBox;
        private System.Windows.Forms.ComboBox DentistHygeinistComboBox;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ComboBox AppointmentTypeComboBox;
        private System.Windows.Forms.Label ErrorMessageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label PatientHomeLogoutLabel;
        private System.Windows.Forms.Panel AppointmentDetailsPanel;
        private System.Windows.Forms.Label AppointmentDetailsLabel;
        private System.Windows.Forms.Button CloseAppointmentDetailsButton;
        private System.Windows.Forms.Button CancelAppointmentButton;
        private System.Windows.Forms.Panel ConfirmCancelAppointmentPanel;
        private System.Windows.Forms.Label CancelAppointmentConfirmationLabel;
        private System.Windows.Forms.Button ConfirmCancelAppointmentButton;
        private System.Windows.Forms.Button DenyCancelAppointmentButton;
        private System.Windows.Forms.PictureBox HelpPictureBox;
    }
}