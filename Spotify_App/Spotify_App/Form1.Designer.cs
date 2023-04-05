namespace Spotify_App
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.BtnVrienden = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnVriendenTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(104, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Speellijsten";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // BtnVrienden
            // 
            this.BtnVrienden.BackColor = System.Drawing.Color.White;
            this.BtnVrienden.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVrienden.Location = new System.Drawing.Point(316, 147);
            this.BtnVrienden.Name = "BtnVrienden";
            this.BtnVrienden.Size = new System.Drawing.Size(75, 23);
            this.BtnVrienden.TabIndex = 1;
            this.BtnVrienden.Text = "Vrienden";
            this.BtnVrienden.UseVisualStyleBackColor = false;
            this.BtnVrienden.Click += new System.EventHandler(this.BtnVrienden_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(217, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Albums";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnVriendenTerug
            // 
            this.BtnVriendenTerug.BackColor = System.Drawing.Color.White;
            this.BtnVriendenTerug.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnVriendenTerug.Location = new System.Drawing.Point(217, 195);
            this.BtnVriendenTerug.Name = "BtnVriendenTerug";
            this.BtnVriendenTerug.Size = new System.Drawing.Size(75, 23);
            this.BtnVriendenTerug.TabIndex = 3;
            this.BtnVriendenTerug.Text = "Terug";
            this.BtnVriendenTerug.UseVisualStyleBackColor = false;
            this.BtnVriendenTerug.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(509, 358);
            this.Controls.Add(this.BtnVriendenTerug);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnVrienden);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Spotify";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button BtnVrienden;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnVriendenTerug;
    }
}

