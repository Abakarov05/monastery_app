using monastery_app.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace monastery_app.Forms
{
    public partial class AuthForm : Form
    {
        //AllModel<Users> user = new AllModel<Users>("Users");
        AllModel<Roles> role = new AllModel<Roles>("Roles");
        public AuthForm()
        {
            InitializeComponent();
        }

        // Log in
        private async void button1_Click(object sender, EventArgs e)
        {
            //if (user.Objs.Any(user => user.Login == textBox1.Text && user.Password == textBox2.Text))
            //{
            //    var users = user.Objs.FirstOrDefault(user => user.Login == textBox1.Text && user.Password == textBox2.Text);
            //    switch ((await new Roles { Id = (int)users.RoleId }.Get()).Name)
            //    {
            //        case "Администратор":
            //            Form1 mainform = new Form1();
            //            this.Hide();
            //            mainform.Show();
            //            break;
            //        case "Бухгалтер":
            //            Form1 mainform2 = new Form1();
            //            this.Hide();
            //            mainform2.Show();
            //            mainform2.button2.Visible = false;
            //           /* mainform2.tabControl3.Visible = false;
            //            mainform2.tabControl7.Visible = false;
            //            mainform2.tabControl8.Visible = false;
            //            mainform2.tabControl5.Visible = false;
            //            mainform2.tabControl4.Visible = false;*/
            //            break;
            //        default:
            //            return;
            //    }
            //}
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = (char)0;
            }
            else
            {
                textBox2.PasswordChar = '$';
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
