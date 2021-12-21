using monastery_app.Models;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace monastery_app.Forms
{
    public partial class AuthForm : Form
    {
        AllModel<Users> user = new AllModel<Users>("Users");
        public AuthForm()
        {
            InitializeComponent();
        }

        // Log in
        private async void button1_Click(object sender, EventArgs e)
        {
            var pass = GetHash(textBox2.Text);

            if (user.Objs.Any(users => users.UserLogin == textBox1.Text && users.UserPassword == pass))
            {
                var users = user.Objs.FirstOrDefault(users => users.UserLogin == textBox1.Text && users.UserPassword == pass);
                switch ((await new Roles { Id = (int)users.IdRole }.Get()).RoleName)
                {
                    case "Администратор":
                        Form1 mainform = new Form1();
                        mainform.Show();
                        this.Hide();
                        break;
                    case "Священник":
                        PriestForm priestform = new PriestForm();
                        priestform.Show();
                        this.Hide();
                        break;
                    default:
                        return;
                }
            }
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = (char)0;
            }
            else
            {
                textBox2.PasswordChar = '€';
            }
        }

        public string GetHash(string input)
        {
            var md5 = MD5.Create();
            var hash = md5.ComputeHash(Encoding.UTF8.GetBytes(input));

            return Convert.ToBase64String(hash);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
