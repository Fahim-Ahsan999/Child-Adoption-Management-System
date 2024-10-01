using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAMA02
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\CAMA02DB01.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand sq3 = new SqlCommand("UPDATE ListClient SET Password=@Password where id=@Id", con);
            sq3.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            sq3.Parameters.AddWithValue("@Password", textBox2.Text);
            sq3.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("New Password Set To Block");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f6006 = new Form6();
            f6006.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 f7089 = new Form7();
            f7089.Show();
            this.Hide();
        }
    }
}
