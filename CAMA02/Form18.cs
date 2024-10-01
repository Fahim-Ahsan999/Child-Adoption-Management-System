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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the local database (SQL Server LocalDB)
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\FeedBackClient.mdf;Integrated Security=True;Connect Timeout=30";

            // Creating the SQL connection object with the specified connection string
            SqlConnection cooon = new SqlConnection(ConnectionString);

            // Opening the connection to the database
            cooon.Open();

            // SQL command to insert data into the UserTable
            SqlCommand sq3 = new SqlCommand("INSERT INTO FBC (Id, Name, FeedBack) VALUES(@Id, @Name, @FeedBack)", cooon);

            sq3.Parameters.AddWithValue("@Id", textBox1.Text);
            sq3.Parameters.AddWithValue("@Name", textBox2.Text);
            sq3.Parameters.AddWithValue("@FeedBack", textBox3.Text);


            // Executing the SQL command to insert the data into the database
            sq3.ExecuteNonQuery();

            cooon.Close();

            // Displaying a message box to confirm that the user was added successfully
            MessageBox.Show("Feedback Sent");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f981= new Form1();
            f981.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
