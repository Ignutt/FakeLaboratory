using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    public static class AdapterController
    {
        public static User[] GetActiveUsers()
        {
            return new User[10];
        }
    }
}
