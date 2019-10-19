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
            this.ScheduleTabPage = new System.Windows.Forms.TabPage();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.AdminFormCreateButton = new System.Windows.Forms.Button();
            this.AdminHomeFormUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeFormMainPictureBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.AdminHomeFormTabControl.SuspendLayout();
            this.AccountsTabPage.SuspendLayout();
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
            // ScheduleTabPage
            // 
            this.ScheduleTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ScheduleTabPage.Location = new System.Drawing.Point(4, 22);
            this.ScheduleTabPage.Name = "ScheduleTabPage";
            this.ScheduleTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ScheduleTabPage.Size = new System.Drawing.Size(893, 428);
            this.ScheduleTabPage.TabIndex = 1;
            this.ScheduleTabPage.Text = "Schedule";
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
    }
}