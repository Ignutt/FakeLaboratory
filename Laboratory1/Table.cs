using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratory1
{
    public class Cell
    {
        public string content; 
    }
    public class Table
    {
        public static Table instance;
        public List<List<Cell>> content = new List<List<Cell>>();

        public Table()
        {
            instance = this;
        }

        public void CheckSize()
        {
            // TODO
        }
    }

    public static class Utils
    {
        public static string DataToString(Data data)
        {
            return data.device.ToString();
        }
    }

    public class Vector
    {
        public int x;
        public int y;

        public Vector(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
