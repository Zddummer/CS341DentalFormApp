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
    public partial class AdminHomeForm : Form
    {

        public AdminHomeForm(String strUserName, String strPassword)
        {
            InitializeComponent();
            AdminHomeFormCode(strUserName, strPassword);
        }

        private void AdminHomeFormCode(String strUserName, String strPassword)
        {
            UserClass ucUser = DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);

            AdminHomeFormWelcomeLabel.Text = $"Welcome {ucUser.m_strFirstName} {ucUser.m_strLastName}!";
        }

        private void AdminHomeFormCloseLabel_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void AdminFormCreateButton_Click(object sender, EventArgs e)
        {
            AdminCreateAccountForm oAdminCreateAccountForm = new AdminCreateAccountForm();
            oAdminCreateAccountForm.Show();
        }

        private void AdminHomeFormUpdateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
