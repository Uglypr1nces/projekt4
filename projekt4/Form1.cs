using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace projekt4
{
    public partial class ToDoApp : Form
    {
        private tasks tasksform;
        private List<task> taskss = new List<task>();
        public string csvfile = Path.Combine(@"C:\Users\aqua\source\repos\projekt4\projekt4\databank\tasks.csv");

        public ToDoApp()
        {
            InitializeComponent();
            tasksform = new tasks();
            var lines = File.ReadLines(csvfile);
            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(';');

                if (values.Length >= 4)
                {
                    string name = values[0].Trim();
                    string description = values[1].Trim();
                    string importance = values[2].Trim();

                    string[] dateParts = values[3].Trim().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string date = "";

                    if (dateParts.Length >= 4)
                    {
                        string month = dateParts[1];
                        string day = dateParts[2];
                        string year = dateParts[3];

                        date = $"{month} {day} {year}";

                        if (!DateTime.TryParse(date, out _))
                        {
                            MessageBox.Show($"Invalid date format: {date}");
                            continue;
                        }
                    }
                    else
                    {
                        MessageBox.Show($"Invalid date format: {values[3]}");
                        continue;
                    }

                    task newtask = new task(name, description, importance, date);
                    taskss.Add(newtask);
                    listBox1.Items.Add(newtask.TaskName);
                }
                else
                {
                    MessageBox.Show($"Invalid line in CSV file: {line}");
                }
            }
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
                    try
                    {
                        using (StreamWriter sw = File.AppendText(csvfile))
                        {
                            sw.WriteLine($"{newtask.TaskName};{newtask.Description};{newtask.Importance};{newtask.Date}");
                        }

                        MessageBox.Show("task added.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An error occurred while reading the CSV file: {ex.Message}");
                    }
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
                if (thistask.Importance == "wenig" || thistask.Importance == "mittel" || thistask.Importance == "sehr")
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
                    task selectedTask = taskss[listBox1.SelectedIndex];

                    if (listBox1.SelectedIndex >= 0)
                    {
                        taskForm.Changestuff(selectedTask.TaskName, selectedTask.Importance, selectedTask.Description, selectedTask.Date);
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

        private void button5_Click(object sender, EventArgs e)
        {
            if (taskss.Count > 0 && listBox1.SelectedIndex != -1)
            {
                task currenttask = taskss[listBox1.SelectedIndex];
                label2.Text = currenttask.TaskName;
                label3.Text = currenttask.Importance;
                label4.Text = currenttask.Description;
                label5.Text = currenttask.Date;
            }
        }
    }
}
