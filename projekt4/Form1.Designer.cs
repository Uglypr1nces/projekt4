namespace projekt4
{
    partial class ToDoApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            panel1 = new Panel();
            panel3 = new Panel();
            listBox1 = new ListBox();
            label1 = new Label();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            listView1 = new ListView();
            panelMenu.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SlateBlue;
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(239, 993);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(12, 576);
            button4.Name = "button4";
            button4.Size = new Size(194, 83);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(12, 474);
            button3.Name = "button3";
            button3.Size = new Size(194, 83);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(12, 376);
            button2.Name = "button2";
            button2.Size = new Size(194, 83);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(12, 274);
            button1.Name = "button1";
            button1.Size = new Size(194, 83);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateGray;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(232, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1226, 995);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(dataGridView1);
            panel3.Controls.Add(listBox1);
            panel3.Location = new Point(41, 27);
            panel3.Name = "panel3";
            panel3.Size = new Size(1137, 941);
            panel3.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InactiveCaption;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 16);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(175, 904);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(158, 101);
            label1.MaximumSize = new Size(2000, 200000);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSlateBlue;
            panel2.Location = new Point(1451, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(243, 995);
            panel2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(258, 16);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(390, 904);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // listView1
            // 
            listView1.Location = new Point(697, 16);
            listView1.Name = "listView1";
            listView1.Size = new Size(359, 904);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1694, 993);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToDoApp";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private ListBox listBox1;
        private ListView listView1;
        private DataGridView dataGridView1;
    }
}