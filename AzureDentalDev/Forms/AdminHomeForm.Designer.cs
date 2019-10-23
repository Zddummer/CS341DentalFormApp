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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHomeForm));
            this.AdminHomeFormWelcomeLabel = new System.Windows.Forms.Label();
            this.AdminHomeFormCloseLabel = new System.Windows.Forms.Label();
            this.AdminHomeFormMainPictureBox = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminHomeFormTabControl = new MaterialSkin.Controls.MaterialTabControl();
            this.AccountsTabPage = new System.Windows.Forms.TabPage();
            this.AdminHomeFormUpdateButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeFormMainPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdminHomeFormTabControl.SuspendLayout();
            this.AccountsTabPage.SuspendLayout();
            this.ScheduleTabPage.SuspendLayout();
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
            this.panel1.Controls.Add(this.AdminHomeFormMainPictureBox);
            this.panel1.Controls.Add(this.AdminHomeFormWelcomeLabel);
            this.panel1.Controls.Add(this.AdminHomeFormCloseLabel);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(918, 67);
            this.panel1.TabIndex = 3;
            // 
            // AdminHomeFormTabControl
            // 
            this.AdminHomeFormTabControl.Controls.Add(this.AccountsTabPage);
            this.AdminHomeFormTabControl.Controls.Add(this.ScheduleTabPage);
            this.AdminHomeFormTabControl.Depth = 0;
            this.AdminHomeFormTabControl.Location = new System.Drawing.Point(3, 104);
            this.AdminHomeFormTabControl.MouseState = MaterialSkin.MouseState.HOVER;
            this.AdminHomeFormTabControl.Name = "AdminHomeFormTabControl";
            this.AdminHomeFormTabControl.SelectedIndex = 0;
            this.AdminHomeFormTabControl.Size = new System.Drawing.Size(901, 454);
            this.AdminHomeFormTabControl.TabIndex = 4;
            // 
            // AccountsTabPage
            // 
            this.AccountsTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AccountsTabPage.Controls.Add(this.AdminHomeFormUpdateButton);
            this.AccountsTabPage.Controls.Add(this.AdminFormCreateButton);
            this.AccountsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AccountsTabPage.Name = "AccountsTabPage";
            this.AccountsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AccountsTabPage.Size = new System.Drawing.Size(893, 428);
            this.AccountsTabPage.TabIndex = 0;
            this.AccountsTabPage.Text = "Accounts";
            // 
            // AdminHomeFormUpdateButton
            // 
            this.AdminHomeFormUpdateButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.AdminHomeFormUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminHomeFormUpdateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeFormUpdateButton.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeFormUpdateButton.Location = new System.Drawing.Point(508, 120);
            this.AdminHomeFormUpdateButton.Name = "AdminHomeFormUpdateButton";
            this.AdminHomeFormUpdateButton.Size = new System.Drawing.Size(115, 130);
            this.AdminHomeFormUpdateButton.TabIndex = 1;
            this.AdminHomeFormUpdateButton.Text = "Update Account";
            this.AdminHomeFormUpdateButton.UseVisualStyleBackColor = false;
            this.AdminHomeFormUpdateButton.Click += new System.EventHandler(this.AdminHomeFormUpdateButton_Click);
            // 
            // AdminFormCreateButton
            // 
            this.AdminFormCreateButton.BackColor = System.Drawing.Color.Aqua;
            this.AdminFormCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminFormCreateButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminFormCreateButton.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AdminFormCreateButton.Location = new System.Drawing.Point(269, 120);
            this.AdminFormCreateButton.Name = "AdminFormCreateButton";
            this.AdminFormCreateButton.Size = new System.Drawing.Size(115, 130);
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
            this.ScheduleTabPage.Size = new System.Drawing.Size(893, 428);
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
            this.materialTabSelector1.Location = new System.Drawing.Point(3, 75);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(901, 23);
            this.materialTabSelector1.TabIndex = 5;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(916, 570);
            this.Controls.Add(this.materialTabSelector1);
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
            this.ScheduleTabPage.ResumeLayout(false);
            this.ScheduleTabPage.PerformLayout();
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
        private System.Windows.Forms.Button AdminHomeFormUpdateButton;
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
    }
}