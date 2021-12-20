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
    public partial class NotesForm : Form
    {
        AllModel<Notes> note = new AllModel<Notes>("Notes");
        AllModel<Users> user = new AllModel<Users>("Users");
        public NotesForm()
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

            comboBox1.DataSource = user.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "UserName";
        }

        // update
        private void NotesForm_Load(object sender, EventArgs e)
        {
            NoteTableUpdate();
        }

        // add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Notes
            {
                Id = 0,
                IdUser = int.Parse(comboBox1.SelectedValue.ToString()),
                NotePrice = int.Parse(textBox1.Text.ToString()),
            }.Add();
            NoteTableUpdate();
        }

        // edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataNote.SelectedRows[0].DataBoundItem is Notes note)
            {
                note.IdUser = int.Parse(comboBox1.SelectedValue.ToString());
                note.NotePrice = int.Parse(textBox1.Text.ToString());
                await note.Update();
            }
            NoteTableUpdate();
        }

        // delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataNote.SelectedRows[0].DataBoundItem as Notes).Delete();
            NoteTableUpdate();
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
