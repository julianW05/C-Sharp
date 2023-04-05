using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_App
{
    public partial class Vrienden : Form
    {
        public Vrienden()
        {
            InitializeComponent();
        }

        private void BtnVriendenTerug_Click(object sender, EventArgs e)
        {
            var startMenu = (Form1)Tag;
            startMenu.Show();
            Close();
        }
    }
}
