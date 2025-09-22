using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Hotel_Management
{
     class Connection
    {
        private string stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\USERS\ADMIN\SOURCE\REPOS\HOTEL MANAGEMENT\HOTEL MANAGEMENT\Database1.mdf;Integrated Security=True;Connect Timeout=30";
        public SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
