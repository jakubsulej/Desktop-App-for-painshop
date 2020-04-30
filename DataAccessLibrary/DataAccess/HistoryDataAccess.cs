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
    public class HistoryDataAccess
    {
        public string userName;
        public string currentDate = DateTime.Now.ToShortDateString();

        public List<HistoryModel> GetHistory()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var output = cnn.Query<HistoryModel>("Select * From dbo.History").ToList();
                return output;
            }
        }

        public void GetLoggedUser()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string sql = "select * from dbo.Loggedusers";

                var people = cnn.Query<LoggedUserModel>(sql);

                foreach (var person in people)
                {
                    userName = person.UserName;
                }
            }
        }
        public void AddCoatData(string coatQuantity, string coatFinishTime, string coatType)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@CoatQuantity", coatQuantity);
                p.Add("@CoatTime", coatFinishTime);
                p.Add("@User", userName);
                p.Add("@CoatType", coatType);
                p.Add("@CoatDate", currentDate);

                string sql = "insert into dbo.History ([CoatQuantity], [CoatTime], [User], [CoatType], [CoatDate]) values(@CoatQuantity, @CoatTime, @User, @CoatType, @CoatDate)";

                cnn.Execute(sql, p);
            }
        }

        public void DeleteCoatData(string date, string coat, string user, string hour)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@CoatDate", date.Trim());
                p.Add("@CoatType", coat.Trim());
                p.Add("@User", user.Trim());
                p.Add("@CoatTime", hour.Trim());


                string sql = "Delete from dbo.History Where CoatTime=@CoatTime And CoatDate=@CoatDate";
                
                cnn.Execute(sql, p);
            }
        }

        public void DeleteCoatData7Days()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                string today = DateTime.Today.ToShortDateString();

                string sevenDaysAgo = DateTime.Today.AddDays(-7).ToShortDateString();

                string sql = $"Delete from dbo.History Where CoatDate Between '{today}' AND '{sevenDaysAgo}'";

                cnn.Execute(sql);
            }
        }
    }
}
