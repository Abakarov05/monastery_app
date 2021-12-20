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

namespace monastery_app
{
    public partial class RolesForm : Form
    {
        AllModel<Roles> roles = new AllModel<Roles>("Roles");
        public RolesForm()
        {
            InitializeComponent();
        }

        // Enter data
        private void RoleTableUpdate()
        {
            dataRole.DataSource = roles.Objs;
            dataRole.Columns[0].HeaderText = "Номер роли";
            dataRole.Columns[1].HeaderText = "Роль";
            dataRole.Columns[2].Visible = false;
        }

        // Add role
        private async void button1_Click(object sender, EventArgs e)
        {
            Roles role = new Roles();
            role.RoleName = textBox1.Text;

            await role.Add();
            RoleTableUpdate();
            textBox1.Text = "";
        }

        // Edit role
        private async void button2_Click(object sender, EventArgs e)
        {
            if (dataRole.SelectedRows[0].DataBoundItem is Roles roles)
            {
                roles.RoleName = textBox1.Text;
                await roles.Update();
            }
            RoleTableUpdate();
        }

        // Delete role
        private async void button3_Click(object sender, EventArgs e)
        {
            await (dataRole.SelectedRows[0].DataBoundItem as Roles).Delete();
            RoleTableUpdate();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        // Update data
        private void RolesForm_Load(object sender, EventArgs e)
        {
            RoleTableUpdate();
        }
    }
}
