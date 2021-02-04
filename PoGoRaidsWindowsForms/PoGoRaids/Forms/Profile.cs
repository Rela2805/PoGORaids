using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using PogoRaids; 

namespace PoGoRaids
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void btnEditprofileClick(object sender, EventArgs e)
        {
            new EditProfile().Show();
            this.Hide();
        }

        private void btnLogoutClick(object sender, EventArgs e)
        {
            MessageBox.Show("You have succesfully logged out.", "Log out");
            new StartForm().Show();
            this.Hide();
        }

        private void btnDeleteClick(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to delete your account?", "Delete account");

            //delete account
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("user").Result;

            long id = response.Content.ReadAsStringAsync().Id;

            response = client.DeleteAsync("user/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                MessageBox.Show("You have successfully deleted your account", "Delete");
                new StartForm().Show();
                this.Hide();
            }
            else
                MessageBox.Show("Deleting failed", "Error");
            
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

        private void btnShowAboutClick(object sender, EventArgs e)
        {
            //GET USER BY ID
            long ID = Convert.ToInt64(txtId.Text.Trim());
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("user/" + ID).Result;

            //long id = response.Content.ReadAsStringAsync().Id;

            UserDOM user = response.Content.ReadAsAsync<UserDOM>().Result;
            List<UserDOM> userList = new List<UserDOM>();
            userList.Add(user);
            userInfo.DataSource = userList;
            /***
             SHOW ALL USERS
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("user/all").Result;
            var user = response.Content.ReadAsAsync<IEnumerable<UserDOM>>().Result;
            userInfo.DataSource = user;
            ***/
        }
    }
}
