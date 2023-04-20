using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_App.UserControls
{
    public partial class Speellijst : UserControl
    {
        public Speellijst()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Speellijsten speellijstenUserControl = new Speellijsten();
            speellijstenUserControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(speellijstenUserControl);
        }
    }
}
