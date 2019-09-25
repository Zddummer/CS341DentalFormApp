using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class UserClass
    {
        public String m_strUsername = String.Empty;
        public String m_strPassword = String.Empty;
        public String m_strFirstName = String.Empty;
        public String m_strLastName = String.Empty;
        public System.Data.SqlTypes.SqlChars m_chrUserType;
        public System.Data.SqlTypes.SqlChars m_chrAccessType;

        public UserClass(String strUserName, 
                         String strPassword,
                         String strFirstName,
                         String strLastName,
                         System.Data.SqlTypes.SqlChars chrUserType,
                         System.Data.SqlTypes.SqlChars chrAccessType) {

            m_strUsername = strUserName;
            m_strPassword = strPassword;
            m_strFirstName = strFirstName;
            m_strLastName = strLastName;
            m_chrUserType = chrUserType;
            m_chrAccessType = chrAccessType;
        }
    }
}
