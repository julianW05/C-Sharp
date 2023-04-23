﻿namespace Spotify_App.UserControls
{
    partial class Albums
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
            AlbumsList = new ListBox();
            BtnBack = new Button();
            SuspendLayout();
            // 
            // AlbumsList
            // 
            AlbumsList.FormattingEnabled = true;
            AlbumsList.ItemHeight = 15;
            AlbumsList.Location = new Point(3, 2);
            AlbumsList.Margin = new Padding(3, 2, 3, 2);
            AlbumsList.Name = "AlbumsList";
            AlbumsList.Size = new Size(132, 124);
            AlbumsList.TabIndex = 2;
            AlbumsList.DoubleClick += AlbumsList_DoubleClick;
            // 
            // BtnBack
            // 
            BtnBack.Location = new Point(437, 2);
            BtnBack.Margin = new Padding(3, 2, 3, 2);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(82, 26);
            BtnBack.TabIndex = 3;
            BtnBack.Text = "Terug";
            BtnBack.UseVisualStyleBackColor = true;
            BtnBack.Click += BtnBack_Click;
            // 
            // Albums
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BtnBack);
            Controls.Add(AlbumsList);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Albums";
            Size = new Size(522, 338);
            Load += Albums_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox AlbumsList;
        private Button BtnBack;
    }
}
