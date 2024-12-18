using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace Lab_work_23_07._11._2024
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime current = DateTime.Now;
            MessageBox.Show("Добро пожаловать!", "Приветствие " + current.ToString(), MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var res = MessageBox.Show("Вы хотите закрыть приложение?", "Закрытие", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            e.Cancel = !(res == DialogResult.Yes);
        }

        private void TaskButton1_Click(object sender, EventArgs e)
        {
            Task1 form = new Task1();
            form.ShowDialog();
        }

        private void TaskButton2_Click(object sender, EventArgs e)
        {
            Task2 form = new Task2();
            form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Task3 form = new Task3();
            form.ShowDialog();
        }
    }
}
