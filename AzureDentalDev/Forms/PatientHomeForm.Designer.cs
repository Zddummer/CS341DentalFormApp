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
            this.AppointmentConfirmationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientHomeFormWelcome
            // 
            this.PatientHomeFormWelcome.AutoSize = true;
            this.PatientHomeFormWelcome.Font = new System.Drawing.Font("Arial", 20.25F);
            this.PatientHomeFormWelcome.ForeColor = System.Drawing.Color.Aqua;
            this.PatientHomeFormWelcome.Location = new System.Drawing.Point(13, 13);
            this.PatientHomeFormWelcome.Name = "PatientHomeFormWelcome";
            this.PatientHomeFormWelcome.Size = new System.Drawing.Size(130, 32);
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
            this.ScheduleAppointmentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScheduleAppointmentButton.Font = new System.Drawing.Font("Arial", 12F);
            this.ScheduleAppointmentButton.Location = new System.Drawing.Point(552, 47);
            this.ScheduleAppointmentButton.Name = "ScheduleAppointmentButton";
            this.ScheduleAppointmentButton.Size = new System.Drawing.Size(142, 78);
            this.ScheduleAppointmentButton.TabIndex = 2;
            this.ScheduleAppointmentButton.Text = "Schedule Appointment";
            this.ScheduleAppointmentButton.UseVisualStyleBackColor = true;
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
            this.dateTimePicker1.Value = new System.DateTime(2019, 10, 19, 0, 0, 0, 0);
            this.dateTimePicker1.Visible = false;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // AppointmentConfirmationPanel
            // 
            this.AppointmentConfirmationPanel.BackColor = System.Drawing.Color.Silver;
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
            this.DenyConfirmationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DenyConfirmationButton.Location = new System.Drawing.Point(17, 63);
            this.DenyConfirmationButton.Name = "DenyConfirmationButton";
            this.DenyConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.DenyConfirmationButton.TabIndex = 2;
            this.DenyConfirmationButton.Text = "Cancel";
            this.DenyConfirmationButton.UseVisualStyleBackColor = true;
            this.DenyConfirmationButton.Click += new System.EventHandler(this.DenyConfirmationButton_Click);
            // 
            // ConfirmationMessage
            // 
            this.ConfirmationMessage.AutoSize = true;
            this.ConfirmationMessage.Location = new System.Drawing.Point(53, 16);
            this.ConfirmationMessage.Name = "ConfirmationMessage";
            this.ConfirmationMessage.Size = new System.Drawing.Size(104, 13);
            this.ConfirmationMessage.TabIndex = 1;
            this.ConfirmationMessage.Text = "Confirm Appointment";
            // 
            // AppointmentConfirmationButton
            // 
            this.AppointmentConfirmationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AppointmentConfirmationButton.Location = new System.Drawing.Point(113, 63);
            this.AppointmentConfirmationButton.Name = "AppointmentConfirmationButton";
            this.AppointmentConfirmationButton.Size = new System.Drawing.Size(75, 23);
            this.AppointmentConfirmationButton.TabIndex = 0;
            this.AppointmentConfirmationButton.Text = "Okay";
            this.AppointmentConfirmationButton.UseVisualStyleBackColor = true;
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
            this.ClosePatientHomeFormButton.Font = new System.Drawing.Font("Arial", 12F);
            this.ClosePatientHomeFormButton.ForeColor = System.Drawing.Color.Black;
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
            this.ErrorMessageLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessageLabel.Location = new System.Drawing.Point(433, 392);
            this.ErrorMessageLabel.Name = "ErrorMessageLabel";
            this.ErrorMessageLabel.Size = new System.Drawing.Size(338, 16);
            this.ErrorMessageLabel.TabIndex = 3;
            this.ErrorMessageLabel.Text = "You tried to create an appointment but it didn\'t work";
            this.ErrorMessageLabel.Visible = false;
            // 
            // PatientHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
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
            this.Load += new System.EventHandler(this.CustomerHomeForm_Load);
            this.AppointmentConfirmationPanel.ResumeLayout(false);
            this.AppointmentConfirmationPanel.PerformLayout();
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
    }
}