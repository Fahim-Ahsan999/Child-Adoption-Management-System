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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f22 = new Form2();
            f22.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string currentPassword = textBox2.Text;  // Current password
            string newPassword = textBox3.Text;  // New password
            string reNewPassword = textBox4.Text;  // Re-enter new password

            // First, validate the inputs
            if (string.IsNullOrEmpty(currentPassword) || string.IsNullOrEmpty(newPassword) || string.IsNullOrEmpty(reNewPassword))
            {
                MessageBox.Show("Please Fill In All Fields");
                return;
            }

            // Check if new password and re-entered password match
            if (newPassword != reNewPassword)
            {
                MessageBox.Show("New Password and Re-entered Password Do Not Match.");
                return;
            }

            // Proceed to check the current password from the database and update
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\fahim\Documents\CAMA02DB01.mdf;Integrated Security=True;Connect Timeout=30"))
            {
                try
                {
                    con.Open();

                    // Query to check if the current password is correct for the user (assuming you identify users in a different way)
                    string query = "SELECT COUNT(1) FROM ListClient WHERE [Password] = @CurrentPassword";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                    // Check if the current password is correct
                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 1)
                    {
                        // Current password is correct, now update with the new password
                        SqlCommand updateCmd = new SqlCommand("UPDATE ListClient SET [Password] = @NewPassword WHERE [Password] = @CurrentPassword", con);
                        updateCmd.Parameters.AddWithValue("@NewPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@CurrentPassword", currentPassword);

                        // Execute the update
                        updateCmd.ExecuteNonQuery();
                        MessageBox.Show("Password Updated Successfully!");
                    }
                    else
                    {
                        // Current password is incorrect
                        MessageBox.Show("Current Password Is Incorrect.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle any errors that occur
                    MessageBox.Show("An Error Occurred: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }


        }
        }
    }
