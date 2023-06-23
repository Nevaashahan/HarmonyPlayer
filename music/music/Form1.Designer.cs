namespace music
{
    partial class MusicPlayerApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayerApp));
            this.panel1 = new System.Windows.Forms.Panel();
            this.MusicPlayer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ListBoxSongs = new System.Windows.Forms.ListBox();
            this.SelectSongs = new System.Windows.Forms.Button();
            this.creator = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.MusicPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 41);
            this.panel1.TabIndex = 0;
            // 
            // MusicPlayer
            // 
            this.MusicPlayer.AutoSize = true;
            this.MusicPlayer.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MusicPlayer.Location = new System.Drawing.Point(12, 9);
            this.MusicPlayer.Name = "MusicPlayer";
            this.MusicPlayer.Size = new System.Drawing.Size(129, 19);
            this.MusicPlayer.TabIndex = 1;
            this.MusicPlayer.Text = "Music Player";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(772, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ListBoxSongs
            // 
            this.ListBoxSongs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBoxSongs.FormattingEnabled = true;
            this.ListBoxSongs.ItemHeight = 20;
            this.ListBoxSongs.Location = new System.Drawing.Point(587, 47);
            this.ListBoxSongs.Name = "ListBoxSongs";
            this.ListBoxSongs.Size = new System.Drawing.Size(201, 304);
            this.ListBoxSongs.TabIndex = 1;
            this.ListBoxSongs.SelectedIndexChanged += new System.EventHandler(this.ListBoxSongs_SelectedIndexChanged);
            // 
            // SelectSongs
            // 
            this.SelectSongs.BackColor = System.Drawing.Color.Aqua;
            this.SelectSongs.Location = new System.Drawing.Point(587, 357);
            this.SelectSongs.Name = "SelectSongs";
            this.SelectSongs.Size = new System.Drawing.Size(201, 46);
            this.SelectSongs.TabIndex = 2;
            this.SelectSongs.Text = "Select Songs";
            this.SelectSongs.UseVisualStyleBackColor = false;
            this.SelectSongs.Click += new System.EventHandler(this.SelectSongs_Click);
            // 
            // creator
            // 
            this.creator.AutoSize = true;
            this.creator.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.creator.Location = new System.Drawing.Point(-3, 426);
            this.creator.Name = "creator";
            this.creator.Size = new System.Drawing.Size(202, 16);
            this.creator.TabIndex = 4;
            this.creator.Text = "Developed by : Nevaashahan T.";
            this.creator.Click += new System.EventHandler(this.creator_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 47);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(393, 278);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // MusicPlayerApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.creator);
            this.Controls.Add(this.SelectSongs);
            this.Controls.Add(this.ListBoxSongs);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicPlayerApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music Player App";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label MusicPlayer;
        private System.Windows.Forms.ListBox ListBoxSongs;
        private System.Windows.Forms.Button SelectSongs;
        private System.Windows.Forms.Label creator;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

