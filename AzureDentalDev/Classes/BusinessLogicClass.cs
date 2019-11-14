/**
 * This class acts as the business logic layer for the company's application
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class BusinessLogicClass
    {
        public static UserClass QueryDatabaseForUser(String strUserName, String strPassword)
        {
            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strPassword);
            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(stream);
            strPassword = System.Text.Encoding.Default.GetString(sha1data);

            return DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);
        }

        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword)
        {


            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strPassword);
            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(stream);
            strPassword = System.Text.Encoding.Default.GetString(sha1data);

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
            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strPassword);
            //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
            MemoryStream stream = new MemoryStream(byteArray);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(stream);
            strPassword = System.Text.Encoding.Default.GetString(sha1data);

            return DataAccessClass.registerNewUser(strFirstName,
                                                   strLastName,
                                                   strUserName,
                                                   strPassword,
                                                   chrUserType);
        }
    }
}
