namespace Spotify_App.UserControls
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
            SuspendLayout();
            // 
            // AlbumsList
            // 
            AlbumsList.FormattingEnabled = true;
            AlbumsList.ItemHeight = 20;
            AlbumsList.Location = new Point(3, 3);
            AlbumsList.Name = "AlbumsList";
            AlbumsList.Size = new Size(150, 164);
            AlbumsList.TabIndex = 2;
            // 
            // Albums
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AlbumsList);
            Name = "Albums";
            Size = new Size(596, 450);
            ResumeLayout(false);
        }

        #endregion

        private ListBox AlbumsList;
    }
}
