namespace projekt4
{
    partial class form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form1));
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            txtUserName = new TextBox();
            textBox1 = new TextBox();
            txtpassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bauhaus 93", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(121, 134);
            label1.Name = "label1";
            label1.Size = new Size(135, 45);
            label1.TabIndex = 0;
            label1.Text = "LOG IN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Location = new Point(68, 369);
            panel1.Name = "panel1";
            panel1.Size = new Size(236, 1);
            panel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(29, 318);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(41, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 395);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.Highlight;
            panel2.Location = new Point(68, 452);
            panel2.Name = "panel2";
            panel2.Size = new Size(236, 1);
            panel2.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(29, 519);
            button1.Name = "button1";
            button1.Size = new Size(326, 46);
            button1.TabIndex = 6;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Highlight;
            label2.Location = new Point(226, 477);
            label2.Name = "label2";
            label2.Size = new Size(148, 26);
            label2.TabIndex = 7;
            label2.Text = "Clear Fields";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Elephant", 11.999999F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(159, 608);
            label3.Name = "label3";
            label3.Size = new Size(59, 26);
            label3.TabIndex = 8;
            label3.Text = "Exit";
            // 
            // txtUserName
            // 
            txtUserName.BorderStyle = BorderStyle.None;
            txtUserName.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtUserName.ForeColor = SystemColors.Highlight;
            txtUserName.Location = new Point(76, 336);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(228, 24);
            txtUserName.TabIndex = 9;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Highlight;
            textBox1.Location = new Point(76, 336);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 24);
            textBox1.TabIndex = 10;
            // 
            // txtpassword
            // 
            txtpassword.BorderStyle = BorderStyle.None;
            txtpassword.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            txtpassword.ForeColor = SystemColors.Highlight;
            txtpassword.Location = new Point(85, 422);
            txtpassword.Multiline = true;
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(228, 24);
            txtpassword.TabIndex = 11;
            // 
            // form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(386, 684);
            Controls.Add(txtpassword);
            Controls.Add(textBox1);
            Controls.Add(txtUserName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            ImeMode = ImeMode.On;
            Name = "form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button button1;
        private Label label2;
        private Label label3;
        private TextBox txtUserName;
        private TextBox textBox1;
        private TextBox txtpassword;
    }
}