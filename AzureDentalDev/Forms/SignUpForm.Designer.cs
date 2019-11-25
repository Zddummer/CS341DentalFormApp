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
            this.SignUpFormUserTextBox = new System.Windows.Forms.TextBox();
            this.SignUpFormUserPanel = new System.Windows.Forms.Panel();
            this.SignUpFormPassTextBox = new System.Windows.Forms.TextBox();
            this.SignUpFormPassPanel = new System.Windows.Forms.Panel();
            this.SignUpFormRegisterButton = new System.Windows.Forms.Button();
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
            this.SignUpFormCompanyLabel1 = new System.Windows.Forms.Label();
            this.SignUpFormNameLabel2 = new System.Windows.Forms.Label();
            this.SignUpErrorPanel = new System.Windows.Forms.Panel();
            this.SignUpErrorLabel = new System.Windows.Forms.Label();
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.ErrorTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SignUpConfirmPanel = new System.Windows.Forms.Panel();
            this.SignUpConfirmLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUpFormMainPictureBox = new System.Windows.Forms.PictureBox();
            this.ConfirmTimer = new System.Windows.Forms.Timer(this.components);
            this.ConfirmTimer2 = new System.Windows.Forms.Timer(this.components);
            this.SignUpErrorPanel.SuspendLayout();
            this.SignUpConfirmPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignUpFormMainPictureBox)).BeginInit();
            this.SuspendLayout();
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
            this.SignUpFormRegisterButton.Location = new System.Drawing.Point(76, 408);
            this.SignUpFormRegisterButton.Name = "SignUpFormRegisterButton";
            this.SignUpFormRegisterButton.Size = new System.Drawing.Size(250, 35);
            this.SignUpFormRegisterButton.TabIndex = 10;
            this.SignUpFormRegisterButton.Text = "Register";
            this.SignUpFormRegisterButton.UseVisualStyleBackColor = false;
            this.SignUpFormRegisterButton.Click += new System.EventHandler(this.SignUpFormRegisterButton_Click);
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
            // SignUpFormCompanyLabel1
            // 
            this.SignUpFormCompanyLabel1.AutoSize = true;
            this.SignUpFormCompanyLabel1.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormCompanyLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.SignUpFormCompanyLabel1.Location = new System.Drawing.Point(85, 93);
            this.SignUpFormCompanyLabel1.Name = "SignUpFormCompanyLabel1";
            this.SignUpFormCompanyLabel1.Size = new System.Drawing.Size(78, 24);
            this.SignUpFormCompanyLabel1.TabIndex = 26;
            this.SignUpFormCompanyLabel1.Text = "Tru Blu";
            // 
            // SignUpFormNameLabel2
            // 
            this.SignUpFormNameLabel2.AutoSize = true;
            this.SignUpFormNameLabel2.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpFormNameLabel2.ForeColor = System.Drawing.Color.Aqua;
            this.SignUpFormNameLabel2.Location = new System.Drawing.Point(239, 93);
            this.SignUpFormNameLabel2.Name = "SignUpFormNameLabel2";
            this.SignUpFormNameLabel2.Size = new System.Drawing.Size(69, 24);
            this.SignUpFormNameLabel2.TabIndex = 27;
            this.SignUpFormNameLabel2.Text = "Dental";
            // 
            // SignUpErrorPanel
            // 
            this.SignUpErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.SignUpErrorPanel.Controls.Add(this.pictureBox1);
            this.SignUpErrorPanel.Controls.Add(this.SignUpErrorLabel);
            this.SignUpErrorPanel.Location = new System.Drawing.Point(0, 482);
            this.SignUpErrorPanel.Name = "SignUpErrorPanel";
            this.SignUpErrorPanel.Size = new System.Drawing.Size(400, 33);
            this.SignUpErrorPanel.TabIndex = 28;
            this.SignUpErrorPanel.Visible = false;
            // 
            // SignUpErrorLabel
            // 
            this.SignUpErrorLabel.AutoSize = true;
            this.SignUpErrorLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpErrorLabel.ForeColor = System.Drawing.Color.White;
            this.SignUpErrorLabel.Location = new System.Drawing.Point(112, 9);
            this.SignUpErrorLabel.Name = "SignUpErrorLabel";
            this.SignUpErrorLabel.Size = new System.Drawing.Size(158, 16);
            this.SignUpErrorLabel.TabIndex = 0;
            this.SignUpErrorLabel.Text = "THAT USERNAME IS TAKEN!";
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // ErrorTimer2
            // 
            this.ErrorTimer2.Tick += new System.EventHandler(this.ErrorTimer2_Tick);
            // 
            // SignUpConfirmPanel
            // 
            this.SignUpConfirmPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(186)))), ((int)(((byte)(29)))));
            this.SignUpConfirmPanel.Controls.Add(this.pictureBox2);
            this.SignUpConfirmPanel.Controls.Add(this.SignUpConfirmLabel);
            this.SignUpConfirmPanel.Location = new System.Drawing.Point(0, 447);
            this.SignUpConfirmPanel.Name = "SignUpConfirmPanel";
            this.SignUpConfirmPanel.Size = new System.Drawing.Size(400, 33);
            this.SignUpConfirmPanel.TabIndex = 29;
            this.SignUpConfirmPanel.Visible = false;
            // 
            // SignUpConfirmLabel
            // 
            this.SignUpConfirmLabel.AutoSize = true;
            this.SignUpConfirmLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpConfirmLabel.ForeColor = System.Drawing.Color.White;
            this.SignUpConfirmLabel.Location = new System.Drawing.Point(101, 8);
            this.SignUpConfirmLabel.Name = "SignUpConfirmLabel";
            this.SignUpConfirmLabel.Size = new System.Drawing.Size(212, 16);
            this.SignUpConfirmLabel.TabIndex = 0;
            this.SignUpConfirmLabel.Text = "YOUR ACCOUNT HAS BEEN CREATED!";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::AzureDentalDev.Properties.Resources.check_32x32;
            this.pictureBox2.Location = new System.Drawing.Point(16, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AzureDentalDev.Properties.Resources.error_1_32x32;
            this.pictureBox1.Location = new System.Drawing.Point(16, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // ConfirmTimer
            // 
            this.ConfirmTimer.Tick += new System.EventHandler(this.ConfirmTimer_Tick);
            // 
            // ConfirmTimer2
            // 
            this.ConfirmTimer2.Tick += new System.EventHandler(this.ConfirmTimer2_Tick);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.SignUpConfirmPanel);
            this.Controls.Add(this.SignUpErrorPanel);
            this.Controls.Add(this.SignUpFormNameLabel2);
            this.Controls.Add(this.SignUpFormCompanyLabel1);
            this.Controls.Add(this.SignUpFormFirstLabel);
            this.Controls.Add(this.SignUpFormFirstTextBox);
            this.Controls.Add(this.SignUpFormFirstPanel);
            this.Controls.Add(this.SignUpFormLastLabel);
            this.Controls.Add(this.SignUpFormLastTextBox);
            this.Controls.Add(this.SignUpFormLastPanel);
            this.Controls.Add(this.SignUpFormUserLabel);
            this.Controls.Add(this.SignUpFormPassLabel);
            this.Controls.Add(this.SignUpFormBackLabel);
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
            this.SignUpErrorPanel.ResumeLayout(false);
            this.SignUpErrorPanel.PerformLayout();
            this.SignUpConfirmPanel.ResumeLayout(false);
            this.SignUpConfirmPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label SignUpFormCompanyLabel1;
        private System.Windows.Forms.Label SignUpFormNameLabel2;
        private System.Windows.Forms.Panel SignUpErrorPanel;
        private System.Windows.Forms.Label SignUpErrorLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer ErrorTimer;
        private System.Windows.Forms.Timer ErrorTimer2;
        private System.Windows.Forms.Panel SignUpConfirmPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label SignUpConfirmLabel;
        private System.Windows.Forms.Timer ConfirmTimer;
        private System.Windows.Forms.Timer ConfirmTimer2;
    }
}