using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratory1
{
    public partial class Form1 : Form
    {
        public static Form1 instatance;

        public delegate void OnTableInitialize();
        public delegate void OnTableUpdate();

        public OnTableInitialize onTableInitialize;

        public Vector GetSize() => new Vector(500, 500);

        public Form1()
        {
            instatance = this;

            InitializeComponent();
            onTableInitialize += SaveManager.SaveTable;
            onTableInitialize += MessageManager.SendSuccessMessage;
        }

        private void CollectData()
        {
            Collecter.Prepair();
            Data[] data = Collecter.GetData();

            InitializeTable(data);
        }

        private void InitializeTable(Data[] data)
        {
            int currentIndex = 0;
            foreach (var line in Table.instance.content)
            {
                foreach (var elem in line)
                {
                    elem.content = Utils.DataToString(data[currentIndex]);
                }
            }

            onTableInitialize.Invoke();
        }

        private void UpdateTable()
        {
            CleanUp();
            CollectData();
        }

        private void CleanUp()
        {
            foreach (var line in Table.instance.content)
            {
                foreach (var elem in line)
                {
                    elem.content = "";
                }
            }
        }

        private void UpdateTableButton_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void LaunchButton_Click(object sender, EventArgs e)
        {
            CollectData();
        }

        private void CleanUpButton_Click(object sender, EventArgs e)
        {
            CleanUp();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CleanUp();
            SaveManager.CheckSaves();
        }

        private void Form1_Scroll(object sender, ScrollEventArgs e)
        {
            Table.instance.CheckSize();
        }
    }

}
