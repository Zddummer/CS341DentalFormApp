using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureDentalDev.Classes
{
    class DataAccessClass
    {
        private static SqlConnection getConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            return new SqlConnection(builder.ConnectionString);
        }

        public static UserClass QueryDatabaseForUser(String strUserName, String strPassword)
        {
            UserClass ucReturnUser = null;
            String strReturnUserName;
            String strReturnPassword;
            String strFirstName;
            String strLastName;
            System.Data.SqlTypes.SqlChars chrUserType;
            System.Data.SqlTypes.SqlChars chrAccessType;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {
                
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TOP 1 * ");
                sb.Append("FROM Users U ");
                sb.Append($"WHERE U.Username = '{strUserName}' ");
                sb.Append($"AND U.Password = '{strPassword}' ");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            strReturnUserName = reader.GetString(0);
                            strReturnPassword = reader.GetString(1);
                            strFirstName = reader.GetString(2);
                            strLastName = reader.GetString(3);
                            chrUserType = reader.GetSqlChars(4);
                            chrAccessType = reader.GetSqlChars(5);

                            ucReturnUser = new UserClass(strReturnUserName,
                                                         strReturnPassword,
                                                         strFirstName,
                                                         strLastName,
                                                         chrUserType,
                                                         chrAccessType);
                            return ucReturnUser;
                        }
                    }
                }
            }
            return ucReturnUser;

        }

        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword)
        {
            return registerNewUser(strFirstName,
                                   strLastName,
                                   strUserName,
                                   strPassword,
                                   "C");
        }

        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword,
                                              String chrUserType)
        {
            Boolean blnWasUserCreated = false;
            int intNumberOfRowsAffected = 0;

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("Begin ");
                sb.Append("If Not Exists(Select Top 1 * ");
                sb.Append("From Users As U ");
                sb.Append($"Where U.userName = '{strUserName}') ");
                sb.Append("Begin ");
                sb.Append("INSERT INTO Users(userName, password, firstName, lastName, userType, accessType) ");
                sb.Append($"VALUES('{strUserName}', '{strPassword}', '{strFirstName}', '{strLastName}', '{chrUserType}', 'A') ");
                sb.Append("End ");
                sb.Append("End");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if(intNumberOfRowsAffected > 0)
                    {
                        blnWasUserCreated = true;
                    }
                }
            }

            return blnWasUserCreated;
        }
        
        public static List<AppointmentClass> getAppointments(String strUserName)
        {
            //get all appointments associated with the given username
            return new List<AppointmentClass>();
        }

        public static Boolean createAppointment(DateTime dateTime,
                        String strPatientName,
                        String strDentistName,
                        String strAppointmentType,
                        String strDescription,
                        DateTime createdDate,
                        System.Data.SqlTypes.SqlChars status)
        {
            //validate appointment time
            //add appointment to database
            //return whether the add was successful
            return false;
        }
    }
}
