using Dapper;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataAccessLibrary.Tools;

namespace DataAccessLibrary.DataAccess
{
    public class CurrentUserDataAccess
    {
        public static string loggedUserName;
        public static string loggedUserRole;

        public void GetLoggedUser()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "select * from dbo.Loggedusers";

                var users = cnn.Query<LoggedUserModel>(sql);

                foreach (var user in users)
                {
                    loggedUserName = user.UserName;
                    loggedUserRole = user.UserRole;
                }
            }
        }
    }
}
