using System;
using System.Windows.Forms;
using System.Net.Http;
using PogoRaids;

namespace PoGoRaids
{
    public partial class CreateRaid : Form
    {
        public CreateRaid()
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

        private void btnCreateRaidClick(object sender, EventArgs e)
        {
            //CREATE & SAVE NEW RAID
            string pokemonName = txtPokename.Text.Trim();
            int minLevel = Convert.ToInt32(txtMinLevel.Text.Trim());
            int startsTime = Convert.ToInt32(txtStartTime.Text.Trim());
            long creatorId = Convert.ToInt64(txtId.Text.Trim());

            if (pokemonName == "")
            {
                MessageBox.Show("You must enter Pokemon Name", "Error");
            }

            RaidDOM raid = new RaidDOM() { MinimalLevel = minLevel,
            PokemonName = pokemonName, StartsIn = startsTime, 
            CreatorId = creatorId};

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44390/");
            HttpResponseMessage response = client.PostAsJsonAsync("raid/", raid).Result;

            MessageBox.Show("Raid is created", "Create raid");

            new Home().Show();
            this.Hide();
        }
    }
}
