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
            this.SuspendLayout();
            // 
            // AdminHomeFormWelcomeLabel
            // 
            this.AdminHomeFormWelcomeLabel.AutoSize = true;
            this.AdminHomeFormWelcomeLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminHomeFormWelcomeLabel.ForeColor = System.Drawing.Color.Aqua;
            this.AdminHomeFormWelcomeLabel.Location = new System.Drawing.Point(130, 196);
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
            this.AdminHomeFormCloseLabel.ForeColor = System.Drawing.Color.Gray;
            this.AdminHomeFormCloseLabel.Location = new System.Drawing.Point(769, 9);
            this.AdminHomeFormCloseLabel.Name = "AdminHomeFormCloseLabel";
            this.AdminHomeFormCloseLabel.Size = new System.Drawing.Size(19, 18);
            this.AdminHomeFormCloseLabel.TabIndex = 1;
            this.AdminHomeFormCloseLabel.Text = "X";
            this.AdminHomeFormCloseLabel.Click += new System.EventHandler(this.AdminHomeFormCloseLabel_Click);
            // 
            // AdminHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AdminHomeFormCloseLabel);
            this.Controls.Add(this.AdminHomeFormWelcomeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminHomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminHomeFormWelcomeLabel;
        private System.Windows.Forms.Label AdminHomeFormCloseLabel;
    }
}