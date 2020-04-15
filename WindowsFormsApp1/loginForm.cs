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
    public partial class loginForm : Form
    {
        public loginForm(string login)
        {
            InitializeComponent();   
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string login = loginField.Text;
            string password = passwordField.Text;
            bool teacher = false, student = false;
            using (StreamReader database = new StreamReader("Users/database.txt"))
            {
                if(login == database.ReadLine() && password == database.ReadLine())
                {
                    // 1 - пользователь учитель
                    if(database.ReadLine() == "1")
                    {
                        teacher = true;
                        student = false;
                    }
                    // 2 - пользователь ученик
                    else
                    {
                        student = true;
                        teacher = false;
                    }
                }

                else
                {
                    if (database.EndOfStream)
                    {
                        MessageBox.Show("Error");
                    }
                    else
                    {
                        database.ReadLine();
                    }
                }
                database.Close();
            }

            if (teacher)
            {
                teach tf = new teach(login);
                tf.ShowDialog();
                this.Hide();

            }
           // else
         //   {
               // studentForm sf = new studentForm(login);
                //sf.ShowDialog();
                //this.Hide();
          //  }

        }
    }
}
