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
    public partial class ExportForm : Form
    {
        AllModel<Stores> store = new AllModel<Stores>("Stores");
        AllModel<Discounts> discount = new AllModel<Discounts>("Discounts");
        AllModel<Roles> role = new AllModel<Roles>("Roles");
        AllModel<Services> service = new AllModel<Services>("Services");

        public string[] SelTB =
        {
            "Комиксы",
            "Продажи",
            "Сотрудники",
            "Поставщики",
        };

        public string[] SelEx =
        {
            "Excel",
            "PDF",
            "CSV",
            "WORD",
        };
        public ExportForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // Back
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
