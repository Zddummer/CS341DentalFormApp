using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AzureDentalDev.Classes;

namespace AzureDentalDev.Forms
{
    public partial class DoctorHomeForm : Form
        
    {
        public DoctorHomeForm(String strUserName, String strPassword)
        {           InitializeComponent();
            UserClass ucDoctorUser = DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);
            DoctorHomeFormWelcomeLabel.Text = $"Welcome Dr. {ucDoctorUser.m_strFirstName} {ucDoctorUser.m_strLastName}";
            
        }

        private void DoctorHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
