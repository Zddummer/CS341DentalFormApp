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
                                   "P");
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
        
        public static List<AppointmentClass> getAppointmentsWithCustomerName(String strUserName)
        {
            //get all appointments associated with the given username
            List<AppointmentClass> appointments = new List<AppointmentClass>();

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Appointments ");
                sb.Append($"WHERE CustomerName = '{strUserName}' ");
                sb.Append("ORDER BY AppointmentDate");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add( new AppointmentClass(reader.GetString(0),
                                                         reader.GetString(1),
                                                         reader.GetString(2),
                                                         reader.GetString(3),
                                                         reader.GetDateTime(4),
                                                         reader.GetDateTime(5),
                                                         reader.GetSqlChars(6)));
                        }
                    }
                }
            }

            return appointments;
        }

        public static List<AppointmentClass> getAppointmentsWithDentistName(String strUserName)
        {
            //get all appointments associated with the given username
            List<AppointmentClass> appointments = new List<AppointmentClass>();

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Appointments ");
                sb.Append($"WHERE DentistName = '{strUserName}' ");
                sb.Append("ORDER BY AppointmentDate");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            appointments.Add(new AppointmentClass(reader.GetString(0),
                                                         reader.GetString(1),
                                                         reader.GetString(2),
                                                         reader.GetString(3),
                                                         reader.GetDateTime(4),
                                                         reader.GetDateTime(5),
                                                         reader.GetSqlChars(6)));
                        }
                    }
                }
            }

            return appointments;
        }

        public static Boolean createAppointment(DateTime dtDateTime,
                        String strPatientUserName,
                        String strDentistUserName,
                        String strAppointmentType,
                        String strDescription,
                        DateTime dtCreatedDate,
                        System.Data.SqlTypes.SqlChars status)
        {

            //validate appointment time (make Office Hours class and query database for hours info)
            using (SqlConnection connection = getConnection())
            {
                connection.Open();
                String sql = "";
                SqlCommand command = new SqlCommand(sql, connection);
            }
            if (dtDateTime > DateTimeOffset.Now.AddDays(1))
            {

            }
            //add appointment to database
            Boolean blnWasAppointmentCreated = false;
            int intNumberOfRowsAffected = 0;

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                
                sb.Append("Insert into Appointments Values(");
                sb.Append($"{strPatientUserName}, ");
                sb.Append($"{strDentistUserName}, ");
                sb.Append($"{strAppointmentType}, ");
                sb.Append($"{strDescription}, ");
                sb.Append($"{dtCreatedDate}, ");
                sb.Append($"{dtDateTime}, ");
                sb.Append($"{status})");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWasAppointmentCreated = true;
                    }
                }
            }
            //return whether the add was successful
            return blnWasAppointmentCreated;
        }

        public static Boolean updateOpenOfficeHours(String strStartTime, String strCloseTime)
        {
            Boolean blnWereHoursUpdated = false;
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
                sb.Append($"update OfficeHours Set OpenTime = '{strStartTime}', CloseTime = '{strCloseTime}' Where Status = 'O';");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWereHoursUpdated = true;
                    }
                }
            }

            return blnWereHoursUpdated;
        }

        public static Boolean closeDay(String strDateToClose)
        {
            Boolean blnWasDayClosed = false;
            int intNumberOfRowsAffected = 0;

            strDateToClose = strDateToClose.Split(' ')[0];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"update OfficeHours Set Status = 'C' Where Date = '{strDateToClose}' AND Status = 'O'");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWasDayClosed = true;
                    }
                }
            }

            return blnWasDayClosed;
        }

        public static Boolean openDay(String strDateToOpen)
        {
            Boolean blnWasDayClosed = false;
            int intNumberOfRowsAffected = 0;

            strDateToOpen = strDateToOpen.Split(' ')[0];

            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"update OfficeHours Set Status = 'O' Where Date = '{strDateToOpen}' AND Status = 'C'");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWasDayClosed = true;
                    }
                }
            }

            return blnWasDayClosed;
        }
    }
}
