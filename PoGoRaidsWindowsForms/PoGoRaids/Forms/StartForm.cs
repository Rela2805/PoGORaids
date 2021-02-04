using System;
using System.Net.Http;
using System.Windows.Forms;
using PogoRaids;

namespace PoGoRaids
{
    public partial class StartForm : Form
    {

        public StartForm()
        {
            InitializeComponent();
        }

        private void btnLoginClick(object sender, EventArgs e)
        {
            //LOGIN USER
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if(email == "" && password == "")
            {
                MessageBox.Show("Empty fields", "Error");
            }

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("user/login" + email + password).Result;
            long id = response.Content.ReadAsStringAsync().Id;

            MessageBox.Show("Successfully logged in", "Login");
            /*** NE RADI
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("user/login").Result;

            var user = response.Content.ReadAsAsync<IEnumerable<UserDOM>>().Result;

            var data = JsonConvert.DeserializeObject<List<UserDOM>>(user);
            
            if (data.Contains(email) && data.Contains(password))
            {
                MessageBox.Show("You are logged in", "Log in");
                new Home().Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Error logging in", "Error");
            }
            ***/
            new Home().Show();
            this.Hide();
        }

        private void btnRegisterClick(object sender, EventArgs e)
        {
            new RegisterForm().Show();
            this.Hide();
        }

    }
}
