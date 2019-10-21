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
        List<UserClass> m_lstDentistsHygeinists = new List<UserClass>();

        public PatientHomeForm(String strUserName, String strPassword)
        {
            InitializeComponent();
            //Add user's first and last name to welcome label
            UserClass ucUser = DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);
            PatientHomeFormWelcome.Text = $"Welcome {ucUser.m_strFirstName} {ucUser.m_strLastName}!";
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
            List<AppointmentClass> lstAppointments = DataAccessClass.getAppointmentsWithCustomerName(strUserName);
            int i = 1;
            foreach(AppointmentClass acAppointment in lstAppointments)
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
                item.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
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


            //store appointment in database


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

        private void DenyConfirmationButton_Click(object sender, EventArgs e)
        {
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
            
            if (appointmentDentist.m_chrUserType.ToString() == "H")
            {
                sb.Append("\nYour Hygeinist: ");
            } 
            else
            {
                sb.Append("\nYour Dentist: ");
            }
            sb.Append($"{dentist} \nDescription: ");
            sb.Append(description);
            MessageBox.Show(sb.ToString());
        }
    }
}
