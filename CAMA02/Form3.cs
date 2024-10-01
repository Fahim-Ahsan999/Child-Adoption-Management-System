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
    public partial class Form3 : Form
    {
        private readonly string AdminID = "Admin";
        private readonly string AdminPassword = "Fahim123";
        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f11 = new Form1();
            f11.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string enteredAdminID = textBox1.Text; // Get the entered Admin ID
            string enteredPassword = textBox2.Text; // Get the entered password

            // Validate the credentials
            if (enteredAdminID == AdminID && enteredPassword == AdminPassword)
            {
                MessageBox.Show("Admin login successful!");
                // Here you can open the admin panel or the next form
                // Open Form4 and hide Form1 (the current login form)
                Form4 form4 = new Form4();
                form4.Show();

                // Optionally hide or close the login form (Form1)
                this.Hide(); // To hide the current form
                // Alternatively, you can use `this.Close();` to close Form1 instead of hiding it
            }
            else
            {
                MessageBox.Show("Invalid Admin ID or Password!");
            }
            /*Form4 f4 = new Form4();
            f4.Show();
            this.Hide();*/
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
