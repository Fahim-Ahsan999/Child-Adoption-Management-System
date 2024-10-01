using CAMA02.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CAMA02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f9891 = new Form1();
            f9891.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form16 f16 = new Form16();
            f16.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
