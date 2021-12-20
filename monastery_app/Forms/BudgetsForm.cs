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
    public partial class BudgetsForm : Form
    {
        AllModel<Budgets> budget = new AllModel<Budgets>("Budgets");
        AllModel<Notes> note = new AllModel<Notes>("Notes");
        AllModel<Offers> offer = new AllModel<Offers>("Offers");
        public BudgetsForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void BudgetTableUpdate()
        {
            dataBudget.DataSource = budget.Objs;
            dataBudget.Columns[0].HeaderText = "Номер Бюджета";
            dataBudget.Columns[1].HeaderText = "Номер записки";
            dataBudget.Columns[2].HeaderText = "Номер заказа";
            dataBudget.Columns[3].HeaderText = "Дата";
            dataBudget.Columns[4].Visible = false;

            comboBox1.DataSource = note.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "NotePrice";

            comboBox2.DataSource = offer.Objs;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "IdItem";
        }

        // update
        private void BudgetsForm_Load(object sender, EventArgs e)
        {
            BudgetTableUpdate();
        }

        // add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Budgets
            {
                Id = 0,
                IdNotePrice = int.Parse(comboBox1.SelectedValue.ToString()),
                IdOfferItemPrice = int.Parse(comboBox1.SelectedValue.ToString()),
                BudgetDate = dateTimePicker1.Value,
            }.Add();
            BudgetTableUpdate();
        }

        // edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataBudget.SelectedRows[0].DataBoundItem is Budgets budget)
            {
                budget.IdNotePrice = int.Parse(comboBox1.SelectedValue.ToString());
                budget.IdOfferItemPrice = int.Parse(comboBox1.SelectedValue.ToString());
                budget.BudgetDate = dateTimePicker1.Value;
                await budget.Update();
            }
            BudgetTableUpdate();
        }

        // delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataBudget.SelectedRows[0].DataBoundItem as Budgets).Delete();
            BudgetTableUpdate();
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
