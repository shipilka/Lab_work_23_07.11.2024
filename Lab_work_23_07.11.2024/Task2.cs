using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace Lab_work_23_07._11._2024
{
    public partial class Task2 : Task1
    {
        public Task2()
        {
            InitializeComponent();
        }

        private void Task2_Load(object sender, EventArgs e)
        {
            label1.Text = "Задание №3";
            label2.Text = DateTime.Now.ToShortDateString();
        }



        

    }
}
