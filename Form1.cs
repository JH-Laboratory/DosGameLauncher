using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace DosGameLauncher
{
    public partial class Form1 : Form
    {
        //Important Variables
        Point lastPoint;
        string VERSION = "0.1a";

        public Form1()
        {
            /////////Init//////////////////
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray;
            TransparencyKey = Color.Gray;
            /////////.//////////////////
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //WebClient client = new WebClient();
            //Stream streamNews = client.OpenRead("http://helheim.vikingtactical.wtf/serverinfo/news.txt");
            //StreamReader readerNews = new StreamReader(streamNews);
            //String contentNews = readerNews.ReadToEnd();
            lblLauncherVer.Text = "Launcher v" + VERSION;
        }

        private void lblMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; // Program mimimize
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Program close
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void lblPlay_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process gDoom = new System.Diagnostics.Process();
            gDoom.StartInfo.FileName = "data\\dosbox\\DosBox.exe";
            gDoom.StartInfo.Arguments = "data\\doom\\DOOM.exe";
            gDoom.Start();
        }

        private void btnForums_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://helheim.vikingtactical.wtf/"); // Open forums
        }


        private void btndiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://discord.gg/mu9zJCG"); // Open Helheim discord
        }


    }
}
