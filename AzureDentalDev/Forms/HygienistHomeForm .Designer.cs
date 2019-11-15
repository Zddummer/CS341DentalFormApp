namespace AzureDentalDev.Forms
{
    partial class HygienistHomeForm
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
            this.SuspendLayout();
            // 
            // DoctorHomeFormWelcomeLabel
            // 
            this.DoctorHomeFormWelcomeLabel.AutoSize = true;
            this.DoctorHomeFormWelcomeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormWelcomeLabel.Location = new System.Drawing.Point(43, 29);
            this.DoctorHomeFormWelcomeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoctorHomeFormWelcomeLabel.MinimumSize = new System.Drawing.Size(67, 26);
            this.DoctorHomeFormWelcomeLabel.Name = "DoctorHomeFormWelcomeLabel";
            this.DoctorHomeFormWelcomeLabel.Size = new System.Drawing.Size(260, 32);
            this.DoctorHomeFormWelcomeLabel.TabIndex = 0;
            this.DoctorHomeFormWelcomeLabel.Text = "Welcome Hygenist. ";
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
            this.DoctorAppointmentListView.Location = new System.Drawing.Point(12, 91);
            this.DoctorAppointmentListView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoctorAppointmentListView.Name = "DoctorAppointmentListView";
            this.DoctorAppointmentListView.Size = new System.Drawing.Size(432, 315);
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
            this.DoctorHomeFormAppointmentsLabel.Location = new System.Drawing.Point(12, 74);
            this.DoctorHomeFormAppointmentsLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DoctorHomeFormAppointmentsLabel.Name = "DoctorHomeFormAppointmentsLabel";
            this.DoctorHomeFormAppointmentsLabel.Size = new System.Drawing.Size(147, 13);
            this.DoctorHomeFormAppointmentsLabel.TabIndex = 2;
            this.DoctorHomeFormAppointmentsLabel.Text = "Upcoming Appointments:";
            // 
            // DoctorHomeFormCloseButton
            // 
            this.DoctorHomeFormCloseButton.ForeColor = System.Drawing.Color.Red;
            this.DoctorHomeFormCloseButton.Location = new System.Drawing.Point(760, 1);
            this.DoctorHomeFormCloseButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DoctorHomeFormCloseButton.Name = "DoctorHomeFormCloseButton";
            this.DoctorHomeFormCloseButton.Size = new System.Drawing.Size(27, 26);
            this.DoctorHomeFormCloseButton.TabIndex = 3;
            this.DoctorHomeFormCloseButton.Text = "X";
            this.DoctorHomeFormCloseButton.UseVisualStyleBackColor = true;
            this.DoctorHomeFormCloseButton.Click += new System.EventHandler(this.DoctorHomeFormCloseButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Aqua;
            this.panel2.Location = new System.Drawing.Point(753, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 25);
            this.panel2.TabIndex = 4;
            // 
            // DoctorHomeLogoutLabel
            // 
            this.DoctorHomeLogoutLabel.AutoSize = true;
            this.DoctorHomeLogoutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorHomeLogoutLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeLogoutLabel.Location = new System.Drawing.Point(695, 5);
            this.DoctorHomeLogoutLabel.Name = "DoctorHomeLogoutLabel";
            this.DoctorHomeLogoutLabel.Size = new System.Drawing.Size(52, 17);
            this.DoctorHomeLogoutLabel.TabIndex = 5;
            this.DoctorHomeLogoutLabel.Text = "Logout";
            this.DoctorHomeLogoutLabel.Click += new System.EventHandler(this.DoctorHomeLogoutLabel_Click);
            // 
            // HygienistHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(785, 413);
            this.Controls.Add(this.DoctorHomeLogoutLabel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.DoctorHomeFormCloseButton);
            this.Controls.Add(this.DoctorHomeFormAppointmentsLabel);
            this.Controls.Add(this.DoctorAppointmentListView);
            this.Controls.Add(this.DoctorHomeFormWelcomeLabel);
            this.ForeColor = System.Drawing.Color.Aqua;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HygienistHomeForm";
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
    }
}