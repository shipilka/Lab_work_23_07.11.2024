using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_work_23_07._11._2024
{
    public partial class Task3 : Task1
    {
        string _Login = "admin";
        string _Password = "qwerty";

        public Task3()
        {
            InitializeComponent();
        }

        private void Task3_Load(object sender, EventArgs e)
        {
            label1.Text = "Задание №4";
        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (Login.Text == _Login && Password.Text == _Password)
            {
                MessageBox.Show("Вы успешно авторизировались!", "Поздравляем!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Логина не существует и/или неправильный пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
