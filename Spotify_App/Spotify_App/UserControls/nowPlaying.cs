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
    public partial class nowPlaying : UserControl
    {
        private static MySqlConnection con = Database.Instance().Connection;
        string songName;
        bool pauze = false;
        public nowPlaying(string SongName)
        {
            InitializeComponent();
            songName = SongName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nowPlaying_Load(object sender, EventArgs e)
        {
            label1.Text = "Now playing: " + songName;

            // get song artist name

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT artist FROM nummers WHERE songName = ?songName";
            cmd.Parameters.AddWithValue("?songName", songName);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] artist = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    artist[i] = data.GetValue(i).ToString();
                    label2.Text = "Artiest: " + artist[i];
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pauze == false)
            {
                label1.Text = "Gepauzeerd: " + songName;
                pauze = true;
            }
            else
            {
                pauze = false;
                label1.Text = "Now playing: " + songName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
