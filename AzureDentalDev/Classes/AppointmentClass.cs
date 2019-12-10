/**
 * 
 * This class allows organization of appointment data
 * 
 * @author Austin Stalsberg
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class AppointmentClass
    {
        public DateTime m_dtDateTime = DateTime.Now;
        public String m_strPatientName = String.Empty;
        public String m_strDentistName = String.Empty;
        public String m_strAppointmentType = String.Empty;
        public String m_strDescription = String.Empty;
        public DateTime m_dtCreatedDate = DateTime.Now;
        public System.Data.SqlTypes.SqlChars m_chrStatus;


        public AppointmentClass(String strPatientName,
                        String strDentistName,
                        String strAppointmentType,
                        String strDescription,
                        DateTime dtCreatedDate,
                        DateTime dtDateTime,
                        System.Data.SqlTypes.SqlChars chrStatus)
        {
            m_strPatientName = strPatientName;
            m_strDentistName = strDentistName;
            m_strAppointmentType = strAppointmentType;
            m_strDescription = strDescription;
            m_dtCreatedDate = dtCreatedDate;
            m_dtDateTime = dtDateTime;
            m_chrStatus = chrStatus;
        }

    }
}
