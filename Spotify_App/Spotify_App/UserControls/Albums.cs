﻿using MySql.Data.MySqlClient;
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
    public partial class Albums : UserControl
    {
        private static MySqlConnection con = Database.Instance().Connection;
        public Albums()
        {
            InitializeComponent();
        }

        private void Albums_Load(object sender, EventArgs e)
        {
            // get albums uit database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "SELECT albumName FROM albums";

            using MySqlDataReader data = cmd.ExecuteReader();

            while (data.Read())
            {
                string[] albums = new string[data.FieldCount];
                for (int i = 0; i < data.FieldCount; i++)
                {
                    albums[i] = data.GetValue(i).ToString();
                    AlbumsList.Items.Add(albums[i]);
                }

            }
        }

        private void AlbumsList_DoubleClick(object sender, EventArgs e)
        {
            if (AlbumsList.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Album albumUserControl = new Album(AlbumsList.SelectedItem.ToString());
                albumUserControl.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(albumUserControl);
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }
    }
}
