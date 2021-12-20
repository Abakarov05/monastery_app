using monastery_app.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monastery_app.Forms
{
    public partial class TasksForm : Form
    {
        AllModel<Tasks> task = new AllModel<Tasks>("Tasks");
        AllModel<TypeTasks> typeTask = new AllModel<TypeTasks>("TypeTasks");
        public TasksForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void TaskTableUpdate()
        {
            dataTasks.DataSource = task.Objs;
            dataTasks.Columns[0].HeaderText = "Номер Задачи";
            dataTasks.Columns[1].HeaderText = "Задача";
            dataTasks.Columns[2].HeaderText = "Вид Задачи";
            dataTasks.Columns[3].Visible = false;

            comboBox1.DataSource = typeTask.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "TypeTaskName";
        }

        // Add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Tasks
            {
                Id = 0,
                TaskName = textBox1.Text,
                IdTypeTask = int.Parse(comboBox1.SelectedValue.ToString()),
            }.Add();
            TaskTableUpdate();
        }

        // Edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataTasks.SelectedRows[0].DataBoundItem is Tasks tasks)
            {
                tasks.TaskName = textBox1.Text;
                tasks.IdTypeTask = int.Parse(comboBox1.SelectedValue.ToString());
                await tasks.Update();
            }
            TaskTableUpdate();
        }

        // Delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataTasks.SelectedRows[0].DataBoundItem as Tasks).Delete();
            TaskTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Update data
        private void TasksForm_Load(object sender, EventArgs e)
        {
            TaskTableUpdate();
        }
    }
}
