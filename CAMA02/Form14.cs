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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f14440 = new Form4();
            f14440.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Form14_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\NoticeClient.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();

            SqlCommand sq1 = new SqlCommand("select * from NoC", con);
            DataTable dt = new DataTable();

            SqlDataReader sdr = sq1.ExecuteReader();
            dt.Load(sdr);

            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 f0879 = new Form13();
            f0879.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
