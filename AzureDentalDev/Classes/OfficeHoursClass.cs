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
        public DateTime m_dtOpenTime;
        public DateTime m_dtCloseTime;
        public System.Data.SqlTypes.SqlChars m_chStatus;

        public OfficeHoursClass(String dayOfTheWeek,
                                    DateTime date,
                                    DateTime openTime,
                                    DateTime closeTime,
                                    System.Data.SqlTypes.SqlChars status)
        {
            m_strDayOfWeek = dayOfTheWeek;
            m_dtdate = date;
            m_dtOpenTime = openTime;
            m_dtCloseTime = closeTime;
            m_chStatus = status;
        }
    }
}
