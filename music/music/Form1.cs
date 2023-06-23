using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace music
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }

        //Create Global Variables of String Type Array to save the titles or name of the tracks and path of the track

        String[] paths, files;
        private object listBoxSongs;

        private void creator_Click(object sender, EventArgs e)
        {

        }

        private void SelectSongs_Click(object sender, EventArgs e)
        {
            //code to select songs
            OpenFileDialog ofd= new OpenFileDialog();
            //code to select multiple song files
            ofd.Multiselect= true;  
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                 files= ofd.SafeFileNames;  //Save the names of the track in files array
                 paths= ofd.FileNames; //Save the paths of the tracks in path array
                //Display the music titles in listbox
                for(int i = 0; i < files.Length; i++)
                {
                    ListBoxSongs.Items.Add(files[i]);   //Display Songs in Listbox
                }
            }
        }

        private void ListBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Write a code to play music
            axWindowsMediaPlayer1.URL= paths[ListBoxSongs.SelectedIndex];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Code to Close the App
            this.Close();
        }
    }
}
