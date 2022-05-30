using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    [Serializable]
    public class User
    {
        public string ip;
        public Data data;
    }

    [Serializable]
    public class UsersData
    {
        User[] users;
    }
}
