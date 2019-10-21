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

            for(int i = 9; i <= 17; i++)
            {
                if(i <= 12)
                {
                    StartTimeComboBox.Items.Add($"{i}:00");
                }
                else
                {
                    CloseTimeComboBox.Items.Add($"{i}:00");
                }
            }
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

        private void HoursUpdateButton_Click(object sender, EventArgs e)
        {
            if (DataAccessClass.updateOpenOfficeHours(StartTimeComboBox.Text, CloseTimeComboBox.Text))
            {
                HoursUpdatedLabel.Visible = true;
            }
            else
            {
                HoursUpdatedLabel.Visible = false;
            }
        }

        private void AdminOpenDayButton_Click(object sender, EventArgs e)
        {
            if (DataAccessClass.openDay(AdminDateTimePicker.Value.Date.Date.ToString()))
            {
                AdminOpenDayLabel.Visible = true;
                AdminCloseDayLabel.Visible = false;
            }
        }

        private void AdminCloseDayButton_Click(object sender, EventArgs e)
        {
           if(DataAccessClass.closeDay(AdminDateTimePicker.Value.Date.ToString()))
            {
                AdminCloseDayLabel.Visible = true;
                AdminOpenDayLabel.Visible = false;
            }
        }
    }
}
