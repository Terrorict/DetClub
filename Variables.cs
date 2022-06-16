using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetClub
{
    class Variables
    {
        public static CurrentUser User = CurrentUser();
        public static MySqlConnection Connection;
        public static string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"ChildEntertain\Server");
    }
}
