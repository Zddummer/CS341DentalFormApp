/**
 * 
 * This class handles all the logic and GUI functionality for creating a new user
 * 
 */

using AzureDentalDev.Classes;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AzureDentalDev.Forms
{
    public partial class SignUpForm : Form
    {
        // constructor method for SignUp form
        public SignUpForm()
        {
            InitializeComponent();
        }

        #region Sign Up Logic methods
        // Creates the new user iff all the fields are filled in on click
        private void SignUpFormRegisterButton_Click(object sender, EventArgs e)
        {

            if (SignUpFormFirstTextBox.Text == "Enter your first name" || SignUpFormFirstTextBox.Text == String.Empty ||
               SignUpFormLastTextBox.Text == "Enter your last name" || SignUpFormLastTextBox.Text == String.Empty ||
               SignUpFormUserTextBox.Text == "Create a username" || SignUpFormUserTextBox.Text == String.Empty ||
               SignUpFormPassTextBox.Text == "Create a password" || SignUpFormPassTextBox.Text == String.Empty)
            {
                return;
            }

            Boolean blnWasAccountCreated = BusinessLogicClass.registerNewUser(SignUpFormFirstTextBox.Text,
                                                                           SignUpFormLastTextBox.Text,
                                                                           SignUpFormUserTextBox.Text,
                                                                           SignUpFormPassTextBox.Text);

            if (blnWasAccountCreated)
            {
                DisplayConfirmation();
            }
            else
            {
                DisplayError();
            }

        }
        #endregion

        #region GUI Functionality Methods
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
            if (this.Left >= Application.OpenForms[0].Left)
            {
                timer2.Stop();
            }
        }

        private void DisplayError()
        {
            SignUpErrorPanel.Visible = true;
            SignUpErrorPanel.Top = 500;
            ErrorTimer.Start();
        }

        private void DisplayConfirmation()
        {
            SignUpConfirmPanel.Visible = true;
            SignUpConfirmPanel.Top = 500;
            ConfirmTimer.Start();
        }

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            if (SignUpErrorPanel.Bottom > 500)
            {
                SignUpErrorPanel.Top -= 7;
            }
            else if (SignUpErrorPanel.Bottom <= 500)
            {
                ErrorTimer.Stop();
                System.Threading.Thread.Sleep(1000);
                ErrorTimer2.Start();
            }
        }

        private void ErrorTimer2_Tick(object sender, EventArgs e)
        {
            if (SignUpErrorPanel.Top == 500)
            {
                ErrorTimer2.Stop();
                SignUpErrorPanel.Visible = false;
            }
            if (SignUpErrorPanel.Top <= 500)
            {
                SignUpErrorPanel.Top += 7;
            }
        }

        private void ConfirmTimer_Tick(object sender, EventArgs e)
        {
            if (SignUpConfirmPanel.Bottom > 500)
            {
                SignUpConfirmPanel.Top -= 7;
            }
            else if (SignUpConfirmPanel.Bottom <= 500)
            {
                ConfirmTimer.Stop();
                System.Threading.Thread.Sleep(1000);
                ConfirmTimer2.Start();
            }
        }

        private void ConfirmTimer2_Tick(object sender, EventArgs e)
        {
            if (SignUpConfirmPanel.Top == 500)
            {
                ConfirmTimer2.Stop();
                SignUpConfirmPanel.Visible = false;
            }
            if (SignUpConfirmPanel.Top <= 500)
            {
                SignUpConfirmPanel.Top += 7;
            }
        }
        #endregion
    }
}
