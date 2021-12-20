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
    public partial class TodoesForm : Form
    {
        AllModel<Todoes> todo = new AllModel<Todoes>("Todoes");
        AllModel<Users> user = new AllModel<Users>("Users");
        AllModel<Tasks> task = new AllModel<Tasks>("Tasks");
        public TodoesForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void TodoTableUpdate()
        {
            dataTodo.DataSource = todo.Objs;
            dataTodo.Columns[0].HeaderText = "Номер Задачи";
            dataTodo.Columns[1].HeaderText = "Номер Пользователя";
            dataTodo.Columns[2].HeaderText = "Номер задачи";
            dataTodo.Columns[3].HeaderText = "Статус задачи";
            dataTodo.Columns[4].Visible = false;

            comboBox1.DataSource = user.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "UserName";

            comboBox2.DataSource = task.Objs;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "TaskName";
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Todoes
            {
                Id = 0,
                IdUser = int.Parse(comboBox1.SelectedValue.ToString()),
                IdTask = int.Parse(comboBox2.SelectedValue.ToString()),
                TodoStatus = textBox1.Text,
            }.Add();
            TodoTableUpdate();
        }

        // Edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataTodo.SelectedRows[0].DataBoundItem is Todoes todo)
            {
                todo.IdUser = int.Parse(comboBox1.SelectedValue.ToString());
                todo.IdTask = int.Parse(comboBox2.SelectedValue.ToString());
                todo.TodoStatus = textBox1.Text;
                await todo.Update();
            }
            TodoTableUpdate();
        }

        // Delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataTodo.SelectedRows[0].DataBoundItem as Todoes).Delete();
            TodoTableUpdate();
        }

        private void TodoesForm_Load(object sender, EventArgs e)
        {
            TodoTableUpdate();
        }
    }
}
