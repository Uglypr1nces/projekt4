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
            components = new System.ComponentModel.Container();
            panel9 = new Panel();
            label2 = new Label();
            listBox1 = new ListBox();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panel6 = new Panel();
            label5 = new Label();
            panel8 = new Panel();
            label4 = new Label();
            panel7 = new Panel();
            label3 = new Label();
            panel9.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel9
            // 
            panel9.Controls.Add(label2);
            panel9.Location = new Point(903, 3);
            panel9.Name = "panel9";
            panel9.Size = new Size(259, 99);
            panel9.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 28);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 0;
            label2.Text = "label2";
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.SlateGray;
            listBox1.Font = new Font("Showcard Gothic", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(203, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(697, 441);
            listBox1.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(194, 83);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(3, 92);
            button2.Name = "button2";
            button2.Size = new Size(194, 83);
            button2.TabIndex = 2;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(3, 181);
            button3.Name = "button3";
            button3.Size = new Size(194, 83);
            button3.TabIndex = 3;
            button3.Text = "Sort";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Black;
            button4.Location = new Point(3, 270);
            button4.Name = "button4";
            button4.Size = new Size(194, 83);
            button4.TabIndex = 4;
            button4.Text = "edit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.Black;
            button5.Location = new Point(3, 369);
            button5.Name = "button5";
            button5.Size = new Size(194, 83);
            button5.TabIndex = 5;
            button5.Text = "details";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Location = new Point(906, 335);
            panel6.Name = "panel6";
            panel6.Size = new Size(259, 117);
            panel6.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 14);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 3;
            label5.Text = "label5";
            // 
            // panel8
            // 
            panel8.Controls.Add(label4);
            panel8.Location = new Point(906, 108);
            panel8.Name = "panel8";
            panel8.Size = new Size(259, 101);
            panel8.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 50);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 2;
            label4.Text = "label4";
            // 
            // panel7
            // 
            panel7.Controls.Add(label3);
            panel7.Location = new Point(906, 215);
            panel7.Name = "panel7";
            panel7.Size = new Size(259, 114);
            panel7.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 48);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(1173, 469);
            Controls.Add(listBox1);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(button1);
            Controls.Add(panel8);
            Controls.Add(panel6);
            Controls.Add(button2);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToDoApp";
            Text = "Form1";
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ListBox listBox1;
        private RichTextBox richTextBox1;
        private Label label2;
        private Panel panel9;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panel6;
        private Label label5;
        private Panel panel8;
        private Label label4;
        private Panel panel7;
        private Label label3;
    }
}