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
        AllModel<Users> user = new AllModel<Users>("Users");

        public OffersForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void OfferTableUpdate()
        {
            dataOffer.DataSource = offer.Objs;
            dataOffer.Columns[0].HeaderText = "Номер Заказа";
            dataOffer.Columns[1].HeaderText = "Номер Пользователя";
            dataOffer.Columns[2].HeaderText = "Номер товара";
            dataOffer.Columns[3].HeaderText = "Номер статуса товара";
            dataOffer.Columns[4].HeaderText = "Дата заказа";
            dataOffer.Columns[5].Visible = false;

            comboBox1.DataSource = user.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "UserName";

            comboBox2.DataSource = item.Objs;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "IdStore";

            comboBox3.DataSource = offerStatus.Objs;
            comboBox3.ValueMember = "Id";
            comboBox3.DisplayMember = "OfferStatusName";
        }

        // Add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Offers
            {
                Id = 0,
                IdUser = int.Parse(comboBox1.SelectedValue.ToString()),
                IdItem = int.Parse(comboBox2.SelectedValue.ToString()),
                IdOfferStatus = int.Parse(comboBox3.SelectedValue.ToString()),
                OfferDate = dateTimePicker1.Value,
            }.Add();
            OfferTableUpdate();
        }

        // Edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataOffer.SelectedRows[0].DataBoundItem is Offers offer)
            {
                offer.IdUser = int.Parse(comboBox1.SelectedValue.ToString());
                offer.IdItem = int.Parse(comboBox2.SelectedValue.ToString());
                offer.IdOfferStatus = int.Parse(comboBox3.SelectedValue.ToString());
                offer.OfferDate = dateTimePicker1.Value;
                await offer.Update();
            }
            OfferTableUpdate();
        }

        // Delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataOffer.SelectedRows[0].DataBoundItem as Offers).Delete();
            OfferTableUpdate();
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
