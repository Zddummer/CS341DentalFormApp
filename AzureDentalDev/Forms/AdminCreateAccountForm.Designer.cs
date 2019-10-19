namespace AzureDentalDev.Forms
{
    partial class AdminCreateAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminCreateAccountForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.AdminCreateAccountFormLabel = new System.Windows.Forms.Label();
            this.AdminCreateAccountFormCloseLabel = new System.Windows.Forms.Label();
            this.AdminHomeFormMainPictureBox = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AdminCreateTypeCombobox = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdminCreateLastTextbox = new System.Windows.Forms.TextBox();
            this.AdminCreateFirstTextbox = new System.Windows.Forms.TextBox();
            this.AdminCreatePassTextBox = new System.Windows.Forms.TextBox();
            this.AdminCreatePassLabel = new System.Windows.Forms.Label();
            this.AdminCreateFirstLabel = new System.Windows.Forms.Label();
            this.AdminCreateLastLabel = new System.Windows.Forms.Label();
            this.AdminCreateTypeLabel = new System.Windows.Forms.Label();
            this.AdminCreateUserPanel = new System.Windows.Forms.Panel();
            this.AdminCreateUserTextbox = new System.Windows.Forms.TextBox();
            this.AdminCreateUserLabel = new System.Windows.Forms.Label();
            this.AdminCreateButton = new System.Windows.Forms.Button();
            this.AdminCreateValidLabel = new System.Windows.Forms.Label();
            this.AdminCreateErrorLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeFormMainPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.AdminCreateAccountFormLabel);
            this.panel1.Controls.Add(this.AdminCreateAccountFormCloseLabel);
            this.panel1.Controls.Add(this.AdminHomeFormMainPictureBox);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(694, 67);
            this.panel1.TabIndex = 0;
            // 
            // AdminCreateAccountFormLabel
            // 
            this.AdminCreateAccountFormLabel.AutoSize = true;
            this.AdminCreateAccountFormLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateAccountFormLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateAccountFormLabel.Location = new System.Drawing.Point(73, 18);
            this.AdminCreateAccountFormLabel.Name = "AdminCreateAccountFormLabel";
            this.AdminCreateAccountFormLabel.Size = new System.Drawing.Size(297, 32);
            this.AdminCreateAccountFormLabel.TabIndex = 4;
            this.AdminCreateAccountFormLabel.Text = "Create a new account";
            // 
            // AdminCreateAccountFormCloseLabel
            // 
            this.AdminCreateAccountFormCloseLabel.AutoSize = true;
            this.AdminCreateAccountFormCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdminCreateAccountFormCloseLabel.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateAccountFormCloseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateAccountFormCloseLabel.Location = new System.Drawing.Point(659, 9);
            this.AdminCreateAccountFormCloseLabel.Name = "AdminCreateAccountFormCloseLabel";
            this.AdminCreateAccountFormCloseLabel.Size = new System.Drawing.Size(23, 22);
            this.AdminCreateAccountFormCloseLabel.TabIndex = 1;
            this.AdminCreateAccountFormCloseLabel.Text = "X";
            this.AdminCreateAccountFormCloseLabel.Click += new System.EventHandler(this.AdminCreateAccountFormCloseLabel_Click);
            // 
            // AdminHomeFormMainPictureBox
            // 
            this.AdminHomeFormMainPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AdminHomeFormMainPictureBox.BackgroundImage")));
            this.AdminHomeFormMainPictureBox.Location = new System.Drawing.Point(3, 3);
            this.AdminHomeFormMainPictureBox.Name = "AdminHomeFormMainPictureBox";
            this.AdminHomeFormMainPictureBox.Size = new System.Drawing.Size(64, 62);
            this.AdminHomeFormMainPictureBox.TabIndex = 3;
            this.AdminHomeFormMainPictureBox.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.AdminCreateErrorLabel);
            this.panel2.Controls.Add(this.AdminCreateValidLabel);
            this.panel2.Controls.Add(this.AdminCreateButton);
            this.panel2.Controls.Add(this.AdminCreateTypeCombobox);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.AdminCreateLastTextbox);
            this.panel2.Controls.Add(this.AdminCreateFirstTextbox);
            this.panel2.Controls.Add(this.AdminCreatePassTextBox);
            this.panel2.Controls.Add(this.AdminCreatePassLabel);
            this.panel2.Controls.Add(this.AdminCreateFirstLabel);
            this.panel2.Controls.Add(this.AdminCreateLastLabel);
            this.panel2.Controls.Add(this.AdminCreateTypeLabel);
            this.panel2.Controls.Add(this.AdminCreateUserPanel);
            this.panel2.Controls.Add(this.AdminCreateUserTextbox);
            this.panel2.Controls.Add(this.AdminCreateUserLabel);
            this.panel2.Location = new System.Drawing.Point(3, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(687, 376);
            this.panel2.TabIndex = 1;
            // 
            // AdminCreateTypeCombobox
            // 
            this.AdminCreateTypeCombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateTypeCombobox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminCreateTypeCombobox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateTypeCombobox.ForeColor = System.Drawing.Color.Gray;
            this.AdminCreateTypeCombobox.FormattingEnabled = true;
            this.AdminCreateTypeCombobox.Location = new System.Drawing.Point(51, 247);
            this.AdminCreateTypeCombobox.Name = "AdminCreateTypeCombobox";
            this.AdminCreateTypeCombobox.Size = new System.Drawing.Size(121, 30);
            this.AdminCreateTypeCombobox.TabIndex = 13;
            this.AdminCreateTypeCombobox.Text = "C";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Location = new System.Drawing.Point(365, 195);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 1);
            this.panel5.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Location = new System.Drawing.Point(51, 195);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 1);
            this.panel4.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Location = new System.Drawing.Point(365, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 10;
            // 
            // AdminCreateLastTextbox
            // 
            this.AdminCreateLastTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateLastTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminCreateLastTextbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateLastTextbox.ForeColor = System.Drawing.Color.Gray;
            this.AdminCreateLastTextbox.Location = new System.Drawing.Point(365, 167);
            this.AdminCreateLastTextbox.Name = "AdminCreateLastTextbox";
            this.AdminCreateLastTextbox.Size = new System.Drawing.Size(200, 22);
            this.AdminCreateLastTextbox.TabIndex = 9;
            this.AdminCreateLastTextbox.Text = "Enter the last name";
            this.AdminCreateLastTextbox.Enter += new System.EventHandler(this.AdminCreateLastTextbox_Enter);
            this.AdminCreateLastTextbox.Leave += new System.EventHandler(this.AdminCreateLastTextbox_Leave);
            // 
            // AdminCreateFirstTextbox
            // 
            this.AdminCreateFirstTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateFirstTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminCreateFirstTextbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateFirstTextbox.ForeColor = System.Drawing.Color.Gray;
            this.AdminCreateFirstTextbox.Location = new System.Drawing.Point(365, 72);
            this.AdminCreateFirstTextbox.Name = "AdminCreateFirstTextbox";
            this.AdminCreateFirstTextbox.Size = new System.Drawing.Size(200, 22);
            this.AdminCreateFirstTextbox.TabIndex = 8;
            this.AdminCreateFirstTextbox.Text = "Enter the first name";
            this.AdminCreateFirstTextbox.Enter += new System.EventHandler(this.AdminCreateFirstTextbox_Enter);
            this.AdminCreateFirstTextbox.Leave += new System.EventHandler(this.AdminCreateFirstTextbox_Leave);
            // 
            // AdminCreatePassTextBox
            // 
            this.AdminCreatePassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreatePassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminCreatePassTextBox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreatePassTextBox.ForeColor = System.Drawing.Color.Gray;
            this.AdminCreatePassTextBox.Location = new System.Drawing.Point(51, 168);
            this.AdminCreatePassTextBox.Name = "AdminCreatePassTextBox";
            this.AdminCreatePassTextBox.Size = new System.Drawing.Size(200, 22);
            this.AdminCreatePassTextBox.TabIndex = 7;
            this.AdminCreatePassTextBox.Text = "Create a password";
            this.AdminCreatePassTextBox.Enter += new System.EventHandler(this.AdminCreatePassTextBox_Enter);
            this.AdminCreatePassTextBox.Leave += new System.EventHandler(this.AdminCreatePassTextBox_Leave);
            // 
            // AdminCreatePassLabel
            // 
            this.AdminCreatePassLabel.AutoSize = true;
            this.AdminCreatePassLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreatePassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreatePassLabel.Location = new System.Drawing.Point(48, 149);
            this.AdminCreatePassLabel.Name = "AdminCreatePassLabel";
            this.AdminCreatePassLabel.Size = new System.Drawing.Size(63, 15);
            this.AdminCreatePassLabel.TabIndex = 6;
            this.AdminCreatePassLabel.Text = "Password";
            // 
            // AdminCreateFirstLabel
            // 
            this.AdminCreateFirstLabel.AutoSize = true;
            this.AdminCreateFirstLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateFirstLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreateFirstLabel.Location = new System.Drawing.Point(362, 54);
            this.AdminCreateFirstLabel.Name = "AdminCreateFirstLabel";
            this.AdminCreateFirstLabel.Size = new System.Drawing.Size(68, 15);
            this.AdminCreateFirstLabel.TabIndex = 5;
            this.AdminCreateFirstLabel.Text = "First Name";
            // 
            // AdminCreateLastLabel
            // 
            this.AdminCreateLastLabel.AutoSize = true;
            this.AdminCreateLastLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateLastLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreateLastLabel.Location = new System.Drawing.Point(362, 149);
            this.AdminCreateLastLabel.Name = "AdminCreateLastLabel";
            this.AdminCreateLastLabel.Size = new System.Drawing.Size(68, 15);
            this.AdminCreateLastLabel.TabIndex = 4;
            this.AdminCreateLastLabel.Text = "Last Name";
            // 
            // AdminCreateTypeLabel
            // 
            this.AdminCreateTypeLabel.AutoSize = true;
            this.AdminCreateTypeLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateTypeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreateTypeLabel.Location = new System.Drawing.Point(48, 229);
            this.AdminCreateTypeLabel.Name = "AdminCreateTypeLabel";
            this.AdminCreateTypeLabel.Size = new System.Drawing.Size(62, 15);
            this.AdminCreateTypeLabel.TabIndex = 3;
            this.AdminCreateTypeLabel.Text = "User Type";
            // 
            // AdminCreateUserPanel
            // 
            this.AdminCreateUserPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreateUserPanel.Location = new System.Drawing.Point(51, 100);
            this.AdminCreateUserPanel.Name = "AdminCreateUserPanel";
            this.AdminCreateUserPanel.Size = new System.Drawing.Size(200, 1);
            this.AdminCreateUserPanel.TabIndex = 2;
            // 
            // AdminCreateUserTextbox
            // 
            this.AdminCreateUserTextbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateUserTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminCreateUserTextbox.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateUserTextbox.ForeColor = System.Drawing.Color.Gray;
            this.AdminCreateUserTextbox.Location = new System.Drawing.Point(51, 72);
            this.AdminCreateUserTextbox.Name = "AdminCreateUserTextbox";
            this.AdminCreateUserTextbox.Size = new System.Drawing.Size(197, 22);
            this.AdminCreateUserTextbox.TabIndex = 1;
            this.AdminCreateUserTextbox.Text = "Create a username";
            this.AdminCreateUserTextbox.Enter += new System.EventHandler(this.AdminCreateUserTextbox_Enter);
            this.AdminCreateUserTextbox.Leave += new System.EventHandler(this.AdminCreateUserTextbox_Leave);
            // 
            // AdminCreateUserLabel
            // 
            this.AdminCreateUserLabel.AutoSize = true;
            this.AdminCreateUserLabel.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreateUserLabel.Location = new System.Drawing.Point(48, 54);
            this.AdminCreateUserLabel.Name = "AdminCreateUserLabel";
            this.AdminCreateUserLabel.Size = new System.Drawing.Size(66, 15);
            this.AdminCreateUserLabel.TabIndex = 0;
            this.AdminCreateUserLabel.Text = "Username";
            // 
            // AdminCreateButton
            // 
            this.AdminCreateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.AdminCreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminCreateButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AdminCreateButton.Location = new System.Drawing.Point(365, 241);
            this.AdminCreateButton.Name = "AdminCreateButton";
            this.AdminCreateButton.Size = new System.Drawing.Size(200, 36);
            this.AdminCreateButton.TabIndex = 14;
            this.AdminCreateButton.Text = "Create Account";
            this.AdminCreateButton.UseVisualStyleBackColor = false;
            this.AdminCreateButton.Click += new System.EventHandler(this.AdminCreateButton_Click);
            // 
            // AdminCreateValidLabel
            // 
            this.AdminCreateValidLabel.AutoSize = true;
            this.AdminCreateValidLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateValidLabel.ForeColor = System.Drawing.Color.Lime;
            this.AdminCreateValidLabel.Location = new System.Drawing.Point(406, 222);
            this.AdminCreateValidLabel.Name = "AdminCreateValidLabel";
            this.AdminCreateValidLabel.Size = new System.Drawing.Size(108, 16);
            this.AdminCreateValidLabel.TabIndex = 15;
            this.AdminCreateValidLabel.Text = "Account Created!";
            this.AdminCreateValidLabel.Visible = false;
            // 
            // AdminCreateErrorLabel
            // 
            this.AdminCreateErrorLabel.AutoSize = true;
            this.AdminCreateErrorLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminCreateErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.AdminCreateErrorLabel.Location = new System.Drawing.Point(378, 206);
            this.AdminCreateErrorLabel.Name = "AdminCreateErrorLabel";
            this.AdminCreateErrorLabel.Size = new System.Drawing.Size(171, 16);
            this.AdminCreateErrorLabel.TabIndex = 16;
            this.AdminCreateErrorLabel.Text = "That account already exists!";
            this.AdminCreateErrorLabel.Visible = false;
            // 
            // AdminCreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminCreateAccountForm";
            this.Text = "AdminCreateAccountForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminHomeFormMainPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox AdminHomeFormMainPictureBox;
        private System.Windows.Forms.Label AdminCreateAccountFormLabel;
        private System.Windows.Forms.Label AdminCreateAccountFormCloseLabel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel AdminCreateUserPanel;
        private System.Windows.Forms.TextBox AdminCreateUserTextbox;
        private System.Windows.Forms.Label AdminCreateUserLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox AdminCreateLastTextbox;
        private System.Windows.Forms.TextBox AdminCreateFirstTextbox;
        private System.Windows.Forms.TextBox AdminCreatePassTextBox;
        private System.Windows.Forms.Label AdminCreatePassLabel;
        private System.Windows.Forms.Label AdminCreateFirstLabel;
        private System.Windows.Forms.Label AdminCreateLastLabel;
        private System.Windows.Forms.Label AdminCreateTypeLabel;
        private System.Windows.Forms.ComboBox AdminCreateTypeCombobox;
        private System.Windows.Forms.Button AdminCreateButton;
        private System.Windows.Forms.Label AdminCreateErrorLabel;
        private System.Windows.Forms.Label AdminCreateValidLabel;
    }
}