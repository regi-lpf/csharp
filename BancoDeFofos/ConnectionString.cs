using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDeFofos
{
    internal static class ConnectionString
    {
        private static SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\71888\source\repos\BancoDeFofos\Eucalipto.mdf;Integrated Security=True");

        public static SqlConnection Conn { get => conn; private set => conn = value; }
    }
}
