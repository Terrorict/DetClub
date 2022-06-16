using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetClub
{
    class CurrentUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Login { get; set; }
        public string Role { get; set; }

    public void Clear()
    {
        ID = 0;
        Name = "";
        Login = "";
        Role = "";
    }

        public void Fill(int id, string name, string login, string role)
        {
            ID = id;
            Name = name;
            Login = login;
            Role = role;
        }

    }

}
