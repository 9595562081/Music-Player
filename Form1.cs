using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayerApp
{
    public partial class MusicPlayerApp : Form
    {
        public MusicPlayerApp()
        {
            InitializeComponent();
        }
        //create global variables of string type array to save the titles or name of the Tracks and paths of the trackstring
        string[] paths, files;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //code to select song
            OpenFileDialog ofd= new OpenFileDialog();
            //code to select multiple songs
            ofd.Multiselect = true;
            if(ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK )
            {
                files= ofd.SafeFileNames;//save the name of track in file array
                paths= ofd.FileNames;//save the paths of the track in path array
                //Dispaly the music titles in listbox
                for(int i=0; i<files.Length; i++)
                {
                    listBoxSongs.Items.Add(files[i]);//Display Songs in ListBox

                }
            }
        }

        private void listBoxSongs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //write a code to play music 
            axWindowsMediaPlayer1.URL = paths[listBoxSongs.SelectedIndex];
            //listBoxSongs.SelectedIndex = 0;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Qc_NUm6_hbc");    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //code to close the app
            this.Close();
        }
    }
}
