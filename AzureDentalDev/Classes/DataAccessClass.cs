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
    }
}
