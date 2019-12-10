/**
*This form handles functionalities of the hygienist home form.
*When a hygienist logs in, this form will apper
*@Authors Yichu Yang
*/
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
    public partial class HygienistHomeForm : Form
        
    {
        public HygienistHomeForm(String strUserName, String strPassword)
        {           InitializeComponent();
            UserClass ucDoctorUser = BusinessLogicClass.QueryDatabaseForUser(strUserName, strPassword);
            DoctorHomeFormWelcomeLabel.Text = $"Welcome {ucDoctorUser.m_strFirstName} {ucDoctorUser.m_strLastName}";

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
                if (appointment.m_chrStatus[0] == 'C')
                {
                    item.Font = new Font("Arial", 9F, FontStyle.Strikeout, GraphicsUnit.Point, ((byte)(0)));
                }
                else
                {
                    item.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                }
                 DoctorAppointmentListView.Items.Add(item);
                i++;

            }
        }
        //throws error if deleted
        private void DoctorHomeForm_Load(object sender, EventArgs e)
        {

        }
        //throws error if deleted
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        //close the application
        private void DoctorHomeFormCloseButton_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }
        //Send user back to login page if button is clicked
        private void DoctorHomeLogoutLabel_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            Close();
        }
        //Show expanded details for Appointments 
        private void DoctorAppointmentListView_ItemActivate(object sender, EventArgs e)
        {
            
            ListViewItem.ListViewSubItemCollection items = DoctorAppointmentListView.FocusedItem.SubItems;

            String date = items[1].Text.ToString();
            String time = items[2].Text.ToString();
            String patient = items[3].Text.ToString();
            String description = items[4].Text.ToString();

            
            StringBuilder sb = new StringBuilder();
            sb.Append(DoctorAppointmentListView.FocusedItem.Text.ToString());
            sb.Append($"\nDate of Appointment: {date}");
            sb.Append($"\nTime of Appointment: {time}");
            sb.Append("\nPatient: ");
            sb.Append($"{patient} \nDescription: ");
            sb.Append(description);
            MessageBox.Show(sb.ToString());
        }
        //Open Hygienist home page help pdf if help button is clicked
        private void HelpPictureBox_Click(object sender, EventArgs e)
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            path = path.Replace("bin\\Debug", "HelpFiles\\Hygienic_Patient_help.pdf");
            System.Diagnostics.Process.Start(path);
        }
    }
}
