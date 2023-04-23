namespace Spotify_App.UserControls
{
    partial class Speellijsten
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
            SpeellijstenList = new ListBox();
            SpeellijstAdd = new Button();
            SpeellijstConfirm = new Button();
            textBox1 = new TextBox();
            BtnDelSpeellijst = new Button();
            SuspendLayout();
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(437, 2);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 27);
            BtnBack.TabIndex = 0;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // SpeellijstenList
            // 
            SpeellijstenList.FormattingEnabled = true;
            SpeellijstenList.ItemHeight = 15;
            SpeellijstenList.Location = new Point(3, 2);
            SpeellijstenList.Margin = new Padding(3, 2, 3, 2);
            SpeellijstenList.Name = "SpeellijstenList";
            SpeellijstenList.Size = new Size(132, 124);
            SpeellijstenList.TabIndex = 1;
            SpeellijstenList.SelectedIndexChanged += SpeellijstenList_SelectedIndexChanged;
            SpeellijstenList.DoubleClick += SpeellijstenList_DoubleClick;
            // 
            // SpeellijstAdd
            // 
            SpeellijstAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SpeellijstAdd.Location = new Point(139, 2);
            SpeellijstAdd.Margin = new Padding(3, 2, 3, 2);
            SpeellijstAdd.Name = "SpeellijstAdd";
            SpeellijstAdd.Size = new Size(106, 58);
            SpeellijstAdd.TabIndex = 2;
            SpeellijstAdd.Text = "Speellijst aanmaken";
            SpeellijstAdd.UseVisualStyleBackColor = true;
            SpeellijstAdd.Click += SpeellijstAdd_Click;
            // 
            // SpeellijstConfirm
            // 
            SpeellijstConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SpeellijstConfirm.Location = new Point(139, 90);
            SpeellijstConfirm.Margin = new Padding(3, 2, 3, 2);
            SpeellijstConfirm.Name = "SpeellijstConfirm";
            SpeellijstConfirm.Size = new Size(106, 49);
            SpeellijstConfirm.TabIndex = 3;
            SpeellijstConfirm.Text = "Toevoegen";
            SpeellijstConfirm.UseVisualStyleBackColor = true;
            SpeellijstConfirm.Visible = false;
            SpeellijstConfirm.Click += SpeellijstConfirm_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 64);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 4;
            textBox1.Visible = false;
            // 
            // BtnDelSpeellijst
            // 
            BtnDelSpeellijst.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BtnDelSpeellijst.Location = new Point(250, 2);
            BtnDelSpeellijst.Margin = new Padding(3, 2, 3, 2);
            BtnDelSpeellijst.Name = "BtnDelSpeellijst";
            BtnDelSpeellijst.Size = new Size(113, 58);
            BtnDelSpeellijst.TabIndex = 5;
            BtnDelSpeellijst.Text = "Speellijst Verwijderen";
            BtnDelSpeellijst.UseVisualStyleBackColor = true;
            BtnDelSpeellijst.Click += BtnDelSpeellijst_Click;
            // 
            // Speellijsten
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnDelSpeellijst);
            Controls.Add(textBox1);
            Controls.Add(SpeellijstConfirm);
            Controls.Add(SpeellijstAdd);
            Controls.Add(SpeellijstenList);
            Controls.Add(BtnBack);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Speellijsten";
            Size = new Size(522, 338);
            Load += Speellijsten_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnBack;
        private ListBox SpeellijstenList;
        private Button SpeellijstAdd;
        private Button SpeellijstConfirm;
        private TextBox textBox1;
        private Button BtnDelSpeellijst;
    }
}
