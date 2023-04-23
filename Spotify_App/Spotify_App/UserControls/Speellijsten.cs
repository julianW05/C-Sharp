using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Spotify_App.UserControls
{
    public partial class Speellijsten : UserControl
    {
        bool buttonvisible = true;
        private static MySqlConnection con = Database.Instance().Connection;
        public Speellijsten()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
        }

        private void SpeellijstenList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SpeellijstAdd_Click(object sender, EventArgs e)
        {

            if (buttonvisible)
            {
                textBox1.Visible = true;
                SpeellijstConfirm.Visible = true;
                buttonvisible = false;
            }
            else
            {
                textBox1.Visible = false;
                SpeellijstConfirm.Visible = false;
                buttonvisible = true;
            }
        }

        public void SpeellijstConfirm_Click(object sender, EventArgs e)
        {
            // make add visual
            if (string.IsNullOrEmpty(textBox1.Text))
                return;
            SpeellijstenList.Items.Add(textBox1.Text);

            // database

            MySqlCommand cmd = con.CreateCommand();

            cmd.CommandText = "INSERT INTO afspeellijsten (afspeellijstName) VALUES (?title)";

            cmd.Parameters.AddWithValue("?title", textBox1.Text);

            using MySqlDataReader data = cmd.ExecuteReader();
            textBox1.Clear();
            textBox1.Focus();
        }

        private void BtnDelSpeellijst_Click(object sender, EventArgs e)
        {
            if (SpeellijstenList.SelectedIndex == -1)
            {
                return;
            }
            else if (SpeellijstenList.Items.Count >= 0)
            {
                // database

                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "DELETE FROM afspeellijsten WHERE afspeellijstName = ?title";

                cmd.Parameters.AddWithValue("?title", SpeellijstenList.SelectedItem);

                using MySqlDataReader data = cmd.ExecuteReader();
                SpeellijstenList.Items.RemoveAt(SpeellijstenList.SelectedIndex);
            }
        }

        private void SpeellijstenList_DoubleClick(object sender, EventArgs e)
        {
            if (SpeellijstenList.SelectedIndex == -1)
            {
                return;
            }
            else
            {
                Speellijst speellijstUserControl = new Speellijst(SpeellijstenList.SelectedItem.ToString());
                speellijstUserControl.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(speellijstUserControl);
            }
        }

        private void Speellijsten_Load(object sender, EventArgs e)
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
                    SpeellijstenList.Items.Add(afspeellijsten[i]);
                }

            }

        }
    }
}
