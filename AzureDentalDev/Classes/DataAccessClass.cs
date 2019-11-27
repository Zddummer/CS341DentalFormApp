using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace AzureDentalDev.Classes
{
    class DataAccessClass
    {
        /**
         * Creates an SqlConnection with the credentials for the company's database
         * 
         * returns: SqlConnection
         */
        private static SqlConnection getConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "cs341azuredb.database.windows.net";
            builder.UserID = "adminonly";
            builder.Password = "CS341dbNULL";
            builder.InitialCatalog = "DentalDev";

            return new SqlConnection(builder.ConnectionString);
        }

        // FOR DEVELOPMENT ONLY, DO NOT USE!!!
        private static void HashPasswords()
        {
            using (SqlConnection connection = getConnection())
            {
                // convert string to stream
                byte[] byteArray = Encoding.UTF8.GetBytes("password1");
                //byte[] byteArray = Encoding.ASCII.GetBytes(contents);
                MemoryStream stream = new MemoryStream(byteArray);

                var sha1 = new SHA1CryptoServiceProvider();
                var sha1data = sha1.ComputeHash(stream);
                String strPassword = System.Text.Encoding.Default.GetString(sha1data);

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"Update Users SET password = '{strPassword}' ");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    int intNumberOfRowsAffected = command.ExecuteNonQuery();
                    if (intNumberOfRowsAffected > 0)
                    {
                        
                    }
                }
            }
        }

        /**
         * Uses and in-line SQL statement to create a UserClass object with a given
         * Username and password
         * 
         * parameters: String Username, String Password
         * returns: UserClass object
         */
        public static UserClass QueryDatabaseForUser(String strUserName, String strPassword)
        {
            UserClass ucReturnUser = null;
            String strReturnUserName;
            String strReturnPassword;
            String strFirstName;
            String strLastName;
            System.Data.SqlTypes.SqlChars chrUserType;
            System.Data.SqlTypes.SqlChars chrAccessType;

            using (SqlConnection connection = getConnection())
            {
                
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TOP 1 * ");
                sb.Append("FROM Users U ");
                sb.Append($"WHERE U.Username = '{strUserName}' ");
                sb.Append($"AND U.Password = '{strPassword}' ");
                sb.Append("AND U.AccessType = 'A'");
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

        public static UserClass QueryDatabaseForUser(String strUserName)
        {
            UserClass ucReturnUser = null;
            String strReturnUserName;
            String strReturnPassword;
            String strFirstName;
            String strLastName;
            System.Data.SqlTypes.SqlChars chrUserType;
            System.Data.SqlTypes.SqlChars chrAccessType;

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TOP 1 * ");
                sb.Append("FROM Users U ");
                sb.Append($"WHERE U.Username = '{strUserName}' ");
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


        public static OfficeHoursClass QueryDatabaseForOfficeHours(DateTime dtAppointmentDate)
        {
            OfficeHoursClass ohcReturnOfficeHours = null;
            String strReturnDayOfWeek;
            DateTime dtDate;
            TimeSpan dtTimeOpen;
            TimeSpan dtTimeClose;
            System.Data.SqlTypes.SqlChars chrStatus;


            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT TOP 1 * ");
                sb.Append("FROM OfficeHours O ");
                sb.Append($"WHERE O.Date = '{dtAppointmentDate}' ");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            strReturnDayOfWeek = reader.GetString(0);
                            dtDate = reader.GetDateTime(1);
                            dtTimeOpen = reader.GetTimeSpan(2);
                            dtTimeClose = reader.GetTimeSpan(3);
                            chrStatus = reader.GetSqlChars(4);

                            ohcReturnOfficeHours = new OfficeHoursClass(strReturnDayOfWeek,
                                                         dtDate,
                                                         dtTimeOpen,
                                                         dtTimeClose,
                                                         chrStatus);
                            return ohcReturnOfficeHours;
                        }
                    }
                }
            }
            return ohcReturnOfficeHours;

        }

        /**
         * Overloaded method which registers a user as a patient
         * 
         * parameters: String FirstName, String LastName, String UserName, String Password
         * returns: Boolean
         */
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

        /**
         * Base overloaded method which registers a user according to the Usertype passed in
         * 
         * parameters: String FirstName, String LastName, String UserName, String Password, String UserType
         * returns: Boolean
         */
        public static Boolean registerNewUser(String strFirstName,
                                              String strLastName,
                                              String strUserName,
                                              String strPassword,
                                              String chrUserType)
        {
            Boolean blnWasUserCreated = false;
            int intNumberOfRowsAffected = 0;

            using (SqlConnection connection = getConnection())
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

        public static Boolean deleteUser(String strUserName)
        {
            Boolean blnWasUserDeleted = false;
            int intNumberOfRowsAffected = 0;

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"UPDATE Users SET accessType = 'D' WHERE userName = '{strUserName}' AND accessType = 'A'");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWasUserDeleted = true;
                        deleteAllAppointmentsWhenUserIsDeleted(strUserName);
                    }
                }
            }

            return blnWasUserDeleted;
        }

        private static void deleteAllAppointmentsWhenUserIsDeleted(String strUserName)
        {
            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"UPDATE Appointments SET Status = 'C' WHERE (CustomerName = '{strUserName}' OR DentistName = '{strUserName}') AND Status = 'A'");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
        }

        public static Boolean activateUser(String strUserName)
        {
            Boolean blnWasUserActivated = false;
            int intNumberOfRowsAffected = 0;

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"UPDATE Users SET accessType = 'A' WHERE userName = '{strUserName}' AND accessType = 'D'");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWasUserActivated = true;
                    }
                }
            }

            return blnWasUserActivated;
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
                sb.Append("AND(Status = 'A' OR Status = 'C')");
                sb.Append("ORDER BY AppointmentDate");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (reader.GetDateTime(5) < DateTime.Now && reader.GetSqlChars(6)[0] != 'I')
                            {
                                updateAppointmentStatus(new AppointmentClass(reader.GetString(0),
                                                                    reader.GetString(1),
                                                                    reader.GetString(2),
                                                                    reader.GetString(3),
                                                                    reader.GetDateTime(4),
                                                                    reader.GetDateTime(5),
                                                                    reader.GetSqlChars(6)), 'I');
                            }
                            else if (reader.GetSqlChars(6)[0] != 'I')
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
                            if (reader.GetDateTime(5) < DateTime.Now && reader.GetSqlChars(6)[0] != 'I')
                            {
                                updateAppointmentStatus(new AppointmentClass(reader.GetString(0),
                                                                    reader.GetString(1),
                                                                    reader.GetString(2),
                                                                    reader.GetString(3),
                                                                    reader.GetDateTime(4),
                                                                    reader.GetDateTime(5),
                                                                    reader.GetSqlChars(6)), 'I');
                            }
                            else if (reader.GetSqlChars(6)[0] != 'I')
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
            }

            return appointments;
        }

        /*
         * Returns an integer corresponding to success or failure of appointment creation
         * 1 = appointment added successfully
         * -1 = the given appointment date is in the past
         * -2 = The office is closed that day
         * -3 = the office is open that day but closed during that time
         * -4 = You already have an appointment during that time
         * -5 = The requested dentist is unavailable
         * -6 = The appointment was within 24 hours of createdDate
         */
        public static int createAppointment(DateTime dtDateTime,
                        String strPatientUserName,
                        String strDentistUserName,
                        String strAppointmentType,
                        String strDescription,
                        DateTime dtCreatedDate)
        {
            //Error checking for scheduling in the past
            if(dtDateTime < DateTime.Now)
            {
                return -1;
            }

            //Error checking for scheduling not during Office hours
            OfficeHoursClass ohcDayOfAppointment = QueryDatabaseForOfficeHours(dtDateTime);
            
            if(ohcDayOfAppointment == null)
            {
                return -2;
            }

            //Error checking for scheduling during a time when the office is closed
            /*
            if (dtDateTime < ohcDayOfAppointment.m_dtOpenTime || dtDateTime > ohcDayOfAppointment.m_dtCloseTime)
            {
                return -3;
            }
            */

            //Error checking for if patient has another appointment at that time
            List<AppointmentClass> lsacPatientAppts = getAppointmentsWithCustomerName(strPatientUserName);
            foreach(AppointmentClass appointment in lsacPatientAppts)
            {
                if(appointment.m_dtDateTime == dtDateTime)
                {
                    return -4;
                }
            }

            //Error checking for if the dentist has another appointment at that time
            List<AppointmentClass> lsacDentistAppts = getAppointmentsWithDentistName(strDentistUserName);
            foreach (AppointmentClass appointment in lsacDentistAppts)
            {
                if (appointment.m_dtDateTime == dtDateTime && appointment.m_chrStatus[0] == 'A')
                {
                    return -5;
                }
            }


            //error checking for if appointment is being scheduled for within the next 24 hours
            if (dtDateTime < DateTimeOffset.Now.AddDays(1))
            {
                return -6;
            }


            //validate appointment time (make Office Hours class and query database for hours info)
            using (SqlConnection connection = getConnection())
            {
                connection.Open();
                String sql = "";
                SqlCommand command = new SqlCommand(sql, connection);
            }
            
            //add appointment to database
            Boolean blnWasAppointmentCreated = false;
            int intNumberOfRowsAffected = 0;

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                
                sb.Append("Insert into Appointments Values(");
                sb.Append($"'{strPatientUserName}', ");
                sb.Append($"'{strDentistUserName}', ");
                sb.Append($"'{strAppointmentType}', ");
                sb.Append($"'{strDescription}', ");
                sb.Append($"'{dtCreatedDate}', ");
                sb.Append($"'{dtDateTime}', 'A')");
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
            if (blnWasAppointmentCreated)
            {
                return 1;
            }
            return -4;
        }

        /**
         * Changes the open hours of the company to the times passed in
         * 
         * parameters: String StartTime, String CloseTime
         * returns: Boolean
         */
        public static Boolean updateOpenOfficeHours(String strStartTime, String strCloseTime)
        {
            Boolean blnWereHoursUpdated = false;
            int intNumberOfRowsAffected = 0;

            using (SqlConnection connection = getConnection())
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


        /**
         * Updates the database to show we are closed on a specified day
         * 
         * parameters: String DateToClose
         * returns: Boolean
         */
        public static Boolean closeDay(String strDateToClose)
        {
            Boolean blnWasDayClosed = false;
            int intNumberOfRowsAffected = 0;

            strDateToClose = strDateToClose.Split(' ')[0];

            using (SqlConnection connection = getConnection())
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

        /**
         * Updates the database to show we are open on a specified day
         * 
         * parameters: String DateToOpen
         * returns: Boolean
         */
        public static Boolean openDay(String strDateToOpen)
        {
            Boolean blnWasDayClosed = false;
            int intNumberOfRowsAffected = 0;

            strDateToOpen = strDateToOpen.Split(' ')[0];

            using (SqlConnection connection = getConnection())
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

        public static Boolean updateAppointmentStatus(AppointmentClass apt, char status)
        {
            Boolean blnWasApptUpdated = false;
            int intNumberOfRowsAffected = 0;
            if(status == 'A')
            {
                return false;
            }

            using (SqlConnection connection = getConnection())
            {
                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append($"Update Appointments Set Status = '{status}' Where AppointmentDate = '{apt.m_dtDateTime}' AND CustomerName = '{apt.m_strPatientName}'");
                String sql = sb.ToString();
                using(SqlCommand command = new SqlCommand(sql, connection))
                {
                    intNumberOfRowsAffected = command.ExecuteNonQuery();

                    if (intNumberOfRowsAffected > 0)
                    {
                        blnWasApptUpdated = true;
                    }
                }
                return blnWasApptUpdated;
            }
        }

        public static List<AppointmentClass> getAppointments_Admin(String strUserName, DateTime dtDate)
        {
            List<AppointmentClass> lstAppointmentList = new List<AppointmentClass>();
            DateTime dtDefault = new DateTime(2000, 1, 1);

            using (SqlConnection connection = getConnection())
            {

                connection.Open();
                StringBuilder sb = new StringBuilder();
                sb.Append("SELECT * ");
                sb.Append("FROM Appointments A ");
                sb.Append($"WHERE A.Status <> 'I'");
                if(strUserName != "" && strUserName != "Enter a Username")
                {
                    sb.Append($" AND (A.CustomerName = '{strUserName}' OR A.DentistName = '{strUserName}')");
                }
                if(dtDate != dtDefault)
                {
                    sb.Append($" AND A.AppointmentDate BETWEEN '{dtDate.ToShortDateString()}' AND '{dtDate.ToShortDateString() + " 23:59:59"}'");
                }
                sb.Append(" ORDER BY A.Status, A.AppointmentDate");
                String sql = sb.ToString();

                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lstAppointmentList.Add(new AppointmentClass(reader.GetString(0),
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
            return lstAppointmentList;
        }
    }
}
