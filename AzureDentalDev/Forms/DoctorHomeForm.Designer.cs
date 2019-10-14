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
    public partial class DoctorHomeForm : Form
    {

        public DoctorHomeForm(String strUserName, String strPassword)
        {
            InitializeComponent();
            DoctorHomeFormCode(strUserName, strPassword);
        }

        private void DoctorHomeFormCode(String strUserName, String strPassword)
        {
            UserClass ucUser = DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);

            DoctorHomeFormWelcomeLabel.Text = $"Welcome Dr. {ucUser.m_strFirstName} {ucUser.m_strLastName}!";
        }

        private void DoctorHomeFormCloseLabel_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private TextBox DoctorHomeFormWelcomeLabel;
    }
}
