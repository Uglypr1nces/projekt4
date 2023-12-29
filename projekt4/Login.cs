using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace projekt4
{

    public partial class form1 : Form
    {
        private string connectionString;
        public form1()
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", AppDomain.CurrentDomain.BaseDirectory);
            InitializeComponent();
            panel3.Visible = false;
            connectionString = ConfigurationManager.ConnectionStrings["mydatabase"].ConnectionString;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "bob" && txtpassword.Text == "123")
            {
                ToDoApp mainform = new ToDoApp();
                mainform.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("The User name or password you entered is incorrect, try again ");
                txtUserName.Clear();
                txtpassword.Clear();
                txtUserName.Focus();
            }

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
        private void form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Visible = false;
            panel3.Visible = true;
            textBox2.Text = "username";
            textBox3.Text = "password";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newusername = textBox2.Text;
            string newpassword = textBox3.Text;

            if (string.IsNullOrEmpty(newusername) || string.IsNullOrEmpty(newpassword))
            {
                MessageBox.Show("Please put in your username and password");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        // Check if the username is available
                        string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@Username", newusername);

                            int existingUserCount = (int)checkCommand.ExecuteScalar();

                            if (existingUserCount > 0)
                            {
                                MessageBox.Show("Username already exists. Please choose a different one.");
                                return;
                            }
                        }

                        // Add the user to the database
                        string insertQuery = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";

                        using (SqlCommand insertCommand = new SqlCommand(insertQuery, connection))
                        {
                            // Hash the password (using a secure hashing algorithm)
                            // For simplicity, we're storing the plain text password here
                            insertCommand.Parameters.AddWithValue("@Username", newusername);
                            insertCommand.Parameters.AddWithValue("@Password", newpassword);

                            int rowsAffected = insertCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User added successfully!");
                            }
                            else
                            {
                                MessageBox.Show("Failed to add user.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}