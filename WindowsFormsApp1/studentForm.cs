using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class studentForm : Form
    {
        public studentForm(string login)
        {
            InitializeComponent();
        }

        private void bprofile_Click(object sender, EventArgs e)
        {
            Form_profile f = new Form_profile();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void bdiary_Click(object sender, EventArgs e)
        {
            Form_diary d = new Form_diary();
            this.Hide();
            d.ShowDialog();
            this.Close();
        }
    }
}
