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
    public partial class ItemsForm : Form
    {
        AllModel<Items> item = new AllModel<Items>("Items");
        AllModel<TypeItems> typeItem = new AllModel<TypeItems>("TypeItems");
        AllModel<Stores> store = new AllModel<Stores>("Stores");
        public ItemsForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void ItemTableUpdate()
        {
            dataItems.DataSource = item.Objs;
            dataItems.Columns[0].HeaderText = "Номер Товара";
            dataItems.Columns[1].HeaderText = "Номер товара на складе";
            dataItems.Columns[2].HeaderText = "Номер вида тоара";
            dataItems.Columns[3].HeaderText = "Стоимость товара";
            dataItems.Columns[4].Visible = false;

            comboBox1.DataSource = store.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "StoreItemName";

            comboBox2.DataSource = typeItem.Objs;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "TypeItemName";
        }

        // Add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Items
            {
                Id = 0,
                ItemPrice = int.Parse(textBox1.Text.ToString()),
                IdStore = int.Parse(comboBox1.SelectedValue.ToString()),
                IdType = int.Parse(comboBox2.SelectedValue.ToString()),
            }.Add();
            ItemTableUpdate();
        }

        // Edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataItems.SelectedRows[0].DataBoundItem is Items items)
            {
                items.ItemPrice = int.Parse(textBox1.Text.ToString());
                items.IdStore = int.Parse(comboBox1.SelectedValue.ToString());
                items.IdType = int.Parse(comboBox2.SelectedValue.ToString());
                await items.Update();
            }
            ItemTableUpdate();
        }

        // Delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataItems.SelectedRows[0].DataBoundItem as Items).Delete();
            ItemTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Update
        private void ItemsForm_Load(object sender, EventArgs e)
        {
            ItemTableUpdate();
        }
    }
}
