using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Net.Http;
using PogoRaids;

namespace PoGoRaids
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
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

        private void btnHomeClick(object sender, EventArgs e)
        {
            //GET ALL RAIDS
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("raid/all").Result;

            var raids = response.Content.ReadAsAsync<IEnumerable<PogoRaids.RaidDOM>>().Result;
            homeAllRaids.DataSource = raids;
        }

        private void btnRaidDetailsClick(object sender, EventArgs e)
        {
            //GET RAID BY ID
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.GetAsync("raid/all/" + txtId.Text).Result;

            RaidDOM raid = response.Content.ReadAsAsync<RaidDOM>().Result;
            List<RaidDOM> raidList = new List<RaidDOM>();
            raidList.Add(raid);
            homeAllRaids.DataSource = raidList;
        }
    }
}
