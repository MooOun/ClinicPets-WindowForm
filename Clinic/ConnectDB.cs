using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ProjectMiniZoo
{
    internal class ConnectDB
    {
        public SqlConnection SqlStrCon()
        {
            return new SqlConnection(@"Data Source=.\SQLEXPRESS;" +
                                      "Initial Catalog=Clinic106;" +
                                      "Integrated Security=SSPI;");

        }
    }
}
