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
                AdminHomeErrorPanel.Top = 575 - 33;
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
            if (AdminWarnPanel.Visible)
            {
                AdminWarnPanel.Left -= 300;
            } else if (AdminHomeErrorPanel.Visible)
            {
                AdminHomeErrorPanel.Left -= 300;
            } else if (AdminConfirmPanel.Visible)
            {
                AdminConfirmPanel.Left -= 300;
            }



            if (AdminHomeErrorPanel.Left <= 0 && AdminHomeErrorPanel.Visible)
            {
                timer1.Stop();
                System.Threading.Thread.Sleep(1500);
                AdminHomeErrorPanel.Visible = false;
            } else if(AdminWarnPanel.Left <= 0 && AdminWarnPanel.Visible)
            {
                timer1.Stop();
            }
            else if (AdminConfirmPanel.Left <= 0 && AdminConfirmPanel.Visible)
            {
                timer1.Stop();
                System.Threading.Thread.Sleep(1500);
                AdminConfirmPanel.Visible = false;
            }
        }

        private void AdminHomeDeleteButton_Click(object sender, EventArgs e)
        {
            if(AdminHomeStatusLabel.Text == "D")
            {
                AdminWarnAcceptButton_Click(sender, e);
            } else
            {
                AdminWarnPanel.Visible = true;
                AdminWarnPanel.Left = 900;
                AdminWarnPanel.Top = 575 - 33;
                timer1.Start();
            }
        }

        private void AdminWarnCancelButton_Click(object sender, EventArgs e)
        {
            AdminWarnPanel.Visible = false;
        }

        private void AdminWarnAcceptButton_Click(object sender, EventArgs e)
        {
            AdminWarnPanel.Visible = false;
            if (DataAccessClass.deleteUser(AdminUserNameLabel.Text))
            {
                AdminConfirmPanel.Visible = true;
                AdminConfirmPanel.Left = 900;
                AdminConfirmPanel.Top = 575 - 33;
                AdminConfirmLabel.Text = "THE USER HAS BEEN DELETED";
                timer1.Start();
                DataAccessClass.QueryDatabaseForUser(AdminUserNameLabel.Text);
                AdminHomeUserSearchButton_Click(sender, e);
            } else
            {
                AdminHomeErrorPanel.Visible = true;
                AdminHomeErrorPanel.Left = 900;
                AdminHomeErrorPanel.Top = 575 - 33;
                AdminErrorMessageLabel.Text = "THAT IS NOT AN ACTIVE USER";
                timer1.Start();
            }
        }

        private void AdminActiveButton_Click(object sender, EventArgs e)
        {
            if (DataAccessClass.activateUser(AdminUserNameLabel.Text))
            {
                AdminConfirmPanel.Visible = true;
                AdminConfirmPanel.Left = 900;
                AdminConfirmPanel.Top = 575 - 33;
                AdminConfirmLabel.Text = "THE USER HAS BEEN ACTIVATED";
                timer1.Start();
                DataAccessClass.QueryDatabaseForUser(AdminUserNameLabel.Text);
                AdminHomeUserSearchButton_Click(sender, e);
            } else
            {
                AdminHomeErrorPanel.Visible = true;
                AdminHomeErrorPanel.Left = 900;
                AdminHomeErrorPanel.Top = 575 - 33;
                AdminErrorMessageLabel.Text = "THE USER IS ALREADY ACTIVE";
                timer1.Start();
            }
        }

        private void AdminApptSearchButton_Click(object sender, EventArgs e)
        {


            List<AppointmentClass> lstAppointments;
            DateTime dtDate = AdminSearchDateTimePicker.Value;

            AdminInstructionLabel.Text = "There were no results";
            foreach (ListViewItem listitem in AppointmentListView.Items)
            {
                AppointmentListView.Items.Remove(listitem);
            }

            if (AdminUserSearchCheckBox.Checked && (AdminApptSearchTextBox.Text == "" || AdminApptSearchTextBox.Text == "Enter a Username"))
            {
                AdminHomeErrorPanel.Visible = true;
                AdminHomeErrorPanel.Left = 900;
                AdminHomeErrorPanel.Top = 575 - 33;
                AdminErrorMessageLabel.Text = "UNCHECK OR ENTER USER";
                timer1.Start();
            } else if(!AdminUserSearchCheckBox.Checked && !AdminDateSearchCheckBox.Checked)
            {
                AdminHomeErrorPanel.Visible = true;
                AdminHomeErrorPanel.Left = 900;
                AdminHomeErrorPanel.Top = 575 - 33;
                AdminErrorMessageLabel.Text = "CHECK ONE OR BOTH BOXES";
                timer1.Start();
            } else
            {
                if (!AdminDateSearchCheckBox.Checked)
                {
                    dtDate = new DateTime(2000, 1, 1);
                }
                lstAppointments = DataAccessClass.getAppointments_Admin(AdminApptSearchTextBox.Text, dtDate);
                if(lstAppointments.Count == 0)
                {
                    AppointmentListView.Visible = false;
                } else
                {
                    AppointmentListView.Visible = true;
                    int i = 1;
                    foreach (AppointmentClass acAppointment in lstAppointments)
                    {
                        ListViewItem item = new ListViewItem("Appointment " + i);
                        UserClass ucDentist = DataAccessClass.QueryDatabaseForUser(acAppointment.m_strDentistName);

                        
                        ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, acAppointment.m_dtDateTime.Date.ToShortDateString());
                        item.SubItems.Add(subitem);
                        ListViewItem.ListViewSubItem subitem1 = new ListViewItem.ListViewSubItem(item, acAppointment.m_dtDateTime.TimeOfDay.ToString());
                        item.SubItems.Add(subitem1);
                        ListViewItem.ListViewSubItem subitem2 = new ListViewItem.ListViewSubItem(item, ucDentist.m_strFirstName + " " + ucDentist.m_strLastName);
                        item.SubItems.Add(subitem2);
                        ListViewItem.ListViewSubItem subitem3 = new ListViewItem.ListViewSubItem(item, acAppointment.m_strDescription);
                        item.SubItems.Add(subitem3);
                        item.ForeColor = Color.LightSkyBlue;
                        if (acAppointment.m_chrStatus[0] == 'C')
                        {
                            item.Font = new Font("Arial", 9F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0)));
                        }
                        else
                        {
                            item.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        }
                        item.UseItemStyleForSubItems = true;

                        AppointmentListView.Items.Add(item);
                        i++;
                    }
                }
            }
        }

        private void AppointmentListView_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
