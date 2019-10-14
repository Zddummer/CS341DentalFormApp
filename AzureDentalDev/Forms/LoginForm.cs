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
            UserClass ucUser = DataAccessClass.QueryDatabaseForUser(LoginFormUserTextBox.Text, LoginFormPassTextBox.Text);

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
                    case 'C':
                        CustomerHomeForm oCustomerHomeForm = new CustomerHomeForm();
                        oCustomerHomeForm.Show();
                        this.Visible = false;
                        childSignUpForm.Visible = false;
                        break;

                    case 'D':
                        DoctorHomeForm oDoctorHomeForm = new DoctorHomeForm(LoginFormUserTextBox.Text, LoginFormPassTextBox.text);
                        oDoctorHomeForm.show();
                        this.Visible = false;
                        break;
                    case 'H':

                        break;
                    default:
                        LoginFormErrorLabel.Visible = true;
                        break;
                }
            } else
            {
                LoginFormErrorLabel.Visible = true;
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
            if (childSignUpForm.Left <= 700)
            {
                timer2.Stop();
            }
        }
    }
}
