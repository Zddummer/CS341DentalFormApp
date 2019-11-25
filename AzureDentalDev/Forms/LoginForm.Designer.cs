namespace AzureDentalDev
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginFormUserPanel = new System.Windows.Forms.Panel();
            this.LoginFormPassPanel = new System.Windows.Forms.Panel();
            this.LoginFormCloseLabel = new System.Windows.Forms.Label();
            this.LoginFormUserTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormPassTextBox = new System.Windows.Forms.TextBox();
            this.LoginFormLoginButton = new System.Windows.Forms.Button();
            this.LoginFormSignUpButton = new System.Windows.Forms.Button();
            this.LoginFormErrorLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.LoginFormCompanyLabel1 = new System.Windows.Forms.Label();
            this.LoginFormNameLabel2 = new System.Windows.Forms.Label();
            this.LoginFormErrorPanel = new System.Windows.Forms.Panel();
            this.ErrorLabel = new System.Windows.Forms.Label();
            this.ErrorTimer = new System.Windows.Forms.Timer(this.components);
            this.ErrorTimer2 = new System.Windows.Forms.Timer(this.components);
            this.HelpToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HelpPictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginFormPassPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginFormUserPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginFormMainPictureBox = new System.Windows.Forms.PictureBox();
            this.LoginFormMinLabel = new System.Windows.Forms.Label();
            this.LoginFormErrorPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormPassPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormMainPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginFormUserPanel
            // 
            this.LoginFormUserPanel.BackColor = System.Drawing.Color.Aqua;
            this.LoginFormUserPanel.Location = new System.Drawing.Point(76, 225);
            this.LoginFormUserPanel.Name = "LoginFormUserPanel";
            this.LoginFormUserPanel.Size = new System.Drawing.Size(250, 1);
            this.LoginFormUserPanel.TabIndex = 1;
            // 
            // LoginFormPassPanel
            // 
            this.LoginFormPassPanel.BackColor = System.Drawing.Color.Aqua;
            this.LoginFormPassPanel.Location = new System.Drawing.Point(76, 294);
            this.LoginFormPassPanel.Name = "LoginFormPassPanel";
            this.LoginFormPassPanel.Size = new System.Drawing.Size(250, 1);
            this.LoginFormPassPanel.TabIndex = 2;
            // 
            // LoginFormCloseLabel
            // 
            this.LoginFormCloseLabel.AutoSize = true;
            this.LoginFormCloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFormCloseLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormCloseLabel.ForeColor = System.Drawing.Color.Gray;
            this.LoginFormCloseLabel.Location = new System.Drawing.Point(365, 9);
            this.LoginFormCloseLabel.Name = "LoginFormCloseLabel";
            this.LoginFormCloseLabel.Size = new System.Drawing.Size(23, 22);
            this.LoginFormCloseLabel.TabIndex = 3;
            this.LoginFormCloseLabel.Text = "X";
            this.LoginFormCloseLabel.Click += new System.EventHandler(this.Label1_Click);
            this.LoginFormCloseLabel.MouseLeave += new System.EventHandler(this.LoginFormCloseLabel_MouseLeave);
            this.LoginFormCloseLabel.MouseHover += new System.EventHandler(this.LoginFormCloseLabel_MouseHover);
            // 
            // LoginFormUserTextBox
            // 
            this.LoginFormUserTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginFormUserTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginFormUserTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormUserTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginFormUserTextBox.Location = new System.Drawing.Point(115, 199);
            this.LoginFormUserTextBox.Name = "LoginFormUserTextBox";
            this.LoginFormUserTextBox.Size = new System.Drawing.Size(211, 19);
            this.LoginFormUserTextBox.TabIndex = 7;
            this.LoginFormUserTextBox.Text = "Username";
            this.LoginFormUserTextBox.Click += new System.EventHandler(this.LoginFormUserTextBox_Click);
            this.LoginFormUserTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginFormUserTextBox_KeyDown);
            // 
            // LoginFormPassTextBox
            // 
            this.LoginFormPassTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginFormPassTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginFormPassTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormPassTextBox.ForeColor = System.Drawing.Color.Gray;
            this.LoginFormPassTextBox.Location = new System.Drawing.Point(115, 272);
            this.LoginFormPassTextBox.Name = "LoginFormPassTextBox";
            this.LoginFormPassTextBox.Size = new System.Drawing.Size(211, 19);
            this.LoginFormPassTextBox.TabIndex = 8;
            this.LoginFormPassTextBox.Text = "Password";
            this.LoginFormPassTextBox.Click += new System.EventHandler(this.LoginFormPassTextBox_Click);
            this.LoginFormPassTextBox.Enter += new System.EventHandler(this.LoginFormPassTextBox_Enter);
            this.LoginFormPassTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LoginFormPassTextBox_KeyDown);
            // 
            // LoginFormLoginButton
            // 
            this.LoginFormLoginButton.BackColor = System.Drawing.Color.Aqua;
            this.LoginFormLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginFormLoginButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormLoginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginFormLoginButton.Location = new System.Drawing.Point(76, 372);
            this.LoginFormLoginButton.Name = "LoginFormLoginButton";
            this.LoginFormLoginButton.Size = new System.Drawing.Size(250, 35);
            this.LoginFormLoginButton.TabIndex = 9;
            this.LoginFormLoginButton.TabStop = false;
            this.LoginFormLoginButton.Text = "Log in";
            this.LoginFormLoginButton.UseVisualStyleBackColor = false;
            this.LoginFormLoginButton.Click += new System.EventHandler(this.LoginFormLoginButton_Click);
            // 
            // LoginFormSignUpButton
            // 
            this.LoginFormSignUpButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginFormSignUpButton.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormSignUpButton.ForeColor = System.Drawing.Color.Aqua;
            this.LoginFormSignUpButton.Location = new System.Drawing.Point(76, 414);
            this.LoginFormSignUpButton.Name = "LoginFormSignUpButton";
            this.LoginFormSignUpButton.Size = new System.Drawing.Size(250, 35);
            this.LoginFormSignUpButton.TabIndex = 6;
            this.LoginFormSignUpButton.Text = "Sign up";
            this.LoginFormSignUpButton.UseVisualStyleBackColor = false;
            this.LoginFormSignUpButton.Click += new System.EventHandler(this.LoginFormSignUpButton_Click);
            // 
            // LoginFormErrorLabel
            // 
            this.LoginFormErrorLabel.AutoSize = true;
            this.LoginFormErrorLabel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.LoginFormErrorLabel.Location = new System.Drawing.Point(112, 330);
            this.LoginFormErrorLabel.Name = "LoginFormErrorLabel";
            this.LoginFormErrorLabel.Size = new System.Drawing.Size(0, 16);
            this.LoginFormErrorLabel.TabIndex = 10;
            this.LoginFormErrorLabel.Visible = false;
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
            // LoginFormCompanyLabel1
            // 
            this.LoginFormCompanyLabel1.AutoSize = true;
            this.LoginFormCompanyLabel1.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormCompanyLabel1.ForeColor = System.Drawing.Color.Aqua;
            this.LoginFormCompanyLabel1.Location = new System.Drawing.Point(85, 94);
            this.LoginFormCompanyLabel1.Name = "LoginFormCompanyLabel1";
            this.LoginFormCompanyLabel1.Size = new System.Drawing.Size(78, 24);
            this.LoginFormCompanyLabel1.TabIndex = 11;
            this.LoginFormCompanyLabel1.Text = "Tru Blu";
            // 
            // LoginFormNameLabel2
            // 
            this.LoginFormNameLabel2.AutoSize = true;
            this.LoginFormNameLabel2.Font = new System.Drawing.Font("Californian FB", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormNameLabel2.ForeColor = System.Drawing.Color.Aqua;
            this.LoginFormNameLabel2.Location = new System.Drawing.Point(239, 94);
            this.LoginFormNameLabel2.Name = "LoginFormNameLabel2";
            this.LoginFormNameLabel2.Size = new System.Drawing.Size(69, 24);
            this.LoginFormNameLabel2.TabIndex = 12;
            this.LoginFormNameLabel2.Text = "Dental";
            // 
            // LoginFormErrorPanel
            // 
            this.LoginFormErrorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(64)))), ((int)(((byte)(52)))));
            this.LoginFormErrorPanel.Controls.Add(this.pictureBox1);
            this.LoginFormErrorPanel.Controls.Add(this.ErrorLabel);
            this.LoginFormErrorPanel.Location = new System.Drawing.Point(1, 487);
            this.LoginFormErrorPanel.Name = "LoginFormErrorPanel";
            this.LoginFormErrorPanel.Size = new System.Drawing.Size(400, 33);
            this.LoginFormErrorPanel.TabIndex = 13;
            this.LoginFormErrorPanel.Visible = false;
            // 
            // ErrorLabel
            // 
            this.ErrorLabel.AutoSize = true;
            this.ErrorLabel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorLabel.ForeColor = System.Drawing.Color.White;
            this.ErrorLabel.Location = new System.Drawing.Point(102, 4);
            this.ErrorLabel.Name = "ErrorLabel";
            this.ErrorLabel.Size = new System.Drawing.Size(205, 16);
            this.ErrorLabel.TabIndex = 0;
            this.ErrorLabel.Text = "INVALID USERNAME OR PASSWORD";
            // 
            // ErrorTimer
            // 
            this.ErrorTimer.Tick += new System.EventHandler(this.ErrorTimer_Tick);
            // 
            // ErrorTimer2
            // 
            this.ErrorTimer2.Tick += new System.EventHandler(this.ErrorTimer2_Tick);
            // 
            // HelpToolTip
            // 
            this.HelpToolTip.ToolTipTitle = "Help";
            // 
            // HelpPictureBox
            // 
            this.HelpPictureBox.BackColor = System.Drawing.Color.Cyan;
            this.HelpPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpPictureBox.BackgroundImage")));
            this.HelpPictureBox.Location = new System.Drawing.Point(360, 460);
            this.HelpPictureBox.Name = "HelpPictureBox";
            this.HelpPictureBox.Size = new System.Drawing.Size(28, 28);
            this.HelpPictureBox.TabIndex = 14;
            this.HelpPictureBox.TabStop = false;
            this.HelpPictureBox.Click += new System.EventHandler(this.HelpPictureBox_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::AzureDentalDev.Properties.Resources.error_1_32x32;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // LoginFormPassPictureBox
            // 
            this.LoginFormPassPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginFormPassPictureBox.BackgroundImage")));
            this.LoginFormPassPictureBox.Location = new System.Drawing.Point(76, 256);
            this.LoginFormPassPictureBox.Name = "LoginFormPassPictureBox";
            this.LoginFormPassPictureBox.Size = new System.Drawing.Size(32, 32);
            this.LoginFormPassPictureBox.TabIndex = 5;
            this.LoginFormPassPictureBox.TabStop = false;
            // 
            // LoginFormUserPictureBox
            // 
            this.LoginFormUserPictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LoginFormUserPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginFormUserPictureBox.BackgroundImage")));
            this.LoginFormUserPictureBox.Location = new System.Drawing.Point(76, 187);
            this.LoginFormUserPictureBox.Name = "LoginFormUserPictureBox";
            this.LoginFormUserPictureBox.Size = new System.Drawing.Size(32, 32);
            this.LoginFormUserPictureBox.TabIndex = 4;
            this.LoginFormUserPictureBox.TabStop = false;
            // 
            // LoginFormMainPictureBox
            // 
            this.LoginFormMainPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginFormMainPictureBox.BackgroundImage")));
            this.LoginFormMainPictureBox.Location = new System.Drawing.Point(169, 75);
            this.LoginFormMainPictureBox.Name = "LoginFormMainPictureBox";
            this.LoginFormMainPictureBox.Size = new System.Drawing.Size(64, 62);
            this.LoginFormMainPictureBox.TabIndex = 0;
            this.LoginFormMainPictureBox.TabStop = false;
            // 
            // LoginFormMinLabel
            // 
            this.LoginFormMinLabel.AutoSize = true;
            this.LoginFormMinLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginFormMinLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginFormMinLabel.ForeColor = System.Drawing.Color.Gray;
            this.LoginFormMinLabel.Location = new System.Drawing.Point(336, 9);
            this.LoginFormMinLabel.Name = "LoginFormMinLabel";
            this.LoginFormMinLabel.Size = new System.Drawing.Size(21, 22);
            this.LoginFormMinLabel.TabIndex = 15;
            this.LoginFormMinLabel.Text = "_";
            this.LoginFormMinLabel.Click += new System.EventHandler(this.LoginFormMinLabel_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.LoginFormMinLabel);
            this.Controls.Add(this.HelpPictureBox);
            this.Controls.Add(this.LoginFormErrorPanel);
            this.Controls.Add(this.LoginFormNameLabel2);
            this.Controls.Add(this.LoginFormCompanyLabel1);
            this.Controls.Add(this.LoginFormErrorLabel);
            this.Controls.Add(this.LoginFormSignUpButton);
            this.Controls.Add(this.LoginFormLoginButton);
            this.Controls.Add(this.LoginFormPassTextBox);
            this.Controls.Add(this.LoginFormUserTextBox);
            this.Controls.Add(this.LoginFormPassPictureBox);
            this.Controls.Add(this.LoginFormUserPictureBox);
            this.Controls.Add(this.LoginFormCloseLabel);
            this.Controls.Add(this.LoginFormPassPanel);
            this.Controls.Add(this.LoginFormUserPanel);
            this.Controls.Add(this.LoginFormMainPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.VisibleChanged += new System.EventHandler(this.LoginForm_VisibleChanged);
            this.LoginFormErrorPanel.ResumeLayout(false);
            this.LoginFormErrorPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormPassPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoginFormMainPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox LoginFormMainPictureBox;
        private System.Windows.Forms.Panel LoginFormUserPanel;
        private System.Windows.Forms.Panel LoginFormPassPanel;
        private System.Windows.Forms.Label LoginFormCloseLabel;
        private System.Windows.Forms.PictureBox LoginFormUserPictureBox;
        private System.Windows.Forms.PictureBox LoginFormPassPictureBox;
        private System.Windows.Forms.TextBox LoginFormUserTextBox;
        private System.Windows.Forms.TextBox LoginFormPassTextBox;
        private System.Windows.Forms.Button LoginFormLoginButton;
        private System.Windows.Forms.Button LoginFormSignUpButton;
        private System.Windows.Forms.Label LoginFormErrorLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label LoginFormCompanyLabel1;
        private System.Windows.Forms.Label LoginFormNameLabel2;
        private System.Windows.Forms.Panel LoginFormErrorPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ErrorLabel;
        private System.Windows.Forms.Timer ErrorTimer;
        private System.Windows.Forms.Timer ErrorTimer2;
        private System.Windows.Forms.PictureBox HelpPictureBox;
        private System.Windows.Forms.ToolTip HelpToolTip;
        private System.Windows.Forms.Label LoginFormMinLabel;
    }
}

