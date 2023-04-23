using MySql.Data.MySqlClient;
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
    public partial class Vrienden : UserControl
    {
        private static MySqlConnection con = Database.Instance().Connection;
        public Vrienden()
        {
            InitializeComponent();
        }

        private void Vrienden_Load(object sender, EventArgs e)
        {
            // get afspeellijsten uit database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT vriendName FROM vrienden";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] vrienden = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    vrienden[i] = data.GetValue(i).ToString();
                    VriendenList.Items.Add(vrienden[i]);
                }

            }
        }

        private void VriendenList_DoubleClick(object sender, EventArgs e)
        {
            if (VriendenList.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Vriend vriendUserControl = new Vriend(VriendenList.SelectedItem.ToString());
                vriendUserControl.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(vriendUserControl);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
