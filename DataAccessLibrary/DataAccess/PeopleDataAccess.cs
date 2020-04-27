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
    public class PeopleDataAccess
    {
        public static bool errorMessage = false;

        public void AddPerson(string userName, string userPassword, string userRole)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", userName);
                p.Add("@Password", userPassword);
                p.Add("@UserRole", userRole);

                string sql1 = $"Select * from dbo.People Where UserName = '{userName}'";

                var people = cnn.Query<PersonModel>(sql1, p);

                    if (!people.Any())
                    {
                        string sql = "insert into dbo.People (UserName, Password, Role) values(@UserName, @Password, @UserRole)";
                        cnn.Execute(sql, p);
                        errorMessage = false;
                    }
                    else
                    {
                        errorMessage = true;
                    }
            }
        }

        public List<PersonModel> GetPeople()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var output = cnn.Query<PersonModel>("Select * From dbo.People").ToList();
                return output;
            }
        }

        public void UpdatePerson(string userName, string userPassword, string userRole)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", userName);
                p.Add("@Password", userPassword);
                p.Add("@UserRole", userRole);

                string sql = "Update dbo.People set Password=@Password, Role=@UserRole Where UserName=@UserName";
                cnn.Execute(sql, p);
            }
        }

        public void DeletePerson(string userName, string userPassword, string userRole)
        {
            {
                using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
                {
                    var p = new DynamicParameters();
                    p.Add("@UserName", userName);
                    p.Add("@Password", userPassword);
                    p.Add("@UserRole", userRole);

                    string sql = "Delete from dbo.People Where UserName = @UserName";

                    cnn.Execute(sql, p);
                }
            }
        }
    }
}
