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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\NoticeClient.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand sq3 = new SqlCommand("delete from NoC where Number=@Id", con);
            sq3.Parameters.AddWithValue("@Id", int.Parse(textBox1.Text));
            sq3.ExecuteNonQuery();

            con.Close(); // Always close the connection after use

            MessageBox.Show("Notification Deleted");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f00139 = new Form9();
            f00139.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 f14001 = new Form14();
            f14001.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
