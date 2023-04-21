using MySql.Data.MySqlClient;
using Mysqlx.Crud;
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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Spotify_App.UserControls
{
    public partial class Speellijst : UserControl
    {
        List<string> Nummers = new List<string>();
        private static MySqlConnection con = Database.Instance().Connection;
        bool buttonvisibleRem = true;
        bool buttonvisible = true;
        string Title;
        public Speellijst(string title)
        {
            InitializeComponent();
            Title = title;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Speellijsten speellijstenUserControl = new Speellijsten();
            speellijstenUserControl.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(speellijstenUserControl);
        }

        private void Speellijst_Load(object sender, EventArgs e)
        {
            afspeellijstTitle.Text = Title;
            // get nummers uit database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT nummers.songName FROM afspeellijsten JOIN afspeellijst_nummers ON afspeellijsten.afspeellijstID = afspeellijst_nummers.afspeellijstID JOIN nummers ON afspeellijst_nummers.songID = nummers.songID WHERE afspeellijsten.afspeellijstName = ?title";
            cmd.Parameters.AddWithValue("?title", afspeellijstTitle.Text);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] nummers = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    nummers[i] = data.GetValue(i).ToString();
                    listBox2.Items.Add(nummers[i]);
                }
                foreach (string nummer in nummers)
                {
                    Nummers.Add(nummer);
                }

            }
        }

        private void BtnAddSong_Click(object sender, EventArgs e)
        {
            // get nummers uit database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT nummers.songName FROM nummers WHERE NOT EXISTS( SELECT 1 FROM afspeellijst_nummers WHERE afspeellijst_nummers.songID = nummers.songID AND afspeellijst_nummers.afspeellijstID = ( SELECT afspeellijstID FROM afspeellijsten WHERE afspeellijstName = ?title ) )";
            cmd.Parameters.AddWithValue("?title", afspeellijstTitle.Text);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] nummers = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    nummers[i] = data.GetValue(i).ToString();
                    listBox1.Items.Add(nummers[i]);
                }

            }
            if (buttonvisible)
            {
                listBox1.Visible = true;
                buttonvisible = false;
            }
            else
            {
                listBox1.Visible = false;
                buttonvisible = true;
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
                // link nummer aan afspeellijst in de database

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO afspeellijst_nummers(afspeellijstID, songID) SELECT afspeellijsten.afspeellijstID, nummers.songID FROM afspeellijsten JOIN nummers ON nummers.songName = ?songTitle WHERE afspeellijsten.afspeellijstName = ?title";
                cmd.Parameters.AddWithValue("?title", afspeellijstTitle.Text);
                cmd.Parameters.AddWithValue("?songTitle", listBox1.SelectedItem);

                using MySqlDataReader data = cmd.ExecuteReader();

                listBox2.Items.Add(listBox1.SelectedItem);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void BtnRemSong_Click(object sender, EventArgs e)
        {
            // get nummers uit database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT nummers.songName FROM afspeellijsten JOIN afspeellijst_nummers ON afspeellijsten.afspeellijstID = afspeellijst_nummers.afspeellijstID JOIN nummers ON afspeellijst_nummers.songID = nummers.songID WHERE afspeellijsten.afspeellijstName = ?title";
            cmd.Parameters.AddWithValue("?title", afspeellijstTitle.Text);

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] nummers = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    nummers[i] = data.GetValue(i).ToString();
                    listBox3.Items.Add(nummers[i]);
                }
            }
            if (buttonvisibleRem)
            {
                listBox3.Visible = true;
                buttonvisibleRem = false;
            }
            else
            {
                listBox3.Visible = false;
                buttonvisibleRem = true;
            }
        }

        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            if (listBox3.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                // link nummer aan afspeellijst in de database

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "DELETE FROM afspeellijst_nummers WHERE afspeellijstID = ( SELECT afspeellijstID FROM afspeellijsten WHERE afspeellijstName = ?title ) AND songID = ( SELECT songID FROM nummers WHERE songName = ?songTitle )";
                cmd.Parameters.AddWithValue("?title", afspeellijstTitle.Text);
                cmd.Parameters.AddWithValue("?songTitle", listBox3.SelectedItem);

                using MySqlDataReader data = cmd.ExecuteReader();

                listBox1.Items.Add(listBox3.SelectedItem);
                listBox2.Items.Remove(listBox3.SelectedItem);
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
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
    }
}
