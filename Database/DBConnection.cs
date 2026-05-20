using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MY_Class_Project.Database
{  
public class DBConnection
    {
        private string connStr = "server=localhost;user id=root;password=@Ahmadishaq@05102005;database=marriage_hall";

        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(connStr);
        }
    }

}
