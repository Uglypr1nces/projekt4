namespace projekt4
{
    public partial class tasks : Form
    {
        // Public properties to expose the values
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
            if (importance == "sehr" | importance == "mittel" | importance == "wenig")
            {
                TaskName = richTextBox1.Text;
                Importance = richTextBox3.Text;
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


        public void Changestuff(string name, string importance, string date, string description)
        {
            richTextBox1.Text = name;
            richTextBox3.Text = importance;
            dateTimePicker2.Text = date;
            richTextBox2.Text = description;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
