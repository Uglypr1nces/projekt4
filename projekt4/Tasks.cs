using System;
using System.Windows.Forms;

namespace projekt4
{
    public partial class tasks : Form
    {
        public string TaskName { get; private set; }
        public string Importance { get; private set; }
        public string Date { get; private set; }
        public string Description { get; private set; }

        public tasks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var importance = richTextBox3.Text.ToLower().Trim();

            if (DateTime.TryParse(dateTimePicker2.Text, out _))
            {
                if (importance == "sehr" || importance == "mittel" || importance == "wenig")
                {
                    TaskName = richTextBox1.Text;
                    Importance = importance;
                    Date = dateTimePicker2.Text;
                    Description = richTextBox2.Text;

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Bitte geben sie sehr, mittel oder wenig ein", "fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie ein gültiges Datum ein", "fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Changestuff(string name, string importance, string date, string description)
        {
            richTextBox1.Text = name;
            richTextBox3.Text = importance;

            // Convert the string to a DateTime object
            if (DateTime.TryParse(date, out DateTime parsedDate))
            {
                dateTimePicker2.Value = parsedDate;
            }
            else
            {
                // Handle invalid date format
                MessageBox.Show("Invalid date format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            richTextBox2.Text = description;
        }

    }
}
