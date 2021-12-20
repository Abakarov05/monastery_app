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
    public partial class SalariesForm : Form
    {
        AllModel<Salaries> salary = new AllModel<Salaries>("Salaries");
        AllModel<Users> user = new AllModel<Users>("Users");
        public SalariesForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void SalaryTableUpdate()
        {
            dataSalary.DataSource = salary.Objs;
            dataSalary.Columns[0].HeaderText = "Номер Зарплаты";
            dataSalary.Columns[1].HeaderText = "Зарплата";
            dataSalary.Columns[2].HeaderText = "Номер пользователя";
            dataSalary.Columns[3].Visible = false;

            comboBox1.DataSource = user.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "UserName";
        }

        // update
        private void SalariesForm_Load(object sender, EventArgs e)
        {
            SalaryTableUpdate();
        }

        // add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Salaries
            {
                Id = 0,
                IdUser = int.Parse(comboBox1.SelectedValue.ToString()),
                SalaryPrice = int.Parse(textBox1.Text.ToString()),
            }.Add();
            SalaryTableUpdate();
        }

        // edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataSalary.SelectedRows[0].DataBoundItem is Salaries salary)
            {
                salary.IdUser = int.Parse(comboBox1.SelectedValue.ToString());
                salary.SalaryPrice = int.Parse(textBox1.Text.ToString());
                await salary.Update();
            }
            SalaryTableUpdate();
        }

        // delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataSalary.SelectedRows[0].DataBoundItem as Salaries).Delete();
            SalaryTableUpdate();
        }

        // back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
