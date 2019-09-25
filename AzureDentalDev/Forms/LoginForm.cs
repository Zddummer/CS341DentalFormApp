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
    }
}
