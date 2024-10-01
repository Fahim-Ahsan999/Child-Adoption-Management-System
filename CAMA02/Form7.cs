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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\CAMA02DB01.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand sq3 = new SqlCommand("UPDATE ListClient SET Name=@Name , Age=@Age where id=@Id", con);
            sq3.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            sq3.Parameters.AddWithValue("@Name", textBox2.Text);
            sq3.Parameters.AddWithValue("@Age", textBox3.Text);
            sq3.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("User New Information Updated");

            // Refresh DataGridView after update
            //button4_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f4444 = new Form4();
            f4444.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f666 = new Form6();
            f666.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
            this.Hide();
        }
    }
}
