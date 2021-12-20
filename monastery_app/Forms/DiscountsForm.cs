using monastery_app.Models;
using System;
using System.Windows.Forms;

namespace monastery_app
{
    public partial class DiscountsForm : Form
    {
        AllModel<Discounts> discounts = new AllModel<Discounts>("Discounts");

        public DiscountsForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void discountTableUpdate()
        {
            dataDiscount.DataSource = discounts.Objs;
            dataDiscount.Columns[0].HeaderText = "Номер скидки";
            dataDiscount.Columns[1].HeaderText = "Скидка";
            dataDiscount.Columns[2].Visible = false;
        }

        // Add discount
        private async void button1_Click(object sender, EventArgs e)
        {
            Discounts discount = new Discounts();
            discount.DiscountPercent = int.Parse(textBox1.Text);

            await discount.Add();
            discountTableUpdate();
            textBox1.Text = "";
        }

        // Edit discount
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataDiscount.SelectedRows[0].DataBoundItem is Discounts discounts)
            {
                discounts.DiscountPercent = int.Parse(textBox1.Text);
                await discounts.Update();
            }
            discountTableUpdate();
        }

        // Delete discount
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataDiscount.SelectedRows[0].DataBoundItem as Discounts).Delete();
            discountTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Update table
        private void DiscountsForm_Load(object sender, EventArgs e)
        {
            discountTableUpdate();
        }
    }
}
