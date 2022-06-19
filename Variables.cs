using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetClub
{
    class Variables
    {
        public static CurrentUser User = new CurrentUser();
        public static MySqlConnection Connection;
        public static string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"DetClub\Server");
    }
}
