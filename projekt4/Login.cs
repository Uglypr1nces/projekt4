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
        public form1()
        {
            InitializeComponent();
        }

        private bool UserExists(string filePath, string username, string password)
        {
            try
            {
                var lines = File.ReadLines(filePath);

                foreach (var line in lines.Skip(1))
                {
                    var values = line.Split(',');

                    string existingUsername = values[0].Trim();
                    string existingPassword = values[1].Trim();

                    if (existingUsername == username && existingPassword == password)
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the CSV file: {ex.Message}");
                return false;
            }
        }

        private bool adduser(string filePath, string username, string password)
        {
            try
            {
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine($"{username},{password}");
                }

                MessageBox.Show("User added successfully.");

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while reading the CSV file: {ex.Message}");
                return false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newusername = textBox2.Text;
            string newpassword = textBox3.Text;

            if (adduser("C:\\Users\\aqua\\source\\repos\\projekt4\\projekt4\\databank\\users.csv", newusername, newpassword))
            {
                MessageBox.Show("user added!");
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
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
                    string dataFilePath = Path.Combine(@"C:\Users\aqua\source\repos\projekt4\projekt4\databank\users.csv");
                    if (File.Exists(dataFilePath))
                    {
                        if (UserExists(dataFilePath, newusername, newpassword))
                        {
                            MessageBox.Show("Login successful!");
                            ToDoApp mainform = new ToDoApp();
                            mainform.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("CSV file not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}