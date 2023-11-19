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
            panelLogo = new Panel();
            panelMenu.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.SlateBlue;
            panelMenu.Controls.Add(button4);
            panelMenu.Controls.Add(button3);
            panelMenu.Controls.Add(button2);
            panelMenu.Controls.Add(button1);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(200, 995);
            panelMenu.TabIndex = 0;
            panelMenu.Paint += panel1_Paint;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.Transparent;
            button4.Location = new Point(0, 554);
            button4.Name = "button4";
            button4.Size = new Size(194, 83);
            button4.TabIndex = 4;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(0, 465);
            button3.Name = "button3";
            button3.Size = new Size(194, 83);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(0, 376);
            button2.Name = "button2";
            button2.Size = new Size(194, 83);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Image = Properties.Resources.calenderall_com__1_;
            button1.Location = new Point(0, 287);
            button1.Name = "button1";
            button1.Size = new Size(194, 83);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.BackColor = Color.DarkSlateBlue;
            panelLogo.BackgroundImage = Properties.Resources.cute_rabbit_7680x4320_10588;
            panelLogo.BackgroundImageLayout = ImageLayout.Stretch;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 86);
            panelLogo.TabIndex = 0;
            panelLogo.Paint += panelLogo_Paint;
            // 
            // ToDoApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1691, 995);
            Controls.Add(panelMenu);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToDoApp";
            Text = "Form1";
            panelMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelLogo;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
    }
}