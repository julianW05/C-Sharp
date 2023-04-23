namespace Spotify_App.UserControls
{
    partial class Vrienden
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
            VriendenList = new ListBox();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // VriendenList
            // 
            VriendenList.FormattingEnabled = true;
            VriendenList.ItemHeight = 15;
            VriendenList.Location = new Point(3, 2);
            VriendenList.Margin = new Padding(3, 2, 3, 2);
            VriendenList.Name = "VriendenList";
            VriendenList.Size = new Size(132, 124);
            VriendenList.TabIndex = 2;
            VriendenList.DoubleClick += VriendenList_DoubleClick;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(437, 2);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 27);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Vrienden
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnBack);
            Controls.Add(VriendenList);
            Name = "Vrienden";
            Size = new Size(522, 338);
            Load += Vrienden_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox VriendenList;
        private Button BtnBack;
    }
}
