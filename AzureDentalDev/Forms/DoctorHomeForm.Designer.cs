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
            this.DoctorHomeFormAppointmentsLabel = new System.Windows.Forms.Label();
            this.DoctorHomeFormCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DoctorHomeFormWelcomeLabel
            // 
            this.DoctorHomeFormWelcomeLabel.AutoSize = true;
            this.DoctorHomeFormWelcomeLabel.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormWelcomeLabel.Location = new System.Drawing.Point(64, 44);
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
            this.DoctorAppointmentListView.ForeColor = System.Drawing.Color.Aqua;
            this.DoctorAppointmentListView.HideSelection = false;
            this.DoctorAppointmentListView.Location = new System.Drawing.Point(18, 140);
            this.DoctorAppointmentListView.Name = "DoctorAppointmentListView";
            this.DoctorAppointmentListView.Size = new System.Drawing.Size(415, 515);
            this.DoctorAppointmentListView.TabIndex = 1;
            this.DoctorAppointmentListView.UseCompatibleStateImageBehavior = false;
            // 
            // DoctorHomeFormAppointmentsLabel
            // 
            this.DoctorHomeFormAppointmentsLabel.AutoSize = true;
            this.DoctorHomeFormAppointmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoctorHomeFormAppointmentsLabel.Location = new System.Drawing.Point(18, 114);
            this.DoctorHomeFormAppointmentsLabel.Name = "DoctorHomeFormAppointmentsLabel";
            this.DoctorHomeFormAppointmentsLabel.Size = new System.Drawing.Size(188, 20);
            this.DoctorHomeFormAppointmentsLabel.TabIndex = 2;
            this.DoctorHomeFormAppointmentsLabel.Text = "Upcoming Appointments:";
            // 
            // DoctorHomeFormCloseButton
            // 
            this.DoctorHomeFormCloseButton.ForeColor = System.Drawing.Color.Red;
            this.DoctorHomeFormCloseButton.Location = new System.Drawing.Point(1140, 1);
            this.DoctorHomeFormCloseButton.Name = "DoctorHomeFormCloseButton";
            this.DoctorHomeFormCloseButton.Size = new System.Drawing.Size(40, 40);
            this.DoctorHomeFormCloseButton.TabIndex = 3;
            this.DoctorHomeFormCloseButton.Text = "X";
            this.DoctorHomeFormCloseButton.UseVisualStyleBackColor = true;
            this.DoctorHomeFormCloseButton.Click += new System.EventHandler(this.DoctorHomeFormCloseButton_Click);
            // 
            // DoctorHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1178, 635);
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
    }
}