using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    public static class Collecter
    {
        private static List<Data> data = new List<Data>();
        public static void Prepair()
        {
            Console.WriteLine("Start collecting data...");
            CollectData();
        }

        public static Data[] GetData()
        {
            return data.ToArray();
        }

        private async static void CollectData()
        {
            User[] activeUsers = AdapterController.GetActiveUsers();
            await Task.Run(() =>
            {
                foreach (var user in activeUsers)
                {
                    data.Add(user.data);
                }
            });
            Console.WriteLine("Data collected success!");
        }
    }
}
