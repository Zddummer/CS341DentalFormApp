using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class AppointmentClass
    {
        public DateTime m_dateTime = DateTime.Now;
        public String m_strPatientName = String.Empty;
        public String m_strDentistName = String.Empty;
        public String m_strAppointmentType = String.Empty;
        public String m_strDescription = String.Empty;
        public DateTime m_createdDate = DateTime.Now;
        public System.Data.SqlTypes.SqlChars m_chrStatus;


        public AppointmentClass(DateTime dateTime,
                        String strPatientName,
                        String strDentistName,
                        String strAppointmentType,
                        String strDescription,
                        DateTime createdDate,
                        System.Data.SqlTypes.SqlChars chrStatus)
        {
            m_dateTime = dateTime;
            m_strPatientName = strPatientName;
            m_strDentistName = strDentistName;
            m_strAppointmentType = strAppointmentType;
            m_strDescription = strDescription;
            m_createdDate = createdDate;
            m_chrStatus = chrStatus;
        }

    }
}
