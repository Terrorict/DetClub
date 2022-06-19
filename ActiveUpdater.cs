using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DetClub
{
    class ActiveUpdater
    {
        public static void MakeActive()
        {
            DataBase DB = new DataBase();
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET isActive = '1', lastAction = NOW() WHERE ID = '" + Variables.User.ID + "'", Variables.Connection);
            DB.ExecuteCommand(cmd);
        }

        public static void MakeInactive()
        {
            DataBase DB = new DataBase();
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET isActive = '0', WHERE ID = '" + Variables.User.ID + "'", Variables.Connection);
            DB.ExecuteCommand(cmd);
        }
    }
}
