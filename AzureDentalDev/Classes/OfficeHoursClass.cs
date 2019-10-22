using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class OfficeHoursClass
    {
        public string m_strDayOfWeek;
        //public System.Data.SqlTypes.SqlDateTime m_date;
        public DateTime m_dtdate;
        public TimeSpan m_dtOpenTime;
        public TimeSpan m_dtCloseTime;
        public System.Data.SqlTypes.SqlChars m_chrStatus;

        public OfficeHoursClass(String dayOfTheWeek,
                                    DateTime date,
                                    TimeSpan openTime,
                                    TimeSpan closeTime,
                                    System.Data.SqlTypes.SqlChars status)
        {
            m_strDayOfWeek = dayOfTheWeek;
            m_dtdate = date;
            m_dtOpenTime = openTime;
            m_dtCloseTime = closeTime;
            m_chrStatus = status;
        }
    }
}
