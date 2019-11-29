/**
 * This class acts as the business logic layer for the company's application.
 * It passes information between the UI layer and Data Access Layer, applying
 * business logic during the process
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AzureDentalDev.Classes
{
    class BusinessLogicClass
    {

        // Hashes passwords before passing information along to the Data Access Layer
        public static UserClass QueryDatabaseForUser(String strUserName, String strPassword)
        {
            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strPassword);
            MemoryStream stream = new MemoryStream(byteArray);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(stream);
            strPassword = System.Text.Encoding.Default.GetString(sha1data);

            return DataAccessClass.QueryDatabaseForUser(strUserName, strPassword);
        }

        // Hashes passwords before passing information along to the Data Access Layer
        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword)
        {


            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strPassword);
            MemoryStream stream = new MemoryStream(byteArray);

            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(stream);
            strPassword = System.Text.Encoding.Default.GetString(sha1data);

            return DataAccessClass.registerNewUser(strFirstName,
                                                   strLastName,
                                                   strUserName,
                                                   strPassword);
        }

        // Hashes passwords before passing information along to the Data Access Layer
        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword,
                                              String chrUserType)
        {
            // convert string to stream
            byte[] byteArray = Encoding.UTF8.GetBytes(strPassword);
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
