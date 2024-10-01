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

namespace CAMA02
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f440984 = new Form4();
            f440984.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 f0986 = new Form6();
            f0986.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\CAMA02DB01.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand sq3 = new SqlCommand("delete from ListClient where id=@Id", con);
            sq3.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            sq3.ExecuteNonQuery();

            con.Close(); // Always close the connection after use

            MessageBox.Show("This User Is Deleted");

            // Refresh DataGridView after delete
            //button1_Click(sender, e);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
