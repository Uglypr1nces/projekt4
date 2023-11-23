using System.Data;

namespace projekt4
{
    public partial class ToDoApp : Form
    {
        public ToDoApp()
        {
            InitializeComponent();
            Tasks goofy = new Tasks("boobo", 12, 14);
            listBox1.Items.Add("Item 1");
            listBox1.Items.Add("Item 2");

            // Assuming listView1 is a ListView control on your form
            listView1.View = View.Details;
            listView1.Columns.Add("Column 1");
            listView1.Columns.Add("Column 2");

            ListViewItem item1 = new ListViewItem("Item 1");
            item1.SubItems.Add("Subitem 1");

            ListViewItem item2 = new ListViewItem("Item 2");
            item2.SubItems.Add("Subitem 2");

            listView1.Items.AddRange(new ListViewItem[] { item1, item2 });

            // Assuming dataGridView1 is a DataGridView control on your form
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Column 1");
            dataTable.Columns.Add("Column 2");

            dataTable.Rows.Add("Item 1", "Value 1");
            dataTable.Rows.Add("Item 2", "Value 2");

            dataGridView1.DataSource = dataTable;

        }
        //
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}