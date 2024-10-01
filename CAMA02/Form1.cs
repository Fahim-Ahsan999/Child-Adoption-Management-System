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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CAMA02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            string userID = textBox1.Text;   // ID
            string userPassword = textBox2.Text;   // Password

            // Validate the inputs
            if (string.IsNullOrEmpty(userID) || string.IsNullOrEmpty(userPassword))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            // Proceed to check the user credentials from the database
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\CAMA02DB01.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False"))
            {
                try
                {
                    con.Open();

                    // Query to check if the entered username and password match a record in the database
                    string query = "SELECT * FROM ListClient WHERE Id = @UserId AND Password = @UserPassword";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@UserId", userID);
                    cmd.Parameters.AddWithValue("@UserPassword", userPassword);

                    // Execute the query and check if the credentials match
                      int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count > 0)
                    {
                        // Successful login
                        MessageBox.Show("Login successful!");
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();
                       
                    }
                    else
                    {
                        // Login failed
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }


                /*Form2 f2 = new Form2();
                f2.Show();
                this.Hide();*/


            }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form17 f17 = new Form17();
            f17.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form18 f9018 = new Form18();
            f9018.Show();
            this.Hide();
        }
    }
}
