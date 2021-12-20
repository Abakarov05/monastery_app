using monastery_app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace monastery_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DiscountsForm discount = new DiscountsForm();
            discount.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            RolesForm role = new RolesForm();
            role.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TypeTasksForm typeTasksForm = new TypeTasksForm();
            typeTasksForm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StoresForm stores = new StoresForm();
            stores.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            TypeItemsForm typeItemsForm = new TypeItemsForm();
            typeItemsForm.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OfferStatusesForm offerStatusesForm = new OfferStatusesForm();
            offerStatusesForm.Show();
            this.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            ExportForm form = new ExportForm();
            form.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TasksForm form = new TasksForm();
            form.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ItemsForm itemsForm = new ItemsForm();
            itemsForm.Show();
            this.Hide();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OffersForm offerform = new OffersForm();
            offerform.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TodoesForm todoesForm = new TodoesForm();
            todoesForm.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SalariesForm salariesForm = new SalariesForm();
            salariesForm.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NotesForm notesForm = new NotesForm();
            notesForm.Show();
            this.Hide();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            ScheduleWorksForm scheduleWorksForm = new ScheduleWorksForm();
            scheduleWorksForm.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            BudgetsForm budgetsForm = new BudgetsForm();
            budgetsForm.Show();
            this.Hide();
        }
    }
}
