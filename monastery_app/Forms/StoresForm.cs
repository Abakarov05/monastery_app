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
    public partial class StoresForm : Form
    {
        AllModel<Stores> store = new AllModel<Stores>("Stores");
        public StoresForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void StoreTableUpdate()
        {
            dataStore.DataSource = store.Objs;
            dataStore.Columns[0].HeaderText = "Номер Товара";
            dataStore.Columns[1].HeaderText = "Название товара";
            dataStore.Columns[2].HeaderText = "Количество";
            dataStore.Columns[3].Visible = false;
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Add store item
        private async void button1_Click(object sender, EventArgs e)
        {
            Stores stores = new Stores();
            stores.StoreItemName = textBox1.Text;
            stores.StoreItemAvailable = int.Parse(textBox2.Text);

            await stores.Add();
            StoreTableUpdate();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // Edit store
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataStore.SelectedRows[0].DataBoundItem is Stores stores)
            {
                stores.StoreItemName = textBox1.Text;
                stores.StoreItemAvailable = int.Parse(textBox2.Text);
                await stores.Update();
            }
            StoreTableUpdate();
        }

        // Delete store
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataStore.SelectedRows[0].DataBoundItem as Stores).Delete();
            StoreTableUpdate();
        }

        private void StoresForm_Load(object sender, EventArgs e)
        {
            StoreTableUpdate();
        }
    }
}
