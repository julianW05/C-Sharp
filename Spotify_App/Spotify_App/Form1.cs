using Spotify_App.UserControls;

namespace Spotify_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Speellijsten speellijstenUserControl = new Speellijsten();
            speellijstenUserControl.Dock = DockStyle.Fill;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(speellijstenUserControl);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Albums albumsUserControl = new Albums();
            albumsUserControl.Dock = DockStyle.Fill;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(albumsUserControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Vrienden vriendenUserControl = new Vrienden();
            vriendenUserControl.Dock = DockStyle.Fill;
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(vriendenUserControl);
        }
    }
}