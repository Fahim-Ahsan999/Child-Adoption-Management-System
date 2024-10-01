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
    public partial class Form17 : Form
    {
        public Form17()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Connection string to connect to the local database (SQL Server LocalDB)
            string ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\CAMA02DB01.mdf;Integrated Security=True;Connect Timeout=30";

            // Creating the SQL connection object with the specified connection string
            SqlConnection con = new SqlConnection(ConnectionString);

            // Opening the connection to the database
            con.Open();

            // SQL command to insert data into the UserTable
            SqlCommand sq2 = new SqlCommand("INSERT INTO ListClient(Id, Name, Age, Password) VALUES(@Id, @Name, @Age, @Password)", con);

            sq2.Parameters.AddWithValue("@Id", textBox1.Text);
            sq2.Parameters.AddWithValue("@Name", textBox2.Text);
            sq2.Parameters.AddWithValue("@Age", int.Parse(textBox3.Text)); // Because age is integer 
            sq2.Parameters.AddWithValue("@Password", textBox4.Text);

            // Executing the SQL command to insert the data into the database
            sq2.ExecuteNonQuery();

            con.Close();

            // Displaying a message box to confirm that the user was added successfully
            MessageBox.Show("Regestration Complited");

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f001 = new Form1();
            f001.Show();
            this.Hide();


         }
    }
}
