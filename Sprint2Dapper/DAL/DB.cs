using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sprint2Dapper
{
    public class DB
    {
        public static IDbConnection db = new SqlConnection(@"Data Source=DESKTOP-K9BB333\SQLEXPRESS;Initial Catalog=Sprint2DB;Integrated Security=True");
    }
}
