namespace Spotify_App.UserControls
{
    partial class Speellijst
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnBack = new Button();
            afspeellijstTitle = new Label();
            BtnAddSong = new Button();
            listBox1 = new ListBox();
            nummersLabel = new Label();
            listBox2 = new ListBox();
            BtnRemSong = new Button();
            listBox3 = new ListBox();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(437, 2);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 27);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // afspeellijstTitle
            // 
            afspeellijstTitle.AutoSize = true;
            afspeellijstTitle.Location = new Point(7, 7);
            afspeellijstTitle.Name = "afspeellijstTitle";
            afspeellijstTitle.Size = new Size(38, 15);
            afspeellijstTitle.TabIndex = 2;
            afspeellijstTitle.Text = "label1";
            // 
            // BtnAddSong
            // 
            BtnAddSong.Location = new Point(91, 7);
            BtnAddSong.Margin = new Padding(3, 2, 3, 2);
            BtnAddSong.Name = "BtnAddSong";
            BtnAddSong.Size = new Size(98, 38);
            BtnAddSong.TabIndex = 3;
            BtnAddSong.Text = "Nummer toevoegen";
            BtnAddSong.UseVisualStyleBackColor = true;
            BtnAddSong.Click += BtnAddSong_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(91, 53);
            listBox1.Margin = new Padding(3, 2, 3, 2);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(98, 109);
            listBox1.TabIndex = 4;
            listBox1.Visible = false;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // nummersLabel
            // 
            nummersLabel.AutoSize = true;
            nummersLabel.Location = new Point(308, 18);
            nummersLabel.Name = "nummersLabel";
            nummersLabel.Size = new Size(60, 15);
            nummersLabel.TabIndex = 5;
            nummersLabel.Text = "Nummers";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(308, 53);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(132, 79);
            listBox2.TabIndex = 6;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // BtnRemSong
            // 
            BtnRemSong.Location = new Point(198, 7);
            BtnRemSong.Margin = new Padding(3, 2, 3, 2);
            BtnRemSong.Name = "BtnRemSong";
            BtnRemSong.Size = new Size(98, 38);
            BtnRemSong.TabIndex = 7;
            BtnRemSong.Text = "Nummer verwijderen";
            BtnRemSong.UseVisualStyleBackColor = true;
            BtnRemSong.Click += BtnRemSong_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 15;
            listBox3.Location = new Point(198, 53);
            listBox3.Margin = new Padding(3, 2, 3, 2);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(98, 109);
            listBox3.TabIndex = 8;
            listBox3.Visible = false;
            listBox3.DoubleClick += listBox3_DoubleClick;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 248);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 89);
            panel1.TabIndex = 9;
            // 
            // Speellijst
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(listBox3);
            Controls.Add(BtnRemSong);
            Controls.Add(listBox2);
            Controls.Add(nummersLabel);
            Controls.Add(listBox1);
            Controls.Add(BtnAddSong);
            Controls.Add(afspeellijstTitle);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Speellijst";
            Size = new Size(522, 338);
            Load += Speellijst_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private Label afspeellijstTitle;
        private Button BtnAddSong;
        private ListBox listBox1;
        private Label nummersLabel;
        private ListBox listBox2;
        private Button BtnRemSong;
        private ListBox listBox3;
        private Panel panel1;
    }
}
