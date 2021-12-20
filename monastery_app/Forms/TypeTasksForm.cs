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
    public partial class TypeTasksForm : Form
    {
        AllModel<TypeTasks> typeTask = new AllModel<TypeTasks>("TypeTasks");
        public TypeTasksForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void TypeTasksTableUpdate()
        {
            dataTypeTasks.DataSource = typeTask.Objs;
            dataTypeTasks.Columns[0].HeaderText = "Номер вида задачи";
            dataTypeTasks.Columns[1].HeaderText = "Вид задачи";
            dataTypeTasks.Columns[2].Visible = false;
        }

        // Add type task
        private async void button1_Click(object sender, EventArgs e)
        {
            TypeTasks typeTasks = new TypeTasks();
            typeTasks.TypeTaskName = textBox1.Text;

            await typeTasks.Add();
            TypeTasksTableUpdate();
            textBox1.Text = "";
        }

        // Edit type task
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataTypeTasks.SelectedRows[0].DataBoundItem is TypeTasks typeTasks)
            {
                typeTasks.TypeTaskName = textBox1.Text;
                await typeTasks.Update();
            }
            TypeTasksTableUpdate();
        }

        // Delete type task
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataTypeTasks.SelectedRows[0].DataBoundItem as TypeTasks).Delete();
            TypeTasksTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void TypeTasksForm_Load(object sender, EventArgs e)
        {
            TypeTasksTableUpdate();
        }
    }
}
