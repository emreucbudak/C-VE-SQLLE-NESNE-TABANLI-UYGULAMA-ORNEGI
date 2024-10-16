using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Baglanti
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=emre\MSSQLSERVER01;Initial Catalog=DBPERSONEL;Integrated Security=True;Encrypt=False");
    }
}
