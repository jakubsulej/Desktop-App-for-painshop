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
    public class JigsDataAccess
    {
        public void SetJigType(int jigNumber, string jigName)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Jignumber", jigNumber);
                p.Add("@Jigname", jigName);

                string sql1 = "Insert into dbo.Jigs values(@Jignumber, @Jigname)";

                var people = cnn.Query<JigModel>(sql1, p);
            }
        }
        public void DeleteJigType(int jigNumber)
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var p = new DynamicParameters();
                p.Add("@Jignumber", jigNumber);

                string sql = "Delete from dbo.Jigs Where JigNumber = @Jignumber";

                cnn.Execute(sql, p);
            }
        }

        public List<JigModel> DisplayJigLabels()
        {
            using (IDbConnection cnn = new SqlConnection(GetConnectionString()))
            {
                var output = cnn.Query<JigModel>("Select * From dbo.Jigs").ToList();
                return output;
            }
        }
    }
}
