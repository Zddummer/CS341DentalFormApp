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
        UserClass g_ucUserReturnedFromSearch = null;
        public AdminHomeForm(String strUserName, String strPassword)
        {
            InitializeComponent();
            AdminHomeFormCode(strUserName, strPassword);
        }

        private void AdminHomeFormCode(String strUserName, String strPassword)
        {
            UserClass ucUser = BusinessLogicClass.QueryDatabaseForUser(strUserName, strPassword);

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

        private void AdminHomeLogoutLabel_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            Close();
        }

        private void AdminHomeUserSearchButton_Click(object sender, EventArgs e)
        {
            g_ucUserReturnedFromSearch = DataAccessClass.QueryDatabaseForUser(AdminHomeSearchTextBox.Text);
            if(g_ucUserReturnedFromSearch != null)
            {
                AdminSearchPanel.Visible = true;
                AdminHomeFullNameLabel.Text = g_ucUserReturnedFromSearch.m_strLastName + ", " + g_ucUserReturnedFromSearch.m_strFirstName;
                AdminUserNameLabel.Text = g_ucUserReturnedFromSearch.m_strUsername;
                AdminHomeTypeLabel.Text = g_ucUserReturnedFromSearch.m_chrUserType[0].ToString();
                AdminHomeStatusLabel.Text = g_ucUserReturnedFromSearch.m_chrAccessType[0].ToString();
            } else
            {
               AdminHomeErrorPanel.Visible = true;
               AdminHomeErrorPanel.Left = 900;
                AdminErrorMessageLabel.Text = "THAT USER DOES NOT EXIT";
               timer1.Start();
            }
        }


        private void AdminHomeSearchTextBox_Enter(object sender, EventArgs e)
        {
            if(AdminHomeSearchTextBox.Text == "Enter a Username")
            {
                AdminHomeSearchTextBox.Text = String.Empty;
            }
        }

        private void AdminHomeSearchTextBox_Leave(object sender, EventArgs e)
        {
            if(AdminHomeSearchTextBox.Text == String.Empty)
            {
                AdminHomeSearchTextBox.Text = "Enter a Username";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            AdminHomeErrorPanel.Left -= 300;
            if (AdminHomeErrorPanel.Left <= 0)
            {
                timer1.Stop();
                System.Threading.Thread.Sleep(1500);
                AdminHomeErrorPanel.Visible = false;
            }
        }
    }
}
