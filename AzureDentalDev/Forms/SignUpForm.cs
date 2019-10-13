using AzureDentalDev.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureDentalDev.Forms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpFormBackLabel_MouseHover(object sender, EventArgs e)
        {
            SignUpFormBackLabel.ForeColor = Color.Aqua;
        }

        private void SignUpFormUserTextBox_Click(object sender, EventArgs e)
        {
            SignUpFormUserTextBox.Clear();
            SignUpFormUserTextBox.ForeColor = Color.Aqua;
            SignUpFormUserPanel.BackColor = Color.Aqua;
        }

        private void SignUpFormPassTextBox_Click(object sender, EventArgs e)
        {
            SignUpFormPassTextBox.Clear();
            SignUpFormPassTextBox.ForeColor = Color.Aqua;
            SignUpFormPassTextBox.PasswordChar = '•';
        }

        private void SignUpFormPassTextBox_Enter(object sender, EventArgs e)
        {
            SignUpFormPassTextBox.Clear();
            SignUpFormPassTextBox.ForeColor = Color.Aqua;
            SignUpFormPassPanel.BackColor = Color.Aqua;
            SignUpFormPassTextBox.PasswordChar = '•';
        }

        private void SignUpFormBackLabel_MouseLeave(object sender, EventArgs e)
        {
            SignUpFormBackLabel.ForeColor = Color.Gray;
        }

        private void SignUpFormUserTextBox_Leave(object sender, EventArgs e)
        {
            if (SignUpFormUserTextBox.Text.Equals(String.Empty))
            {
                SignUpFormUserTextBox.Text = "Create a username";
                SignUpFormUserTextBox.ForeColor = Color.Gray;
                SignUpFormUserPanel.BackColor = Color.Gray;
            }
        }

        private void SignUpFormPassTextBox_Leave(object sender, EventArgs e)
        {
            if (SignUpFormPassTextBox.Text.Equals(String.Empty))
            {
                SignUpFormPassTextBox.Text = "Create a password";
                SignUpFormPassTextBox.PasswordChar = '\0';
                SignUpFormPassTextBox.ForeColor = Color.Gray;
                SignUpFormPassPanel.BackColor = Color.Gray;
            }
        }

        private void SignUpFormUserTextBox_Enter(object sender, EventArgs e)
        {
            SignUpFormUserTextBox.Clear();
            SignUpFormUserTextBox.ForeColor = Color.Aqua;
            SignUpFormUserPanel.BackColor = Color.Aqua;
        }

        private void SignUpFormLastTextBox_Enter(object sender, EventArgs e)
        {
            SignUpFormLastTextBox.Clear();
            SignUpFormLastTextBox.ForeColor = Color.Aqua;
            SignUpFormLastPanel.BackColor = Color.Aqua;
        }

        private void SignUpFormLastTextBox_Leave(object sender, EventArgs e)
        {
            if (SignUpFormLastTextBox.Text.Equals(String.Empty))
            {
                SignUpFormLastTextBox.Text = "Enter your last name";
                SignUpFormLastTextBox.ForeColor = Color.Gray;
                SignUpFormLastPanel.BackColor = Color.Gray;
            }
        }

        private void SignUpFormFirstTextBox_Enter(object sender, EventArgs e)
        {
            SignUpFormFirstTextBox.Clear();
            SignUpFormFirstTextBox.ForeColor = Color.Aqua;
            SignUpFormFirstPanel.BackColor = Color.Aqua;
        }

        private void SignUpFormFirstTextBox_Leave(object sender, EventArgs e)
        {
            if (SignUpFormFirstTextBox.Text.Equals(String.Empty))
            {
                SignUpFormFirstTextBox.Text = "Enter your first name";
                SignUpFormFirstTextBox.ForeColor = Color.Gray;
                SignUpFormFirstPanel.BackColor = Color.Gray;
            }
        }

        private void SignUpFormBackLabel_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void SignUpFormRegisterButton_Click(object sender, EventArgs e)
        {

            if (SignUpFormFirstTextBox.Text == "Enter your first name" || SignUpFormFirstTextBox.Text == String.Empty ||
               SignUpFormLastTextBox.Text == "Enter your last name" || SignUpFormLastTextBox.Text == String.Empty ||
               SignUpFormUserTextBox.Text == "Create a username" || SignUpFormUserTextBox.Text == String.Empty ||
               SignUpFormPassTextBox.Text == "Create a password" || SignUpFormPassTextBox.Text == String.Empty)
            {
                return;
            }

            Boolean blnWasAccountCreated = DataAccessClass.registerNewUser(SignUpFormFirstTextBox.Text, 
                                                                           SignUpFormLastTextBox.Text,
                                                                           SignUpFormUserTextBox.Text,
                                                                           SignUpFormPassTextBox.Text);

            if (blnWasAccountCreated)
            {
                SignUpFormValidLabel.Visible = true;
                SignUpFormErrorLabel.Visible = false;
            } else
            {
                SignUpFormValidLabel.Visible = false;
                SignUpFormErrorLabel.Visible = true;
            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            this.Left -= 10;
            if (this.Left <= 500)
            {
                timer1.Stop();
                this.TopMost = false;
                Application.OpenForms[0].BringToFront();
                timer2.Start();
            }
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            this.Left += 10;
            if (this.Left >= 690)
            {
                timer2.Stop();
            }
        }
    }
}
