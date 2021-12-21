using monastery_app.Models;
using System;
using System.Windows.Forms;

namespace monastery_app.Forms
{
    public partial class PriestForm : Form
    {
        AllModel<Notes> note = new AllModel<Notes>("Notes");
        AllModel<Users> user = new AllModel<Users>("Users");
        AllModel<Items> item = new AllModel<Items>("Items");
        AllModel<OfferStatuses> offerStatus = new AllModel<OfferStatuses>("OfferStatus");
        AllModel<Offers> offer = new AllModel<Offers>("Offers");
        AllModel<TypeItems> typeItem = new AllModel<TypeItems>("TypeItems");
        AllModel<Stores> store = new AllModel<Stores>("Stores");
        AllModel<ScheduleWorks> scheduleWork = new AllModel<ScheduleWorks>("ScheduleWorks");
        AllModel<Services> service = new AllModel<Services>("Services");

        public PriestForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void NoteTableUpdate()
        {
            dataNote.DataSource = note.Objs;
            dataNote.Columns[0].HeaderText = "Номер Записки";
            dataNote.Columns[1].HeaderText = "Номер пользователя";
            dataNote.Columns[2].HeaderText = "Пожертвование";
            dataNote.Columns[3].Visible = false;

            comboBoxNoteUser.DataSource = user.Objs;
            comboBoxNoteUser.ValueMember = "Id";
            comboBoxNoteUser.DisplayMember = "UserName";
        }

        // Enter data
        private void ScheduleWorkTableUpdate()
        {
            dataScheduleWork.DataSource = scheduleWork.Objs;
            dataScheduleWork.Columns[0].HeaderText = "Номер расписания службы";
            dataScheduleWork.Columns[1].HeaderText = "Номер службы";
            dataScheduleWork.Columns[2].HeaderText = "Дата расписания службы";
            dataScheduleWork.Columns[3].Visible = false;

            comboBoxServiceScheduleWork.DataSource = service.Objs;
            comboBoxServiceScheduleWork.ValueMember = "Id";
            comboBoxServiceScheduleWork.DisplayMember = "ServiceName";
        }

        private void ServicesTableUpdate()
        {
            dataServices.DataSource = service.Objs;
            dataServices.Columns[0].HeaderText = "Номер службы";
            dataServices.Columns[1].HeaderText = "Название службы";
            dataServices.Columns[2].HeaderText = "Описание службы";
            dataServices.Columns[3].Visible = false;
        }

       

        private async void noteAddButton_Click_1(object sender, EventArgs e)
        {
            await new Notes
            {
                Id = 0,
                IdUser = int.Parse(comboBoxNoteUser.SelectedValue.ToString()),
                NotePrice = int.Parse(textBoxNotePrice.Text.ToString()),
            }.Add();
            NoteTableUpdate();
        }

        private async void noteEditButton_Click_1(object sender, EventArgs e)
        {
            if (dataNote.SelectedRows[0].DataBoundItem is Notes note)
            {
                note.IdUser = int.Parse(comboBoxNoteUser.SelectedValue.ToString());
                note.NotePrice = int.Parse(textBoxNotePrice.Text.ToString());
                await note.Update();
            }
            NoteTableUpdate();
        }

        private async void noteDeleteButton_Click_1(object sender, EventArgs e)
        {
            await (dataNote.SelectedRows[0].DataBoundItem as Notes).Delete();
            NoteTableUpdate();
        }

        private void noteBackButton_Click_1(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            NoteTableUpdate();
        }

        private async void buttonAddScheduleWork_Click(object sender, EventArgs e)
        {
            await new ScheduleWorks
            {
                Id = 0,
                IdService = int.Parse(comboBoxServiceScheduleWork.SelectedValue.ToString()),
                ScheduleWorkDate = dateTimePickerScheduleWork.Value,
            }.Add();
            ScheduleWorkTableUpdate();
        }

        private async void buttonEditScheduleWork_Click(object sender, EventArgs e)
        {
            if (dataScheduleWork.SelectedRows[0].DataBoundItem is ScheduleWorks scheduleWork)
            {
                scheduleWork.IdService = int.Parse(comboBoxServiceScheduleWork.SelectedValue.ToString());
                scheduleWork.ScheduleWorkDate = dateTimePickerScheduleWork.Value;
                await scheduleWork.Update();
            }
            ScheduleWorkTableUpdate();
        }

        private async void buttonDeleteScheduleWork_Click(object sender, EventArgs e)
        {
            await(dataScheduleWork.SelectedRows[0].DataBoundItem as ScheduleWorks).Delete();
            ScheduleWorkTableUpdate();
        }

        private void buttonBackScheduleWork_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Hide();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {
            ScheduleWorkTableUpdate();
        }

        private async void buttonAddService_Click(object sender, EventArgs e)
        {
            Services services = new Services();
            services.ServiceName = textBox1.Text;
            services.ServiceDescription = textBox2.Text;

            await services.Add();
            ServicesTableUpdate();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private async void buttonEditService_Click(object sender, EventArgs e)
        {
            if (dataServices.SelectedRows[0].DataBoundItem is Services services)
            {
                services.ServiceName = textBox1.Text;
                services.ServiceDescription = textBox2.Text;
                await services.Update();
            }
            ServicesTableUpdate();
        }

        private async void buttonDeleteService_Click(object sender, EventArgs e)
        {
            await(dataServices.SelectedRows[0].DataBoundItem as Services).Delete();
            ServicesTableUpdate();
        }

        private void buttonBackService_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Hide();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            ServicesTableUpdate();
        }

        private void PriestForm_Load(object sender, EventArgs e)
        {
            ServicesTableUpdate();
            ScheduleWorkTableUpdate();
            NoteTableUpdate();
        }
    }
}
