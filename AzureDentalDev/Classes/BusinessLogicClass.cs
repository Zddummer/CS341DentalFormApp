/**
 * This class acts as the business logic layer for the company's application
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class BusinessLogicClass
    {
        public static UserClass QueryDatabaseForUser(String strUserName, String strPassword)
        {
            strPassword = strPassword.GetHashCode().ToString();

            return DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);
        }

        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword)
        {
            strPassword = strPassword.GetHashCode().ToString();

            return DataAccessClass.registerNewUser(strFirstName,
                                                   strLastName,
                                                   strUserName,
                                                   strPassword);
        }

        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword,
                                              String chrUserType)
        {
            strPassword = strPassword.GetHashCode().ToString();

            return DataAccessClass.registerNewUser(strFirstName,
                                                   strLastName,
                                                   strUserName,
                                                   strPassword,
                                                   chrUserType);
        }
    }
}
