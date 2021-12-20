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
    public partial class OfferStatusesForm : Form
    {
        AllModel<OfferStatuses> offerStatuses = new AllModel<OfferStatuses>("OfferStatus");
        public OfferStatusesForm()
        {
            InitializeComponent();
        }

        private void OfferStatusesTableUpdate()
        {
            dataOfferStatus.DataSource = offerStatuses.Objs;
            dataOfferStatus.Columns[0].HeaderText = "Номер статуса заказа";
            dataOfferStatus.Columns[1].HeaderText = "Статус заказа";
            dataOfferStatus.Columns[2].Visible = false;
        }

        // Add Offer status
        private async void button1_Click(object sender, EventArgs e)
        {
            OfferStatuses offerStatuses = new OfferStatuses();
            offerStatuses.OfferStatusName = textBox1.Text;

            await offerStatuses.Add();
            OfferStatusesTableUpdate();
            textBox1.Text = "";
        }

        // Edit offer status
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataOfferStatus.SelectedRows[0].DataBoundItem is OfferStatuses offerStatuses)
            {
                offerStatuses.OfferStatusName = textBox1.Text;
                await offerStatuses.Update();
            }
            OfferStatusesTableUpdate();
        }

        // delete offer status
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataOfferStatus.SelectedRows[0].DataBoundItem as OfferStatuses).Delete();
            OfferStatusesTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // update data
        private void OfferStatusesForm_Load(object sender, EventArgs e)
        {
            OfferStatusesTableUpdate();
        }
    }
}
