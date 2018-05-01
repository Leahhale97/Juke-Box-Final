using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Juke_Box_Final
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string MediaPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath); // global string variable of the directory to media path
        public int NumberofGenre; // global integer variable 
        ListBox[] mediaLibrary;
        bool SongPlaying = false; // global boolean variable

        private void Show_form(object sender, EventArgs e)
        {
            Load_data(); // call the private void called "Load_Data"
        }

        private void Load_data()
        {
            int total_genrea; // declare local variable
            int total_tracks; // declare local variable

            string AppPath = Directory.GetCurrentDirectory() + "\\Media\\"; // find the folder called "\\Media\\"
            StreamReader MediaFile = File.OpenText(AppPath + "Media.txt"); // open the file called "Media.txt"

            total_genrea = Convert.ToInt32(MediaFile.ReadLine());
            mediaLibrary = new ListBox[total_genrea];
            for (int g = 0; g < total_genrea; g++)
            {
                mediaLibrary[g] = new ListBox();
                total_tracks = Convert.ToInt32(MediaFile.ReadLine());
                for (int t = 0; t <= total_tracks; t++)

                {
                    mediaLibrary[g].Items.Add(MediaFile.ReadLine());
                }

            }

                MediaFile.Close();

            Update_Jukebox(2);
            
        }
        private void Update_Jukebox(int index)
        {

            lst_genera.Items.Clear(); // Clears the list box.
            txt_genera.Text = string.Empty; // clears the text box.

            txt_genera.Text = mediaLibrary[index].Items[0].ToString(); // display the first index in the media file within this text box.
            for (int i = 1; i < mediaLibrary[index].Items.Count; i++) // continue to display all the values in the file 1 by 1.
            {
                lst_genera.Items.Add(mediaLibrary[index].Items.ToString());
            }
           
        }

        private void lst_Genera_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            String playlist = lst_genera.SelectedItem.ToString(); // when a song is double clicked on in the lst_Genera,
            lst_playlist.Items.Add(playlist); // it then moves it into the lst_playlist box.
        }

        private void lst_Genera_SelectedIndexChanged(object sender, EventArgs e)
        {
            int SongIndex = lst_genera.SelectedIndex; 
            String SongSelected = lst_genera.Items[SongIndex].ToString();

            if (SongPlaying == true) // if valid

            {
                lst_playlist.Items.Add(SongSelected); //  add the selected song to the "lst_playlist" box.

            }
            else if (SongPlaying == false && lst_playlist.Items.Count == 0)
            {
                txt_playing.Text = SongSelected; 
                String PathOfTrack = Directory.GetCurrentDirectory() + "\\Tracks\\"; // file path to the file "Tracks"
                axWindowsMediaPlayer1.URL = PathOfTrack + SongSelected; //  depending on the track in the "txt_playing" box and the track selected in the file,
                axWindowsMediaPlayer1.Ctlcontrols.play(); // will be played when the user presses play.
                SongPlaying = true;
            }
        }



        private void setUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setup myForm = new Setup(); //show Form2
            myForm.Show();
            this.Hide();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About myForm = new About(); //show Form3
            myForm.Show();
            this.Hide();
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Update_Jukebox(hScrollBar1.Value); // Enables the user to go the genrea's via ths scroll bar. 
        }

        private void txt_playing_TextChanged(object sender, EventArgs e)
        {
            txt_playing.Text = string.Empty; // clear this text box 
            String currently_playing = lst_playlist.SelectedItem.ToString(); // display the song playing in the "lst_playlist"

        }
    }
}
