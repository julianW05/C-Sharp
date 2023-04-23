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
    public partial class Vriend : UserControl
    {
        private static MySqlConnection con = Database.Instance().Connection;
        string vriendName;
        public Vriend(string title)
        {
            InitializeComponent();
            vriendName = title;
        }

        private void Vriend_Load(object sender, EventArgs e)
        {
            label1.Text = vriendName;

            // get afspeellijsten van vriend uit database en zet ze in de listbox
            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT afspeellijsten.afspeellijstName FROM vrienden JOIN vriend_afspeellijsten ON vrienden.vriendID = vriend_afspeellijsten.vriendID JOIN afspeellijsten ON vriend_afspeellijsten.afspeellijstID = afspeellijsten.afspeellijstID WHERE vrienden.vriendName = ?title";
            cmd.Parameters.AddWithValue("?title", vriendName);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] afspeellijsten = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    afspeellijsten[i] = data.GetValue(i).ToString();
                    listBox1.Items.Add(afspeellijsten[i]);
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Vrienden vriendenUserControl = new Vrienden();
            vriendenUserControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(vriendenUserControl);
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Speellijst speellijstUserControl = new Speellijst(listBox1.SelectedItem.ToString());
                speellijstUserControl.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(speellijstUserControl);
            }
        }
    }
}
