namespace Spotify_App.UserControls
{
    partial class Vriend
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
            BtnBack = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(437, 2);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 27);
            BtnBack.TabIndex = 4;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 10);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 5;
            label2.Text = "Speellijsten";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(178, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 6;
            listBox1.DoubleClick += listBox1_DoubleClick;
            // 
            // Vriend
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(BtnBack);
            Controls.Add(label1);
            Name = "Vriend";
            Size = new Size(522, 338);
            Load += Vriend_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnBack;
        private Label label2;
        private ListBox listBox1;
    }
}
