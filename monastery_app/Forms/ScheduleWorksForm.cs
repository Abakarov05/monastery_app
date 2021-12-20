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
    public partial class ScheduleWorksForm : Form
    {
        AllModel<ScheduleWorks> scheduleWork = new AllModel<ScheduleWorks>("ScheduleWorks");
        AllModel<Services> service = new AllModel<Services>("Services");
        public ScheduleWorksForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void ScheduleWorkTableUpdate()
        {
            dataScheduleWork.DataSource = scheduleWork.Objs;
            dataScheduleWork.Columns[0].HeaderText = "Номер расписания службы";
            dataScheduleWork.Columns[1].HeaderText = "Номер службы";
            dataScheduleWork.Columns[2].HeaderText = "Дата расписания службы";
            dataScheduleWork.Columns[3].Visible = false;

            comboBox1.DataSource = service.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "ServiceName";
        }

        // update
        private void ScheduleWorksForm_Load(object sender, EventArgs e)
        {
            ScheduleWorkTableUpdate();
        }

        // add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new ScheduleWorks
            {
                Id = 0,
                IdService = int.Parse(comboBox1.SelectedValue.ToString()),
                ScheduleWorkDate = dateTimePicker1.Value,
            }.Add();
            ScheduleWorkTableUpdate();
        }

        // edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataScheduleWork.SelectedRows[0].DataBoundItem is ScheduleWorks scheduleWork)
            {
                scheduleWork.IdService = int.Parse(comboBox1.SelectedValue.ToString());
                scheduleWork.ScheduleWorkDate = dateTimePicker1.Value;
                await scheduleWork.Update();
            }
            ScheduleWorkTableUpdate();
        }

        // delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataScheduleWork.SelectedRows[0].DataBoundItem as ScheduleWorks).Delete();
            ScheduleWorkTableUpdate();
        }

        // back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
