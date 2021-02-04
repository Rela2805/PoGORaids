using PogoRaids;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace PoGoRaids
{
    public partial class EditProfile : Form
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        private void btnHomeClick(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();
        }

        private void btnCreateClick(object sender, EventArgs e)
        {
            new CreateRaid().Show();
            this.Hide();
        }

        private void btnProfileClick(object sender, EventArgs e)
        {
            new Profile().Show();
            this.Hide();
        }

        private void btnSaveProfileClick(object sender, EventArgs e)
        {
            //SAVE CHANGES, UPDATE USER
            string name = txtName.Text;
            string surname = txtSurname.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string pogoCode = txtPoGoCode.Text;
            string nickname = txtNickname.Text;

            if (name == "" || surname == "" || email == ""
                || password == "" || nickname == "" || pogoCode == "" )
            {
                MessageBox.Show("Empty fields or incorrect values", "Error");
            }

            UserDOM user = new UserDOM()
            {
                Name = name,
                Surname = surname,
                Email = email,
                Password = password,
                GameNickname = nickname,
                GameCode = pogoCode,
            };

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.PutAsJsonAsync("user/", user).Result;

            MessageBox.Show("Successfully edited", "Edit profile");
                
            new Home().Show();
            this.Hide();
        }

        private void btnLogoutClick(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to log out?");
            //LOGOUT
            new StartForm().Show();
            this.Hide();
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete your account?");

            //DELETE ACCOUNT

            new StartForm().Show();
            this.Hide();
        }
    }
}
