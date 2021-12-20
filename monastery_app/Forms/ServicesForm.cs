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
    public partial class ServicesForm : Form
    {
        AllModel<Services> service = new AllModel<Services>("Services");
        public ServicesForm()
        {
            InitializeComponent();
        }

        private void ServicesTableUpdate()
        {
            dataServices.DataSource = service.Objs;
            dataServices.Columns[0].HeaderText = "Номер службы";
            dataServices.Columns[1].HeaderText = "Название службы";
            dataServices.Columns[2].HeaderText = "Описание службы";
            dataServices.Columns[3].Visible = false;
        }

        // add service
        private async void button1_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.ServiceName = textBox1.Text;
            services.ServiceDescription = textBox2.Text;

            await services.Add();
            ServicesTableUpdate();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        // edit service
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataServices.SelectedRows[0].DataBoundItem is Services services)
            {
                services.ServiceName = textBox1.Text;
                services.ServiceDescription = textBox2.Text;
                await services.Update();
            }
            ServicesTableUpdate();
        }

        // delete service
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataServices.SelectedRows[0].DataBoundItem as Services).Delete();
            ServicesTableUpdate();
        }

        // back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            ServicesTableUpdate();
        }
    }
}
