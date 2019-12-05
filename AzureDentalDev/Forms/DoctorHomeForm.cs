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
        private UserClass ucDoctorUser = null;
        public DoctorHomeForm(String strUserName, String strPassword)
        {           InitializeComponent();
            ucDoctorUser = BusinessLogicClass.QueryDatabaseForUser(strUserName, strPassword);
            DoctorHomeFormWelcomeLabel.Text = $"Welcome Dr. {ucDoctorUser.m_strFirstName} {ucDoctorUser.m_strLastName}";
            this.Controls.Add(ConfirmationPanel);
            ConfirmationPanel.Controls.Add(ConfirmationPanelLabel);
            ConfirmationPanel.Controls.Add(ConfirmationPanelNoButton);
            ConfirmationPanel.Controls.Add(ConfirmationPanelYesButton);
            ConfirmationPanel.Controls.Add(ConfirmationPanelError1);
            ConfirmationPanel.Controls.Add(ConfirmationPanelError2);
            ConfirmationPanel.Controls.Add(ConfirmationPanelError3);
            ConfirmationPanel.Visible = false;

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

        private void DoctorHomeLogoutLabel_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Visible = true;
            Close();
        }

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

        private void DoctorHomeFormRequestOffButton_Click(object sender, EventArgs e)
        {
            ConfirmationPanel.BringToFront();
            ConfirmationPanel.Visible = true;
            ConfirmationPanelError1.Visible = false;
            ConfirmationPanelError2.Visible = false;
            ConfirmationPanelError3.Visible = false;

            ConfirmationPanelLabel.Text = $"Are you sure you wish to take {DoctorTimeOffCalendar.SelectionStart.ToShortDateString()} off?";
        }

        private void ConfirmationPanelNoButton_Click(object sender, EventArgs e)
        {
            ConfirmationPanel.Visible = false;
        }

        private void ConfirmationPanelYesButton_Click(object sender, EventArgs e)
        {
            int success = DataAccessClass.requestDayOff_Doctor(DoctorTimeOffCalendar.SelectionStart, ucDoctorUser);
            if(success == -1)
            {
                ConfirmationPanelError1.Visible = true;
            }

            if(success == -2)
            {
                ConfirmationPanelError2.Visible = true;
            }

            if(success == -3)
            {
                ConfirmationPanelError3.Visible = true;
            }

            if(success == 1)
            {
                ConfirmationPanel.Visible = false;
                DoctorAppointmentListView.Invalidate();
            }
        }
    }
}
