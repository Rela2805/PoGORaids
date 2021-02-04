using System;
using System.Windows.Forms;
using System.Net.Http;
using PogoRaids;

namespace PoGoRaids
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnBackClick(object sender, EventArgs e)
        {
            new StartForm().Show();
            this.Hide();
        }

        private void btnRegisterClick(object sender, EventArgs e)
        {
            //CREATE/REGISTER ACCOUNT
            string name = txtName.Text.Trim();
            string surname = txtSurname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string nick = txtNickname.Text.Trim();
            string pogoCode = txtPoGOCode.Text.Trim();
            int level = Convert.ToInt32(txtLevel.Text.Trim());
            string color = txtColor.Text;

            if (name == "" || surname == "" || username == "" || email == ""
                || password == "" || nick == "" || pogoCode == "" || level <1 && level>40
                || color == "")
            {
                MessageBox.Show("Empty fields or incorrect values", "Error");
            }

            UserDOM user = new UserDOM()
            {
                Name = name,
                Surname = surname,
                Username = username,
                Email = email,
                Password = password,
                GameNickname = nick,
                GameCode = pogoCode,
                Level = level,
                Color = color
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.PostAsJsonAsync("user/register", user).Result;

            MessageBox.Show("Successfully registered", "Register");

            new Home().Show();
            this.Hide();
 
        }

    }
}
