using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetClub
{
    class DataBase
    {
    }

    public boll ExecuteCommand(MySqlCommand command)
    {
        bool bl = true;
        try
        {
            Variables.Connection.Open();
            command.ExecuteNonQuery();
        }
        catch (Exception x) {MessageBox }
    }
}
