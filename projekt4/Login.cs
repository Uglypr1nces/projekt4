using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt4
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            panel3.Visible = false;
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
            else if (true)
            {
                //check if username is available

            }
             else
            {
                //add user to the databank

            }
        }
    }
}