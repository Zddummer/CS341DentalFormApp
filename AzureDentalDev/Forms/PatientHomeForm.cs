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
    public partial class PatientHomeForm : Form
    {
        public PatientHomeForm(String strUserName, String strPassword)
        {
            InitializeComponent();
            //Add user's first and last name to welcome label
            UserClass ucUser = DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);
            PatientHomeFormWelcome.Text = $"Welcome {ucUser.m_strFirstName} {ucUser.m_strLastName}!";
            //Retrieve and display appointments associated with current user
        }

        private void CustomerHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void ScheduleAppointmentButton_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            //Validity check
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //store appointment in database
            panel1.Visible = false;
        }
    }
}
