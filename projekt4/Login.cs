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
                ToDoApp mainform= new ToDoApp();
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
    }
}

