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
using System.Data.SqlClient;

namespace AzureDentalDev.Forms
{
    public partial class PatientHomeForm : Form
    {
        private List<UserClass> m_lstDentistsHygeinists = new List<UserClass>();
        private List<AppointmentClass> m_lstAppointments = new List<AppointmentClass>();
        private String m_strUserName = "";
        private String m_strPassword = "";

        public PatientHomeForm(String strUserName, String strPassword)
        {
            InitializeComponent();
            m_strUserName = strUserName;
            m_strPassword = strPassword;
            //Add user's first and last name to welcome label
            UserClass ucUser = BusinessLogicClass.QueryDatabaseForUser(strUserName, strPassword);
            PatientHomeFormWelcome.Text = $"Welcome {ucUser.m_strFirstName} {ucUser.m_strLastName}!";

            //Fill AppointmentType
            AppointmentTypeComboBox.Items.Add("Cleaning");
            AppointmentTypeComboBox.Items.Add("Checkup");
            AppointmentTypeComboBox.Items.Add("Surgery");

            //Fill pickTimeComboBox
            PickTimeComboBox.Items.Add("9:00-10:00");
            PickTimeComboBox.Items.Add("10:00-11:00");
            PickTimeComboBox.Items.Add("11:00-12:00");
            PickTimeComboBox.Items.Add("12:00-13:00");
            PickTimeComboBox.Items.Add("13:00-14:00");
            PickTimeComboBox.Items.Add("14:00-15:00");
            PickTimeComboBox.Items.Add("15:00-16:00");
            PickTimeComboBox.Items.Add("16:00-17:00");

            //Fill dentistHygeinistList
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Users U ");
                sb.Append($"WHERE U.userType = 'D' ");
                sb.Append($"OR U.userType = 'H' ");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            m_lstDentistsHygeinists.Add(new UserClass(reader.GetString(0),
                                                         reader.GetString(1),
                                                         reader.GetString(2),
                                                         reader.GetString(3),
                                                         reader.GetSqlChars(4),
                                                         reader.GetSqlChars(5)));
                        }
                    }
                }
            }

            //fill dentistHygeinistComboBox
            foreach(UserClass user in m_lstDentistsHygeinists)
            {
                DentistHygeinistComboBox.Items.Add(user.m_strFirstName + " " + user.m_strLastName);
            }

            //Retrieve and display appointments associated with current user
            m_lstAppointments = DataAccessClass.getAppointmentsWithCustomerName(strUserName);
            int i = 1;
            foreach(AppointmentClass acAppointment in m_lstAppointments)
            {
                UserClass appointmentDentist = null;
                foreach (UserClass user in m_lstDentistsHygeinists)
                {
                    if (user.m_strUsername.Equals(acAppointment.m_strDentistName))
                    {
                        appointmentDentist = user;
                    }
                }

                ListViewItem item = new ListViewItem("Appointment " + i);
                item.SubItems.Add(acAppointment.m_dtDateTime.Date.ToShortDateString());
                item.SubItems.Add(acAppointment.m_dtDateTime.TimeOfDay.ToString());
                item.SubItems.Add(appointmentDentist.m_strFirstName + " " + appointmentDentist.m_strLastName);
                item.SubItems.Add(acAppointment.m_strDescription);
                item.ForeColor = Color.LightSkyBlue;
                if(acAppointment.m_chrStatus[0] == 'C')
                {
                    item.Font = new Font("Arial", 9F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    item.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
                AppointmentsList.Items.Add(item);
                i++;
            }
        }

        private void ClosePatientHomeFormButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void CustomerHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void ScheduleAppointmentButton_Click(object sender, EventArgs e)
        {
            ScheduleDescriptionTextBox.ForeColor = Color.Gray;
            ErrorMessageLabel.Visible = false;
            AppointmentTypeComboBox.Visible = true;
            dateTimePicker1.Visible = true;
            PickTimeComboBox.Visible = true;
            ScheduleDescriptionTextBox.Visible = true;
            DentistHygeinistComboBox.Visible = true;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void PickTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AppointmentConfirmationPanel.Visible = true;
        }

        private void AppointmentConfirmationButton_Click(object sender, EventArgs e)
        {
            //Validity Check
            String appointmentTime = "";
            if(PickTimeComboBox.Text.Substring(0,1) != "1")
            {
                appointmentTime = " " + PickTimeComboBox.Text.Substring(0, 4);
            } else
            {
                appointmentTime = " " + PickTimeComboBox.Text.Substring(0, 5);
            }
            String appointmentDate = dateTimePicker1.Value.ToShortDateString();
            String appointmentDentistName = DentistHygeinistComboBox.Text.ToString();
            UserClass appointmentDentist = null;
            foreach (UserClass user in m_lstDentistsHygeinists)
            {
                String name = user.m_strFirstName + " " + user.m_strLastName;
                if (name.Equals(appointmentDentistName))
                {
                    appointmentDentist = user;
                }
            }
            String appointmentDescription = ScheduleDescriptionTextBox.Text.ToString();

            //store appointment in database
            int responseCode = DataAccessClass.createAppointment(DateTime.Parse(appointmentDate + appointmentTime),
                        m_strUserName,
                        appointmentDentist.m_strUsername,
                        AppointmentTypeComboBox.Text.ToString(),
                        appointmentDescription,
                        DateTime.Now);

            ErrorMessageLabel.Visible = true;
            ErrorMessageLabel.ForeColor = System.Drawing.Color.Red;
            switch (responseCode)
            {
                case -1:
                    ErrorMessageLabel.Text = "The selected appointment is in the past";
                    break;
                case -2:
                    ErrorMessageLabel.Text = "The office is closed that day";
                    break;
                case -3:
                    ErrorMessageLabel.Text = "The office is open that day, but not during that time";
                    break;
                case -4:
                    ErrorMessageLabel.Text = "You already have an appointment during that time";
                    break;
                case -5:
                    ErrorMessageLabel.Text = "The worker you selected is not available at that time";
                    break;
                case -6:
                    ErrorMessageLabel.Text = "Appoitments must be scheduled at least 24 hours in advance";
                    break;
                default:
                    break;
            }

            if(responseCode == 1)
            {
                ErrorMessageLabel.ForeColor = System.Drawing.Color.Green;
                ErrorMessageLabel.Text = "Your appointment has been created";

                AppointmentTypeComboBox.Visible = false;
                AppointmentTypeComboBox.Text = "Select Appointment Type";

                PickTimeComboBox.Visible = false;
                PickTimeComboBox.Text = "Select Appointment Time";

                DentistHygeinistComboBox.Visible = false;
                DentistHygeinistComboBox.Text = "Select Dentist/Hygeinist";

                dateTimePicker1.Visible = false;
                dateTimePicker1.Value = DateTime.Today;

                ScheduleDescriptionTextBox.Visible = false;
                ScheduleDescriptionTextBox.Text = "Description of Appointment";

                AppointmentConfirmationPanel.Visible = false;

                ListViewItem item = new ListViewItem("New Appointment");
                item.SubItems.Add(appointmentDate);
                item.SubItems.Add(appointmentTime);
                item.SubItems.Add(appointmentDentistName);
                item.SubItems.Add(appointmentDescription);
                item.ForeColor = Color.LightSkyBlue;
                item.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                AppointmentsList.Items.Add(item);
            }  
        }

        private void DenyConfirmationButton_Click(object sender, EventArgs e)
        {
            AppointmentTypeComboBox.Visible = false;
            AppointmentTypeComboBox.Text = "Select Appointment Type";

            PickTimeComboBox.Visible = false;
            PickTimeComboBox.Text = "Select Appointment Time";

            DentistHygeinistComboBox.Visible = false;
            DentistHygeinistComboBox.Text = "Select Dentist/Hygeinist";

            dateTimePicker1.Visible = false;
            dateTimePicker1.Value = DateTime.Today;

            ScheduleDescriptionTextBox.Visible = false;
            ScheduleDescriptionTextBox.Text = "Description of Appointment";

            AppointmentConfirmationPanel.Visible = false;
        }

        private void AppointmentsList_ItemActivate(object sender, EventArgs e)
        {
            ErrorMessageLabel.Visible = false;
            ListViewItem.ListViewSubItemCollection items = AppointmentsList.FocusedItem.SubItems;

            String date = items[1].Text.ToString();
            String time = items[2].Text.ToString();
            String dentist = items[3].Text.ToString();
            String description = items[4].Text.ToString();
            
            UserClass appointmentDentist = null;
            foreach (UserClass user in m_lstDentistsHygeinists)
            {
                String name = user.m_strFirstName + " " + user.m_strLastName;
                if (name.Equals(dentist))
                {
                    appointmentDentist = user;
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append(AppointmentsList.FocusedItem.Text.ToString());
            sb.Append($"\nDate of Appointment: {date}");
            sb.Append($"\nTime of Appointment: {time}");
            
            if (appointmentDentist.m_chrUserType[0] == 'H')
            {
                sb.Append("\nYour Hygeinist: ");
            } 
            else
            {
                sb.Append("\nYour Dentist: ");
            }
            sb.Append($"{dentist} \nDescription: ");
            sb.Append(description);
            AppointmentDetailsLabel.Text = sb.ToString();
            AppointmentDetailsPanel.Visible = true;
        }

        private void ScheduleDescriptionTextBox_Click(object sender, EventArgs e)
        {
            ScheduleDescriptionTextBox.Clear();
            ScheduleDescriptionTextBox.ForeColor = Color.Aqua;
        }

        private void PatientHomeLogoutLabel_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            Close();
        }

        private void CloseAppointmentDetailsButton_Click(object sender, EventArgs e)
        {
            AppointmentDetailsPanel.Visible = false;
            ConfirmCancelAppointmentPanel.Visible = false;
        }

        private void CancelAppointmentButton_Click(object sender, EventArgs e)
        {
            ConfirmCancelAppointmentPanel.Visible = true;
        }

        private void DenyCancelAppointmentButton_Click(object sender, EventArgs e)
        {
            ConfirmCancelAppointmentPanel.Visible = false;
        }

        private void ConfirmCancelAppointmentButton_Click(object sender, EventArgs e)
        {

        }
    }
}
