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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form12_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2376 = new Form2();
            f2376.Show();
            this.Hide();        }
    }
}
