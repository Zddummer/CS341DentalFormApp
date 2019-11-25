using AzureDentalDev.Classes;
using AzureDentalDev.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzureDentalDev
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SignUpForm childSignUpForm = new SignUpForm();

        private void Label1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginFormLoginButton_Click(object sender, EventArgs e)
        {
            UserClass ucUser = BusinessLogicClass.QueryDatabaseForUser(LoginFormUserTextBox.Text, LoginFormPassTextBox.Text);

            if(ucUser != null)
            {
                switch (ucUser.m_chrUserType[0])
                {
                    case 'A':
                        AdminHomeForm oAdminHomeForm = new AdminHomeForm(LoginFormUserTextBox.Text, LoginFormPassTextBox.Text);
                        oAdminHomeForm.Show();
                        this.Visible = false;
                        childSignUpForm.Visible = false;
                        break;
                    case 'P':
                        PatientHomeForm oCustomerHomeForm = new PatientHomeForm(LoginFormUserTextBox.Text, LoginFormPassTextBox.Text);
                        oCustomerHomeForm.Show();
                        this.Visible = false;
                        childSignUpForm.Visible = false;
                        break;

                    case 'D':
                        DoctorHomeForm oDoctorHomeForm = new DoctorHomeForm(LoginFormUserTextBox.Text, LoginFormPassTextBox.Text);
                        oDoctorHomeForm.Show();
                        this.Visible = false;
                        childSignUpForm.Visible = false;
                        break;
                    case 'H':
                        HygienistHomeForm oHygenistHomeForm = new HygienistHomeForm(LoginFormUserTextBox.Text, LoginFormPassTextBox.Text);
                        oHygenistHomeForm.Show();
                        this.Visible = false;
                        childSignUpForm.Visible = false;
                        break;
                    default:
                        LoginFormErrorLabel.Visible = true;
                        break;
                }
            } else
            {
                DisplayError();
            }
        }

        private void LoginFormUserTextBox_Click(object sender, EventArgs e)
        {
            LoginFormUserTextBox.Clear();
            LoginFormUserTextBox.ForeColor = Color.Aqua;
        }

        private void LoginFormPassTextBox_Click(object sender, EventArgs e)
        {
            LoginFormPassTextBox.Clear();
            LoginFormPassTextBox.ForeColor = Color.Aqua;
            LoginFormPassTextBox.PasswordChar = '•';
        }

        private void LoginFormPassTextBox_Enter(object sender, EventArgs e)
        {
            LoginFormPassTextBox.Clear();
            LoginFormPassTextBox.ForeColor = Color.Aqua;
            LoginFormPassTextBox.PasswordChar = '•';
        }

        private void LoginFormUserTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginFormLoginButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void LoginFormPassTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginFormLoginButton.PerformClick();
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }

        private void LoginFormSignUpButton_Click(object sender, EventArgs e)
        {
            childSignUpForm.Visible = true;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            childSignUpForm.Left += 10;
            if(childSignUpForm.Left >= 900)
            {
                timer1.Stop();
                this.TopMost = false;
                childSignUpForm.TopMost = true;
                timer2.Start();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            childSignUpForm.Show();
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            childSignUpForm.Left -= 10;
            if (childSignUpForm.Left <= this.Left)
            {
                timer2.Stop();
            }
        }

        private void LoginFormCloseLabel_MouseHover(object sender, EventArgs e)
        {
            LoginFormCloseLabel.ForeColor = Color.Red;
        }

        private void LoginFormCloseLabel_MouseLeave(object sender, EventArgs e)
        {
            LoginFormCloseLabel.ForeColor = Color.Gray;
        }

        private void LoginForm_VisibleChanged(object sender, EventArgs e)
        {
            if (LoginFormUserTextBox.Text != "Username" && LoginFormPassTextBox.Text != "Password") {
                LoginFormUserTextBox.Text = String.Empty;
                LoginFormPassTextBox.Text = String.Empty;
            }
            LoginFormErrorLabel.Visible = false;
        }

        private void DisplayError()
        {
            LoginFormErrorPanel.Visible = true;
            LoginFormErrorPanel.Top = 500;
            ErrorTimer.Start();
        }

        private void ErrorTimer_Tick(object sender, EventArgs e)
        {
            if(LoginFormErrorPanel.Bottom > 500)
            {
                LoginFormErrorPanel.Top -= 7;
            }
            else if(LoginFormErrorPanel.Bottom <= 500)
            {
                ErrorTimer.Stop();
                System.Threading.Thread.Sleep(1000);
                ErrorTimer2.Start();
            }
        }

        private void ErrorTimer2_Tick(object sender, EventArgs e)
        {
            if(LoginFormErrorPanel.Top == 500)
            {
                ErrorTimer2.Stop();
                LoginFormErrorPanel.Visible = false;
            }
            if (LoginFormErrorPanel.Top <= 500)
            {
                LoginFormErrorPanel.Top += 7;
            }
        }
    }
}
