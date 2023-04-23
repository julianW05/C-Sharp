using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_App.UserControls
{
    public partial class Album : UserControl
    {
        bool buttonvisible = false;
        private static MySqlConnection con = Database.Instance().Connection;
        string albumName;
        public Album(string title)
        {
            InitializeComponent();
            albumName = title;
        }

        private void Album_Load(object sender, EventArgs e)
        {
            label1.Text = albumName;

            // get albums artist name
            MySqlDataReader msdr;
            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT artist FROM albums WHERE albumName = ?albumName";
            cmd.Parameters.AddWithValue("?albumName", albumName);

            using (msdr = cmd.ExecuteReader())
            {
                while (msdr.Read())
                {
                    string[] artist = new string[msdr.FieldCount];
                    for (int i = 0; i < msdr.FieldCount; i++)
                    {
                        artist[i] = msdr.GetValue(i).ToString();
                        label2.Text = "Artiest: " + artist[i];
                    }

                }
            }



            // get nummers uit database
            cmd.CommandText = "SELECT nummers.songName FROM albums JOIN album_nummers ON albums.albumID = album_nummers.albumID JOIN nummers ON album_nummers.songID = nummers.songID WHERE albums.albumName = ?title";
            cmd.Parameters.AddWithValue("?title", albumName);

            using (msdr = cmd.ExecuteReader())
            {
                while (msdr.Read())
                {
                    string[] nummers = new string[msdr.FieldCount];
                    for (int i = 0; i < msdr.FieldCount; i++)
                    {
                        nummers[i] = msdr.GetValue(i).ToString();
                        listBox2.Items.Add(nummers[i]);
                    }
                }
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Albums albumsUserControl = new Albums();
            albumsUserControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(albumsUserControl);
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                nowPlaying nowPlayingUserControl = new nowPlaying(listBox2.SelectedItem.ToString());
                nowPlayingUserControl.Dock = DockStyle.Fill;
                this.panel1.Controls.Clear();
                this.panel1.Controls.Add(nowPlayingUserControl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // get afspeellijsten uit database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT afspeellijstName FROM afspeellijsten";

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
            if (buttonvisible == false)
            {
                listBox1.Visible = true;
                buttonvisible = true;
            }
            else
            {
                listBox1.Visible = false;
                buttonvisible = false;
            }
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                // voeg alle nummers van album toe aan afspeellijst

                foreach (string nummer in listBox2.Items)
                {
                    // link nummer aan afspeellijst in de database

                    MySqlCommand cmd = con.CreateCommand();

                    cmd.CommandText = "INSERT INTO afspeellijst_nummers(afspeellijstID, songID) SELECT afspeellijsten.afspeellijstID, nummers.songID FROM afspeellijsten JOIN nummers ON nummers.songName = ?songTitle WHERE afspeellijsten.afspeellijstName = ?title";
                    cmd.Parameters.AddWithValue("?title", listBox1.SelectedItem);
                    cmd.Parameters.AddWithValue("?songTitle", nummer);

                    using MySqlDataReader data = cmd.ExecuteReader();
                }
                Speellijst SpeellijstUserControl = new Speellijst(listBox1.SelectedItem.ToString());
                SpeellijstUserControl.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(SpeellijstUserControl);
            }
        }
    }
}
