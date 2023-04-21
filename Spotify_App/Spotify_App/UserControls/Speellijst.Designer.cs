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
            BtnBack.Location = new Point(499, 3);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(94, 29);
            BtnBack.TabIndex = 1;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // afspeellijstTitle
            // 
            afspeellijstTitle.AutoSize = true;
            afspeellijstTitle.Location = new Point(8, 9);
            afspeellijstTitle.Name = "afspeellijstTitle";
            afspeellijstTitle.Size = new Size(50, 20);
            afspeellijstTitle.TabIndex = 2;
            afspeellijstTitle.Text = "label1";
            // 
            // BtnAddSong
            // 
            BtnAddSong.Location = new Point(104, 9);
            BtnAddSong.Name = "BtnAddSong";
            BtnAddSong.Size = new Size(112, 50);
            BtnAddSong.TabIndex = 3;
            BtnAddSong.Text = "Nummer toevoegen";
            BtnAddSong.UseVisualStyleBackColor = true;
            BtnAddSong.Click += BtnAddSong_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(104, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(112, 144);
            listBox1.TabIndex = 4;
            listBox1.Visible = false;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // nummersLabel
            // 
            nummersLabel.AutoSize = true;
            nummersLabel.Location = new Point(352, 24);
            nummersLabel.Name = "nummersLabel";
            nummersLabel.Size = new Size(73, 20);
            nummersLabel.TabIndex = 5;
            nummersLabel.Text = "Nummers";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 20;
            listBox2.Location = new Point(352, 71);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(150, 104);
            listBox2.TabIndex = 6;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // BtnRemSong
            // 
            BtnRemSong.Location = new Point(226, 9);
            BtnRemSong.Name = "BtnRemSong";
            BtnRemSong.Size = new Size(112, 50);
            BtnRemSong.TabIndex = 7;
            BtnRemSong.Text = "Nummer verwijderen";
            BtnRemSong.UseVisualStyleBackColor = true;
            BtnRemSong.Click += BtnRemSong_Click;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.ItemHeight = 20;
            listBox3.Location = new Point(226, 71);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(112, 144);
            listBox3.TabIndex = 8;
            listBox3.Visible = false;
            listBox3.DoubleClick += listBox3_DoubleClick;
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 331);
            panel1.Name = "panel1";
            panel1.Size = new Size(596, 119);
            panel1.TabIndex = 9;
            // 
            // Speellijst
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
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
            Name = "Speellijst";
            Size = new Size(596, 450);
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
