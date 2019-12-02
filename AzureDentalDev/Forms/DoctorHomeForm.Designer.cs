namespace AzureDentalDev.Forms
{
    partial class DoctorHomeForm
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
            this.DoctorHomeFormWelcomeLabel = new System.Windows.Forms.Label();
            this.DoctorAppointmentListView = new System.Windows.Forms.ListView();
            this.appointmentNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.time = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.patient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DoctorHomeFormAppointmentsLabel = new System.Windows.Forms.Label();
            this.DoctorHomeFormCloseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DoctorHomeLogoutLabel = new System.Windows.Forms.Label();
            this.DoctorHomeFormTimeOff = new System.Windows.Forms.Label();
            this.DoctorHomeFormRequestOffButton = new System.Windows.Forms.Button();
            this.DoctorTimeOffCalendar = new System.Windows.Forms.MonthCalendar();
            this.SuspendLayout();
            // 
            // DoctorHomeFormWelcomeLabel
            // 
            this.DoctorHomeFormWelcomeLabel.AutoSize = true;
            this.DoctorHomeFormWelcomeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormWelcomeLabel.Location = new System.Drawing.Point(64, 45);
            this.DoctorHomeFormWelcomeLabel.MinimumSize = new System.Drawing.Size(100, 40);
            this.DoctorHomeFormWelcomeLabel.Name = "DoctorHomeFormWelcomeLabel";
            this.DoctorHomeFormWelcomeLabel.Size = new System.Drawing.Size(260, 45);
            this.DoctorHomeFormWelcomeLabel.TabIndex = 0;
            this.DoctorHomeFormWelcomeLabel.Text = "Welcome Dr. ";
            this.DoctorHomeFormWelcomeLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DoctorAppointmentListView
            // 
            this.DoctorAppointmentListView.BackColor = System.Drawing.Color.DimGray;
            this.DoctorAppointmentListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.appointmentNum,
            this.date,
            this.time,
            this.patient,
            this.description});
            this.DoctorAppointmentListView.ForeColor = System.Drawing.Color.Aqua;
            this.DoctorAppointmentListView.HideSelection = false;
            this.DoctorAppointmentListView.Location = new System.Drawing.Point(18, 140);
            this.DoctorAppointmentListView.Name = "DoctorAppointmentListView";
            this.DoctorAppointmentListView.Size = new System.Drawing.Size(646, 482);
            this.DoctorAppointmentListView.TabIndex = 1;
            this.DoctorAppointmentListView.TileSize = new System.Drawing.Size(150, 80);
            this.DoctorAppointmentListView.UseCompatibleStateImageBehavior = false;
            this.DoctorAppointmentListView.View = System.Windows.Forms.View.Tile;
            this.DoctorAppointmentListView.ItemActivate += new System.EventHandler(this.DoctorAppointmentListView_ItemActivate);
            // 
            // DoctorHomeFormAppointmentsLabel
            // 
            this.DoctorHomeFormAppointmentsLabel.AutoSize = true;
            this.DoctorHomeFormAppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormAppointmentsLabel.Location = new System.Drawing.Point(18, 114);
            this.DoctorHomeFormAppointmentsLabel.Name = "DoctorHomeFormAppointmentsLabel";
            this.DoctorHomeFormAppointmentsLabel.Size = new System.Drawing.Size(210, 20);
            this.DoctorHomeFormAppointmentsLabel.TabIndex = 2;
            this.DoctorHomeFormAppointmentsLabel.Text = "Upcoming Appointments:";
            // 
            // DoctorHomeFormCloseButton
            // 
            this.DoctorHomeFormCloseButton.ForeColor = System.Drawing.Color.Red;
            this.DoctorHomeFormCloseButton.Location = new System.Drawing.Point(1140, 2);
            this.DoctorHomeFormCloseButton.Name = "DoctorHomeFormCloseButton";
            this.DoctorHomeFormCloseButton.Size = new System.Drawing.Size(40, 40);
            this.DoctorHomeFormCloseButton.TabIndex = 3;
            this.DoctorHomeFormCloseButton.Text = "X";
            this.DoctorHomeFormCloseButton.UseVisualStyleBackColor = true;
            this.DoctorHomeFormCloseButton.Click += new System.EventHandler(this.DoctorHomeFormCloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(1130, 2);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(4, 38);
            this.panel2.TabIndex = 4;
            // 
            // DoctorHomeLogoutLabel
            // 
            this.DoctorHomeLogoutLabel.AutoSize = true;
            this.DoctorHomeLogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorHomeLogoutLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeLogoutLabel.Location = new System.Drawing.Point(1042, 8);
            this.DoctorHomeLogoutLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DoctorHomeLogoutLabel.Name = "DoctorHomeLogoutLabel";
            this.DoctorHomeLogoutLabel.Size = new System.Drawing.Size(81, 26);
            this.DoctorHomeLogoutLabel.TabIndex = 5;
            this.DoctorHomeLogoutLabel.Text = "Logout";
            this.DoctorHomeLogoutLabel.Click += new System.EventHandler(this.DoctorHomeLogoutLabel_Click);
            // 
            // DoctorHomeFormTimeOff
            // 
            this.DoctorHomeFormTimeOff.AutoSize = true;
            this.DoctorHomeFormTimeOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormTimeOff.Location = new System.Drawing.Point(871, 114);
            this.DoctorHomeFormTimeOff.Name = "DoctorHomeFormTimeOff";
            this.DoctorHomeFormTimeOff.Size = new System.Drawing.Size(148, 20);
            this.DoctorHomeFormTimeOff.TabIndex = 7;
            this.DoctorHomeFormTimeOff.Text = "Request time off:";
            // 
            // DoctorHomeFormRequestOffButton
            // 
            this.DoctorHomeFormRequestOffButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DoctorHomeFormRequestOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorHomeFormRequestOffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormRequestOffButton.Location = new System.Drawing.Point(875, 408);
            this.DoctorHomeFormRequestOffButton.Name = "DoctorHomeFormRequestOffButton";
            this.DoctorHomeFormRequestOffButton.Size = new System.Drawing.Size(144, 66);
            this.DoctorHomeFormRequestOffButton.TabIndex = 8;
            this.DoctorHomeFormRequestOffButton.Text = "Confirm time off";
            this.DoctorHomeFormRequestOffButton.UseVisualStyleBackColor = false;
            // 
            // DoctorTimeOffCalendar
            // 
            this.DoctorTimeOffCalendar.Location = new System.Drawing.Point(786, 143);
            this.DoctorTimeOffCalendar.Name = "DoctorTimeOffCalendar";
            this.DoctorTimeOffCalendar.TabIndex = 9;
            // 
            // DoctorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1178, 635);
            this.Controls.Add(this.DoctorTimeOffCalendar);
            this.Controls.Add(this.DoctorHomeFormRequestOffButton);
            this.Controls.Add(this.DoctorHomeFormTimeOff);
            this.Controls.Add(this.DoctorHomeLogoutLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DoctorHomeFormCloseButton);
            this.Controls.Add(this.DoctorHomeFormAppointmentsLabel);
            this.Controls.Add(this.DoctorAppointmentListView);
            this.Controls.Add(this.DoctorHomeFormWelcomeLabel);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DoctorHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoctorHomeForm";
            this.Load += new System.EventHandler(this.DoctorHomeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DoctorHomeFormWelcomeLabel;
        private System.Windows.Forms.ListView DoctorAppointmentListView;
        private System.Windows.Forms.Label DoctorHomeFormAppointmentsLabel;
        private System.Windows.Forms.Button DoctorHomeFormCloseButton;
        private System.Windows.Forms.ColumnHeader appointmentNum;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader time;
        private System.Windows.Forms.ColumnHeader patient;
        private System.Windows.Forms.ColumnHeader description;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label DoctorHomeLogoutLabel;
        private System.Windows.Forms.Label DoctorHomeFormTimeOff;
        private System.Windows.Forms.Button DoctorHomeFormRequestOffButton;
        private System.Windows.Forms.MonthCalendar DoctorTimeOffCalendar;
    }
}