namespace Juke_Box_Final
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txt_genera = new System.Windows.Forms.TextBox();
            this.lst_genera = new System.Windows.Forms.ListBox();
            this.txt_playing = new System.Windows.Forms.TextBox();
            this.lst_playlist = new System.Windows.Forms.ListBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hierarchy_menu = new System.Windows.Forms.MenuStrip();
            this.setUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.hierarchy_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_genera
            // 
            this.txt_genera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_genera.Location = new System.Drawing.Point(117, 165);
            this.txt_genera.Name = "txt_genera";
            this.txt_genera.ReadOnly = true;
            this.txt_genera.Size = new System.Drawing.Size(228, 20);
            this.txt_genera.TabIndex = 0;
            this.txt_genera.Text = "General";
            // 
            // lst_genera
            // 
            this.lst_genera.FormattingEnabled = true;
            this.lst_genera.Location = new System.Drawing.Point(117, 191);
            this.lst_genera.Name = "lst_genera";
            this.lst_genera.Size = new System.Drawing.Size(228, 121);
            this.lst_genera.TabIndex = 1;
            // 
            // txt_playing
            // 
            this.txt_playing.BackColor = System.Drawing.Color.Lime;
            this.txt_playing.Location = new System.Drawing.Point(117, 318);
            this.txt_playing.Name = "txt_playing";
            this.txt_playing.ReadOnly = true;
            this.txt_playing.Size = new System.Drawing.Size(228, 20);
            this.txt_playing.TabIndex = 2;
            this.txt_playing.TextChanged += new System.EventHandler(this.txt_playing_TextChanged);
            // 
            // lst_playlist
            // 
            this.lst_playlist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lst_playlist.FormattingEnabled = true;
            this.lst_playlist.Location = new System.Drawing.Point(161, 344);
            this.lst_playlist.Name = "lst_playlist";
            this.lst_playlist.Size = new System.Drawing.Size(135, 147);
            this.lst_playlist.TabIndex = 3;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(117, 286);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(228, 26);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar1_Scroll);
            // 
            // hierarchy_menu
            // 
            this.hierarchy_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hierarchy_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setUpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.hierarchy_menu.Location = new System.Drawing.Point(0, 642);
            this.hierarchy_menu.Name = "hierarchy_menu";
            this.hierarchy_menu.Size = new System.Drawing.Size(459, 24);
            this.hierarchy_menu.TabIndex = 5;
            this.hierarchy_menu.Text = "hierarchy_menu";
            // 
            // setUpToolStripMenuItem
            // 
            this.setUpToolStripMenuItem.Name = "setUpToolStripMenuItem";
            this.setUpToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.setUpToolStripMenuItem.Text = "SetUp";
            this.setUpToolStripMenuItem.Click += new System.EventHandler(this.setUpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.AutoSize = true;
            this.lbl_copyright.BackColor = System.Drawing.Color.Black;
            this.lbl_copyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_copyright.ForeColor = System.Drawing.Color.White;
            this.lbl_copyright.Location = new System.Drawing.Point(203, 9);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(256, 20);
            this.lbl_copyright.TabIndex = 6;
            this.lbl_copyright.Text = "Copyight©2010 Dr.Peter 0\'Neill";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(50, 64);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(356, 52);
            this.axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Juke_Box_Final.Properties.Resources.Jukeboxx;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 666);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.lbl_copyright);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.lst_playlist);
            this.Controls.Add(this.txt_playing);
            this.Controls.Add(this.lst_genera);
            this.Controls.Add(this.txt_genera);
            this.Controls.Add(this.hierarchy_menu);
            this.MainMenuStrip = this.hierarchy_menu;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My Juke Box v1.0";
            this.hierarchy_menu.ResumeLayout(false);
            this.hierarchy_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_genera;
        private System.Windows.Forms.ListBox lst_genera;
        private System.Windows.Forms.TextBox txt_playing;
        private System.Windows.Forms.ListBox lst_playlist;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip hierarchy_menu;
        private System.Windows.Forms.ToolStripMenuItem setUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lbl_copyright;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

