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
            UserClass ucDoctorUser = BusinessLogicClass.QueryDatabaseForUser(strUserName, strPassword);
            DoctorHomeFormWelcomeLabel.Text = $"Welcome Dr. {ucDoctorUser.m_strFirstName} {ucDoctorUser.m_strLastName}";

            List<AppointmentClass> lstAppointments = DataAccessClass.getAppointmentsWithDentistName(strUserName);

            int i = 1;
            foreach(AppointmentClass appointment in lstAppointments)
            {

                ListViewItem item = new ListViewItem("Appointment " + i);
                item.SubItems.Add(appointment.m_dtDateTime.Date.ToShortDateString());
                item.SubItems.Add(appointment.m_dtDateTime.TimeOfDay.ToString());
                item.SubItems.Add(appointment.m_strPatientName);
                item.SubItems.Add(appointment.m_strDescription);
                item.ForeColor = Color.LightSkyBlue;
                item.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                DoctorAppointmentListView.Items.Add(item);
                i++;

            }
        }

        private void DoctorHomeForm_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void DoctorHomeFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
    }
}
