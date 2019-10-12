namespace AzureDentalDev.Forms
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.SignUpFormMainPictureBox = new System.Windows.Forms.PictureBox();
            this.SignUpFormUserTextBox = new System.Windows.Forms.TextBox();
            this.SignUpFormUserPanel = new System.Windows.Forms.Panel();
            this.SignUpFormPassTextBox = new System.Windows.Forms.TextBox();
            this.SignUpFormPassPanel = new System.Windows.Forms.Panel();
            this.SignUpFormRegisterButton = new System.Windows.Forms.Button();
            this.SignUpFormErrorLabel = new System.Windows.Forms.Label();
            this.SignUpFormBackLabel = new System.Windows.Forms.Label();
            this.SignUpFormPassLabel = new System.Windows.Forms.Label();
            this.SignUpFormUserLabel = new System.Windows.Forms.Label();
            this.SignUpFormLastLabel = new System.Windows.Forms.Label();
            this.SignUpFormLastTextBox = new System.Windows.Forms.TextBox();
            this.SignUpFormLastPanel = new System.Windows.Forms.Panel();
            this.SignUpFormFirstLabel = new System.Windows.Forms.Label();
            this.SignUpFormFirstTextBox = new System.Windows.Forms.TextBox();
            this.SignUpFormFirstPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SignUpFormMainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpFormMainPictureBox
            // 
            this.SignUpFormMainPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpFormMainPictureBox.BackgroundImage")));
            this.SignUpFormMainPictureBox.Location = new System.Drawing.Point(169, 75);
            this.SignUpFormMainPictureBox.Name = "SignUpFormMainPictureBox";
            this.SignUpFormMainPictureBox.Size = new System.Drawing.Size(64, 62);
            this.SignUpFormMainPictureBox.TabIndex = 1;
            this.SignUpFormMainPictureBox.TabStop = false;
            // 
            // SignUpFormUserTextBox
            // 
            this.SignUpFormUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpFormUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignUpFormUserTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormUserTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SignUpFormUserTextBox.Location = new System.Drawing.Point(76, 297);
            this.SignUpFormUserTextBox.Name = "SignUpFormUserTextBox";
            this.SignUpFormUserTextBox.Size = new System.Drawing.Size(250, 19);
            this.SignUpFormUserTextBox.TabIndex = 20;
            this.SignUpFormUserTextBox.Text = "Create a username";
            this.SignUpFormUserTextBox.Click += new System.EventHandler(this.SignUpFormUserTextBox_Click);
            this.SignUpFormUserTextBox.Enter += new System.EventHandler(this.SignUpFormUserTextBox_Enter);
            this.SignUpFormUserTextBox.Leave += new System.EventHandler(this.SignUpFormUserTextBox_Leave);
            // 
            // SignUpFormUserPanel
            // 
            this.SignUpFormUserPanel.BackColor = System.Drawing.Color.Gray;
            this.SignUpFormUserPanel.Location = new System.Drawing.Point(76, 323);
            this.SignUpFormUserPanel.Name = "SignUpFormUserPanel";
            this.SignUpFormUserPanel.Size = new System.Drawing.Size(250, 1);
            this.SignUpFormUserPanel.TabIndex = 8;
            // 
            // SignUpFormPassTextBox
            // 
            this.SignUpFormPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpFormPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignUpFormPassTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormPassTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SignUpFormPassTextBox.Location = new System.Drawing.Point(76, 369);
            this.SignUpFormPassTextBox.Name = "SignUpFormPassTextBox";
            this.SignUpFormPassTextBox.Size = new System.Drawing.Size(250, 19);
            this.SignUpFormPassTextBox.TabIndex = 23;
            this.SignUpFormPassTextBox.Text = "Create a password";
            this.SignUpFormPassTextBox.Click += new System.EventHandler(this.SignUpFormPassTextBox_Click);
            this.SignUpFormPassTextBox.Enter += new System.EventHandler(this.SignUpFormPassTextBox_Enter);
            this.SignUpFormPassTextBox.Leave += new System.EventHandler(this.SignUpFormPassTextBox_Leave);
            // 
            // SignUpFormPassPanel
            // 
            this.SignUpFormPassPanel.BackColor = System.Drawing.Color.Gray;
            this.SignUpFormPassPanel.Location = new System.Drawing.Point(76, 391);
            this.SignUpFormPassPanel.Name = "SignUpFormPassPanel";
            this.SignUpFormPassPanel.Size = new System.Drawing.Size(250, 1);
            this.SignUpFormPassPanel.TabIndex = 11;
            // 
            // SignUpFormRegisterButton
            // 
            this.SignUpFormRegisterButton.BackColor = System.Drawing.Color.Aqua;
            this.SignUpFormRegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignUpFormRegisterButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormRegisterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpFormRegisterButton.Location = new System.Drawing.Point(76, 439);
            this.SignUpFormRegisterButton.Name = "SignUpFormRegisterButton";
            this.SignUpFormRegisterButton.Size = new System.Drawing.Size(250, 35);
            this.SignUpFormRegisterButton.TabIndex = 10;
            this.SignUpFormRegisterButton.Text = "Register";
            this.SignUpFormRegisterButton.UseVisualStyleBackColor = false;
            this.SignUpFormRegisterButton.Click += new System.EventHandler(this.SignUpFormRegisterButton_Click);
            // 
            // SignUpFormErrorLabel
            // 
            this.SignUpFormErrorLabel.AutoSize = true;
            this.SignUpFormErrorLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.SignUpFormErrorLabel.Location = new System.Drawing.Point(112, 404);
            this.SignUpFormErrorLabel.Name = "SignUpFormErrorLabel";
            this.SignUpFormErrorLabel.Size = new System.Drawing.Size(193, 16);
            this.SignUpFormErrorLabel.TabIndex = 15;
            this.SignUpFormErrorLabel.Text = "That username is already taken!";
            this.SignUpFormErrorLabel.Visible = false;
            // 
            // SignUpFormBackLabel
            // 
            this.SignUpFormBackLabel.AutoSize = true;
            this.SignUpFormBackLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpFormBackLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormBackLabel.ForeColor = System.Drawing.Color.Gray;
            this.SignUpFormBackLabel.Location = new System.Drawing.Point(12, 9);
            this.SignUpFormBackLabel.Name = "SignUpFormBackLabel";
            this.SignUpFormBackLabel.Size = new System.Drawing.Size(21, 22);
            this.SignUpFormBackLabel.TabIndex = 16;
            this.SignUpFormBackLabel.Text = "<";
            this.SignUpFormBackLabel.Click += new System.EventHandler(this.SignUpFormBackLabel_Click);
            this.SignUpFormBackLabel.MouseLeave += new System.EventHandler(this.SignUpFormBackLabel_MouseLeave);
            this.SignUpFormBackLabel.MouseHover += new System.EventHandler(this.SignUpFormBackLabel_MouseHover);
            // 
            // SignUpFormPassLabel
            // 
            this.SignUpFormPassLabel.AutoSize = true;
            this.SignUpFormPassLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormPassLabel.ForeColor = System.Drawing.Color.Aqua;
            this.SignUpFormPassLabel.Location = new System.Drawing.Point(73, 348);
            this.SignUpFormPassLabel.Name = "SignUpFormPassLabel";
            this.SignUpFormPassLabel.Size = new System.Drawing.Size(78, 18);
            this.SignUpFormPassLabel.TabIndex = 17;
            this.SignUpFormPassLabel.Text = "Password";
            // 
            // SignUpFormUserLabel
            // 
            this.SignUpFormUserLabel.AutoSize = true;
            this.SignUpFormUserLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormUserLabel.ForeColor = System.Drawing.Color.Aqua;
            this.SignUpFormUserLabel.Location = new System.Drawing.Point(72, 274);
            this.SignUpFormUserLabel.Name = "SignUpFormUserLabel";
            this.SignUpFormUserLabel.Size = new System.Drawing.Size(80, 18);
            this.SignUpFormUserLabel.TabIndex = 18;
            this.SignUpFormUserLabel.Text = "Username";
            // 
            // SignUpFormLastLabel
            // 
            this.SignUpFormLastLabel.AutoSize = true;
            this.SignUpFormLastLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormLastLabel.ForeColor = System.Drawing.Color.Aqua;
            this.SignUpFormLastLabel.Location = new System.Drawing.Point(71, 211);
            this.SignUpFormLastLabel.Name = "SignUpFormLastLabel";
            this.SignUpFormLastLabel.Size = new System.Drawing.Size(81, 18);
            this.SignUpFormLastLabel.TabIndex = 21;
            this.SignUpFormLastLabel.Text = "Last name";
            // 
            // SignUpFormLastTextBox
            // 
            this.SignUpFormLastTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpFormLastTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignUpFormLastTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormLastTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SignUpFormLastTextBox.Location = new System.Drawing.Point(75, 234);
            this.SignUpFormLastTextBox.Name = "SignUpFormLastTextBox";
            this.SignUpFormLastTextBox.Size = new System.Drawing.Size(250, 19);
            this.SignUpFormLastTextBox.TabIndex = 13;
            this.SignUpFormLastTextBox.Text = "Enter your last name";
            this.SignUpFormLastTextBox.Enter += new System.EventHandler(this.SignUpFormLastTextBox_Enter);
            this.SignUpFormLastTextBox.Leave += new System.EventHandler(this.SignUpFormLastTextBox_Leave);
            // 
            // SignUpFormLastPanel
            // 
            this.SignUpFormLastPanel.BackColor = System.Drawing.Color.Gray;
            this.SignUpFormLastPanel.Location = new System.Drawing.Point(75, 260);
            this.SignUpFormLastPanel.Name = "SignUpFormLastPanel";
            this.SignUpFormLastPanel.Size = new System.Drawing.Size(250, 1);
            this.SignUpFormLastPanel.TabIndex = 19;
            // 
            // SignUpFormFirstLabel
            // 
            this.SignUpFormFirstLabel.AutoSize = true;
            this.SignUpFormFirstLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormFirstLabel.ForeColor = System.Drawing.Color.Aqua;
            this.SignUpFormFirstLabel.Location = new System.Drawing.Point(72, 148);
            this.SignUpFormFirstLabel.Name = "SignUpFormFirstLabel";
            this.SignUpFormFirstLabel.Size = new System.Drawing.Size(82, 18);
            this.SignUpFormFirstLabel.TabIndex = 24;
            this.SignUpFormFirstLabel.Text = "First name";
            // 
            // SignUpFormFirstTextBox
            // 
            this.SignUpFormFirstTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SignUpFormFirstTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SignUpFormFirstTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormFirstTextBox.ForeColor = System.Drawing.Color.Gray;
            this.SignUpFormFirstTextBox.Location = new System.Drawing.Point(76, 171);
            this.SignUpFormFirstTextBox.Name = "SignUpFormFirstTextBox";
            this.SignUpFormFirstTextBox.Size = new System.Drawing.Size(250, 19);
            this.SignUpFormFirstTextBox.TabIndex = 11;
            this.SignUpFormFirstTextBox.Text = "Enter your first name";
            this.SignUpFormFirstTextBox.Enter += new System.EventHandler(this.SignUpFormFirstTextBox_Enter);
            this.SignUpFormFirstTextBox.Leave += new System.EventHandler(this.SignUpFormFirstTextBox_Leave);
            // 
            // SignUpFormFirstPanel
            // 
            this.SignUpFormFirstPanel.BackColor = System.Drawing.Color.Gray;
            this.SignUpFormFirstPanel.Location = new System.Drawing.Point(76, 197);
            this.SignUpFormFirstPanel.Name = "SignUpFormFirstPanel";
            this.SignUpFormFirstPanel.Size = new System.Drawing.Size(250, 1);
            this.SignUpFormFirstPanel.TabIndex = 22;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.SignUpFormFirstLabel);
            this.Controls.Add(this.SignUpFormFirstTextBox);
            this.Controls.Add(this.SignUpFormFirstPanel);
            this.Controls.Add(this.SignUpFormLastLabel);
            this.Controls.Add(this.SignUpFormLastTextBox);
            this.Controls.Add(this.SignUpFormLastPanel);
            this.Controls.Add(this.SignUpFormUserLabel);
            this.Controls.Add(this.SignUpFormPassLabel);
            this.Controls.Add(this.SignUpFormBackLabel);
            this.Controls.Add(this.SignUpFormErrorLabel);
            this.Controls.Add(this.SignUpFormRegisterButton);
            this.Controls.Add(this.SignUpFormPassTextBox);
            this.Controls.Add(this.SignUpFormPassPanel);
            this.Controls.Add(this.SignUpFormUserTextBox);
            this.Controls.Add(this.SignUpFormUserPanel);
            this.Controls.Add(this.SignUpFormMainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up!";
            ((System.ComponentModel.ISupportInitialize)(this.SignUpFormMainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SignUpFormMainPictureBox;
        private System.Windows.Forms.TextBox SignUpFormUserTextBox;
        private System.Windows.Forms.Panel SignUpFormUserPanel;
        private System.Windows.Forms.TextBox SignUpFormPassTextBox;
        private System.Windows.Forms.Panel SignUpFormPassPanel;
        private System.Windows.Forms.Button SignUpFormRegisterButton;
        private System.Windows.Forms.Label SignUpFormErrorLabel;
        private System.Windows.Forms.Label SignUpFormBackLabel;
        private System.Windows.Forms.Label SignUpFormPassLabel;
        private System.Windows.Forms.Label SignUpFormUserLabel;
        private System.Windows.Forms.Label SignUpFormLastLabel;
        private System.Windows.Forms.TextBox SignUpFormLastTextBox;
        private System.Windows.Forms.Panel SignUpFormLastPanel;
        private System.Windows.Forms.Label SignUpFormFirstLabel;
        private System.Windows.Forms.TextBox SignUpFormFirstTextBox;
        private System.Windows.Forms.Panel SignUpFormFirstPanel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}