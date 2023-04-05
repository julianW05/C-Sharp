namespace Spotify_App
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnVriendenTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnVriendenTerug
            // 
            this.BtnVriendenTerug.BackColor = System.Drawing.Color.White;
            this.BtnVriendenTerug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVriendenTerug.Location = new System.Drawing.Point(217, 168);
            this.BtnVriendenTerug.Name = "BtnVriendenTerug";
            this.BtnVriendenTerug.Size = new System.Drawing.Size(75, 23);
            this.BtnVriendenTerug.TabIndex = 2;
            this.BtnVriendenTerug.Text = "Terug";
            this.BtnVriendenTerug.UseVisualStyleBackColor = false;
            this.BtnVriendenTerug.Click += new System.EventHandler(this.BtnVriendenTerug_Click);
            // 
            // Vrienden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(509, 358);
            this.Controls.Add(this.BtnVriendenTerug);
            this.Name = "Vrienden";
            this.Text = "Vrienden";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnVriendenTerug;
    }
}