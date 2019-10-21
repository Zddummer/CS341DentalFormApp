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
        List<UserClass> m_dentistsHygeinists = new List<UserClass>();

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
                            m_dentistsHygeinists.Add(new UserClass(reader.GetString(0),
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


            //Retrieve and display appointments associated with current user
        }

        private void ClosePatientHomeFormButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void AppointmentsList_MouseClick(object sender, MouseEventArgs e)
        {
            for(int i = 0; i < AppointmentsList.Items.Count; i++)
            {
                var rectangle = AppointmentsList.GetItemRect(i);
                if (rectangle.Contains(e.Location))
                {
                    dateTimePicker1.Visible = true;
                    return;
                }
            }
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
            PickTimeComboBox.Text = String.Empty;

            DentistHygeinistComboBox.Visible = false;
            DentistHygeinistComboBox.Text = String.Empty;

            dateTimePicker1.Visible = false;
            dateTimePicker1.Value = DateTime.Today;

            ScheduleDescriptionTextBox.Visible = false;
            ScheduleDescriptionTextBox.Text = "Description of Appointment";

            AppointmentConfirmationPanel.Visible = false;
        }

        private void DenyConfirmationButton_Click(object sender, EventArgs e)
        {
            PickTimeComboBox.Visible = false;
            PickTimeComboBox.Text = String.Empty;

            DentistHygeinistComboBox.Visible = false;
            DentistHygeinistComboBox.Text = String.Empty;

            dateTimePicker1.Visible = false;
            dateTimePicker1.Value = DateTime.Today;

            ScheduleDescriptionTextBox.Visible = false;
            ScheduleDescriptionTextBox.Text = "Description of Appointment";

            AppointmentConfirmationPanel.Visible = false;
        }
    }
}
