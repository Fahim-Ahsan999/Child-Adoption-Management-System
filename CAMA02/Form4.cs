using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CAMA02
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 ff1 = new Form1();
            ff1.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form15 f15 = new Form15();
            f15.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form14 f14 = new Form14();
            f14.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form19 f181 = new Form19();
            f181.Show();
            this.Hide();
        }
    }
}
