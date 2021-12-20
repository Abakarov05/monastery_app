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
    public partial class TypeItemsForm : Form
    {
        AllModel<TypeItems> typeItems = new AllModel<TypeItems>("TypeItems");
        public TypeItemsForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void TypeItemsTableUpdate()
        {
            dataTypeItem.DataSource = typeItems.Objs;
            dataTypeItem.Columns[0].HeaderText = "Номер вида товара";
            dataTypeItem.Columns[1].HeaderText = "Вид товара";
            dataTypeItem.Columns[2].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Update date
        private void TypeItemsForm_Load(object sender, EventArgs e)
        {
            TypeItemsTableUpdate();
        }

        // Add type items
        private async void button1_Click(object sender, EventArgs e)
        {
            TypeItems typeItems = new TypeItems();
            typeItems.TypeItemName = textBox1.Text;

            await typeItems.Add();
            TypeItemsTableUpdate();
            textBox1.Text = "";
        }

        // Edit type items
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataTypeItem.SelectedRows[0].DataBoundItem is TypeItems typeItems)
            {
                typeItems.TypeItemName = textBox1.Text;
                await typeItems.Update();
            }
            TypeItemsTableUpdate();
        }

        // Delete type items
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataTypeItem.SelectedRows[0].DataBoundItem as TypeItems).Delete();
            TypeItemsTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
