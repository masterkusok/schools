using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class teach : Form
    {
        string loginlog;
        public teach(string login)
        {
            InitializeComponent();
            loginlog = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            create_but.Hide();
            login_label.Show();
            textBox1.Show();
            textBox2.Show();
            pasword_label.Show();
        }

        private void login_label_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pasword_label_Click(object sender, EventArgs e)
        {

        }

        private void teach_Load(object sender, EventArgs e)
        {
            login_label.Hide();
            pasword_label.Hide();
            textBox1.Hide();
            textBox2.Hide();
        }
    }
}
