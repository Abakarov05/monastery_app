﻿using monastery_app.Models;
using System;
using System.Windows.Forms;

namespace monastery_app.Forms
{
    public partial class UsersForm : Form
    {
        AllModel<Users> user = new AllModel<Users>("Users");
        AllModel<Discounts> discount = new AllModel<Discounts>("Discounts");
        AllModel<Roles> role = new AllModel<Roles>("Roles");
        public UsersForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void UserTableUpdate()
        {
            dataUser.DataSource = user.Objs;
            dataUser.Columns[0].HeaderText = "Номер Пользователя";
            dataUser.Columns[1].HeaderText = "Имя";
            dataUser.Columns[2].HeaderText = "Фамилия";
            dataUser.Columns[3].HeaderText = "Логин";
            dataUser.Columns[4].HeaderText = "Пароль";
            dataUser.Columns[5].HeaderText = "Роль";
            dataUser.Columns[6].HeaderText = "Скидка";
            dataUser.Columns[7].Visible = false;

            comboBox1.DataSource = role.Objs;
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "RoleName";

            comboBox2.DataSource = discount.Objs;
            comboBox2.ValueMember = "Id";
            comboBox2.DisplayMember = "DiscountPercent";
        }

        // Update
        private void UsersForm_Load(object sender, EventArgs e)
        {
            UserTableUpdate();
        }

        // Add
        private async void button1_Click(object sender, EventArgs e)
        {
            await new Users
            {
                Id = 0,
                UserName = textBox1.Text,
                UserSurname = textBox2.Text,
                UserLogin = textBox3.Text,
                UserPassword = textBox4.Text,
                IdRole = int.Parse(comboBox1.SelectedValue.ToString()),
                IdDiscount = int.Parse(comboBox2.SelectedValue.ToString()),
            }.Add();
            UserTableUpdate();
        }

        // Edit
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataUser.SelectedRows[0].DataBoundItem is Users user)
            {
                user.UserName = textBox1.Text;
                user.UserSurname = textBox2.Text;
                user.UserLogin = textBox3.Text;
                user.UserPassword = textBox4.Text;
                user.IdRole = int.Parse(comboBox1.SelectedValue.ToString());
                user.IdDiscount = int.Parse(comboBox2.SelectedValue.ToString());
                await user.Update();
            }
            UserTableUpdate();
        }

        // Delete
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataUser.SelectedRows[0].DataBoundItem as Users).Delete();
            UserTableUpdate();
        }

        // Back
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
