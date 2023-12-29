using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projekt4
{
    public partial class ToDoApp : Form
    {
        private tasks tasksform;
        private List<task> taskss = new List<task>();

        public ToDoApp()
        {
            InitializeComponent();
            tasksform = new tasks();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            using (var taskForm = new tasks())
            {
                if (taskForm.ShowDialog() == DialogResult.OK)
                {
                    string taskName = taskForm.TaskName;
                    string importance = taskForm.Importance;
                    string date = taskForm.Date;
                    string description = taskForm.Description;

                    task newtask = new task(taskName, importance, date, description);
                    listBox1.Items.Add(taskName);
                    taskss.Add(newtask);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                taskss.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            foreach (task thistask in taskss)
            {
                if (thistask.Importance == "wenig")
                {
                    listBox1.Items.Add(thistask.TaskName);
                }
                else if (thistask.Importance == "mittel")
                {
                    listBox1.Items.Add(thistask.TaskName);
                }
                else if (thistask.Importance == "sehr")
                {
                    listBox1.Items.Add(thistask.TaskName);
                }

            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                using (var taskForm = new tasks())
                {
                    task selctedtask = taskss[listBox1.SelectedIndex];

                    if (listBox1.SelectedIndex >= 0)
                    {

                        taskForm.Changestuff(selctedtask.TaskName, selctedtask.Importance, selctedtask.Date, selctedtask.Description);
                        if (taskForm.ShowDialog() == DialogResult.OK)
                        {
                            string taskName = taskForm.TaskName;
                            string importance = taskForm.Importance;
                            string date = taskForm.Date;
                            string description = taskForm.Description;

                            task updatedTask = new task(taskName, importance, date, description);
                            taskss[listBox1.SelectedIndex] = updatedTask;
                            listBox1.Items[listBox1.SelectedIndex] = updatedTask.TaskName;
                        }
                    }
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (taskss.Count > 0)
            {
                task currenttask = taskss[0];
                label2.Text = currenttask.TaskName;
                label3.Text = currenttask.Importance;
                label4.Text = currenttask.Date;
                label5.Text = currenttask.Description;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (taskss.Count > 0)
            {
                task currenttask = taskss[0];
                label2.Text = currenttask.TaskName;
                label3.Text = currenttask.Importance;
                label4.Text = currenttask.Date;
                label5.Text = currenttask.Description;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
