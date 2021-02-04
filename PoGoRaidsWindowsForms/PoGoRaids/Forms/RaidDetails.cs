using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoGoRaids
{
    public partial class RaidDetails : Form
    {
        public RaidDetails()
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

        private void btnJoinClick(object sender, EventArgs e)
        {
            //JOIN RAID
        }

        private void btnLeaveClick(object sender, EventArgs e)
        {
            //LEAVE RAID
        }
    }
}
