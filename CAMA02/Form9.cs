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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 f44444444 = new Form4();
            f44444444.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the local database (SQL Server LocalDB)
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\NoticeClient.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False";

            // Creating the SQL connection object with the specified connection string
            SqlConnection coon = new SqlConnection(ConnectionString);

            // Opening the connection to the database
            coon.Open();

            // SQL command to insert data into the UserTable
            SqlCommand sq5 = new SqlCommand("INSERT INTO NoC (Number, Date, Notice) VALUES(@Number, @Date, @Notice)", coon);

            sq5.Parameters.AddWithValue("@Number", textBox1.Text);
            sq5.Parameters.AddWithValue("@Date", textBox2.Text);
            sq5.Parameters.AddWithValue("@Notice", textBox3.Text);
            

            // Executing the SQL command to insert the data into the database
            sq5.ExecuteNonQuery();

            coon.Close();

            // Displaying a message box to confirm that the user was added successfully
            MessageBox.Show("Notice Send");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form13 f13 = new Form13();
            f13.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form14 f1498440 = new Form14();
            f1498440.Show();
            this.Hide();
        }
    }
    }
