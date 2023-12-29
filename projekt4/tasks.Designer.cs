namespace projekt4
{
    partial class tasks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            richTextBox1 = new RichTextBox();
            richTextBox3 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InactiveCaption;
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(202, 99);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox3
            // 
            richTextBox3.BackColor = SystemColors.InactiveCaption;
            richTextBox3.Location = new Point(503, 12);
            richTextBox3.Name = "richTextBox3";
            richTextBox3.Size = new Size(202, 99);
            richTextBox3.TabIndex = 1;
            richTextBox3.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.BackColor = SystemColors.InactiveCaption;
            richTextBox2.Location = new Point(253, 12);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(202, 99);
            richTextBox2.TabIndex = 2;
            richTextBox2.Text = "";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSteelBlue;
            button1.Location = new Point(432, 152);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "fertig";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(69, 119);
            label1.Name = "label1";
            label1.Size = new Size(61, 24);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(463, 123);
            label2.Name = "label2";
            label2.Size = new Size(216, 20);
            label2.TabIndex = 6;
            label2.Text = "importance(sehr,mittel,wenig)";
            
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(803, 123);
            label3.Name = "label3";
            label3.Size = new Size(46, 24);
            label3.TabIndex = 7;
            label3.Text = "date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(288, 120);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 8;
            label4.Text = "description";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(726, 67);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(204, 23);
            dateTimePicker2.TabIndex = 10;
            
            // 
            // tasks
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(957, 192);
            Controls.Add(dateTimePicker2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox3);
            Controls.Add(richTextBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "tasks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox richTextBox1;
        private RichTextBox richTextBox3;
        private RichTextBox richTextBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker2;
    }
}