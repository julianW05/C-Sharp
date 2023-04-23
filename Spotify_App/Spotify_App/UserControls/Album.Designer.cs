namespace Spotify_App.UserControls
{
    partial class Album
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
            label1 = new Label();
            label2 = new Label();
            BtnBack = new Button();
            listBox2 = new ListBox();
            nummersLabel = new Label();
            panel1 = new Panel();
            button1 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 12);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 39);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(437, 2);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 26);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(198, 39);
            listBox2.Margin = new Padding(3, 2, 3, 2);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(132, 79);
            listBox2.TabIndex = 8;
            listBox2.DoubleClick += listBox2_DoubleClick;
            // 
            // nummersLabel
            // 
            nummersLabel.AutoSize = true;
            nummersLabel.Location = new Point(198, 12);
            nummersLabel.Name = "nummersLabel";
            nummersLabel.Size = new Size(60, 15);
            nummersLabel.TabIndex = 7;
            nummersLabel.Text = "Nummers";
            // 
            // panel1
            // 
            panel1.Location = new Point(0, 249);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(522, 89);
            panel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.Location = new Point(13, 69);
            button1.Name = "button1";
            button1.Size = new Size(90, 49);
            button1.TabIndex = 11;
            button1.Text = "Voeg toe aan afspeellijst";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 124);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 109);
            listBox1.TabIndex = 12;
            listBox1.Visible = false;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // Album
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(listBox2);
            Controls.Add(nummersLabel);
            Controls.Add(BtnBack);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Album";
            Size = new Size(522, 338);
            Load += Album_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button BtnBack;
        private ListBox listBox2;
        private Label nummersLabel;
        private Panel panel1;
        private Button button1;
        private ListBox listBox1;
    }
}
