using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLibrary.Models;
using static DataAccessLibrary.Tools;
using Dapper;

namespace DataAccessLibrary.DataAccess
{
    public class DataAccess
    {
        public static bool loginOutput = false;
        public static bool isCurrentUserLogged;
        public static string loggedUserName;
        public static string loggedUserRole;

        public void CheckCurrentUser()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "select * from dbo.Loggedusers";

                var users = cnn.Query<LoggedUserModel>(sql);

                foreach (var user in users)
                {
                    if (user.UserName != null || user.UserRole != null)
                    {
                        isCurrentUserLogged = true;
                    }
                    else
                    {
                        isCurrentUserLogged = false;
                    }
                }
            }
        }

        public void GetLogin(string userName, string password)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", userName);
                p.Add("@Password", password);

                string sql = "select * from dbo.People where UserName = @UserName and Password = @Password";

                var people = cnn.Query<PersonModel>(sql, p);

                foreach (var person in people)
                {
                    if (userName != null && password != null)
                    {
                        if (person.UserName == userName && person.Password == password)
                        {
                            loggedUserName = person.UserName;
                            loggedUserRole = person.Role;
                            loginOutput = true;
                        }
                        else
                        {
                            loginOutput = false;
                        }
                    }
                    else
                    {
                        loginOutput = false;
                    }
                }
            }
        }

        public void SaveCurrentUser()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", loggedUserName);
                p.Add("@UserRole", loggedUserRole);

                string sql = "insert into dbo.Loggedusers (UserName, UserRole) values (@UserName, @UserRole)";

                cnn.Execute(sql, p);
            }
        }

        public void DeleteOldUser()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "Delete from Loggedusers";

                cnn.Query<LoggedUserModel>(sql);
            }
        }

    }
}
