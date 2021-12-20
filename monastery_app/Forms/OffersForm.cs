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
    public partial class OffersForm : Form
    {
        AllModel<Items> item = new AllModel<Items>("Items");
        AllModel<OfferStatuses> offerStatus = new AllModel<OfferStatuses>("OfferStatus");
        AllModel<Offers> offer = new AllModel<Offers>("Offers");
        public OffersForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void OfferTableUpdate()
        {
            dataOffer.DataSource = item.Objs;
            dataOffer.Columns[0].HeaderText = "Номер Заказа";
            dataOffer.Columns[1].HeaderText = "Номер Пользователя";
            dataOffer.Columns[2].HeaderText = "Номер товара";
            dataOffer.Columns[3].HeaderText = "Номер статуса товара";
            dataOffer.Columns[4].HeaderText = "Дата заказа";
            dataOffer.Columns[5].Visible = false;

        /*    comboBox1.DataSource = store.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "StoreItemName";

            comboBox2.DataSource = typeItem.Objs;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "TypeItemName";*/
        }

        // Add
        private void button1_Click(object sender, EventArgs e)
        {

        }

        // Edit
        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Delete
        private void button3_Click(object sender, EventArgs e)
        {

        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Update
        private void OffersForm_Load(object sender, EventArgs e)
        {
            OfferTableUpdate();
        }
    }
}
