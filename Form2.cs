using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
namespace MusicPlayerApp
{
    public partial class Form2 : Form
    {
        WindowsMediaPlayer p=new WindowsMediaPlayer();
        public Form2()
        {
            InitializeComponent();
            p.URL = "Charlie Movie ! BGM.mp3";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            p.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string s1 = label1.Text;
            string s2 = s1.Substring(0, 1);
            string s3=s1.Substring(1, s1.Length-1);
            string s4= s3 + s2;
            label1.Text = s4;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           MusicPlayerApp p2= new MusicPlayerApp();
            p2.Show();
            p.controls.stop();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3=new Form3();
            f3.Show();
            p.controls.stop();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=VQ2-HPwxAZY&list=RDVQ2-HPwxAZY&start_radio=1");
            p.controls.stop();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://open.spotify.com/artist/5sSzCxHtgL82pYDvx2QyEU");
            p.controls.stop();
        }

        
    }
}
