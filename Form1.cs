﻿using System;
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

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnPlay_Click(object sender, EventArgs e)
        {

            string gSelection = "NULL";

            //Hunter's Faves list:
            if (glistHunterFaves.Text == "Wolfenstein3D")
            {
                gSelection = "data\\WOLF3D\\WOLF3D.exe";
            }

            else if (glistHunterFaves.Text == "DOOM")
            {
                gSelection = "data\\doom\\DOOM.exe";
            }

            else if (glistHunterFaves.Text == "Transport Tycoon Deluxe")
            {
                gSelection = "data\\ttd\\TYCOON.exe";
            }

            else if (glistHunterFaves.Text == "SimCity")
            {
                gSelection = "data\\simcity\\SIMCITY.exe";
            }

            else if (glistHunterFaves.Text == "Oregon Trail")
            {
                gSelection = "data\\oregontrail\\OREGON.exe";
            }

            else if (glistHunterFaves.Text == "Civilization")
            {
                gSelection = "data\\civ\\CIV.exe";
            }

            else if (glistHunterFaves.Text == "The Elder Scrolls: Arena")
            {
                gSelection = "data\\arena\\ARENA.bat";
            }

            else if (glistHunterFaves.Text == "Tetris")
            {
                gSelection = "data\\tetris\\TETRIS.bat";
            }

            else if (glistHunterFaves.Text == "Quake")
            {
                gSelection = "data\\quake\\quake.exe";
            }

            else if (glistHunterFaves.Text == "C&C Red Alert")
            {
                gSelection = "data\\CC-RedAlert\\RA.exe";
            }

            // Other games list
            else if (glistOther.Text == "Battlechess")
            {
                gSelection = "data\\battlechess\\CHESS.exe";
            }

            else if (glistOther.Text == "The Incredible Machine")
            {
                gSelection = "data\\incrediblemachine\\TIM.exe";
            }

            else if (glistOther.Text == "SimFarm")
            {
                gSelection = "data\\simfarm\\SIMFARM.exe";
            }

            else if (glistOther.Text == "SimAnt")
            {
                gSelection = "data\\simant\\SIMANT.exe";
            }

            else if (glistOther.Text == "Warcraft")
            {
                gSelection = "data\\warcraft\\WAR.exe";
            }

            else if (glistOther.Text == "Oregon Trail: Deluxe")
            {
                gSelection = "data\\oregontrail-deluxe\\OREGON.EXE";
            }

            else if (glistOther.Text == "Daggerfall")
            {
                gSelection = "-conf data\\DAGGER\\run_daggerfall.conf";
            }

            if (gSelection != "NULL")
            {
                System.Diagnostics.Process game = new System.Diagnostics.Process();
                game.StartInfo.FileName = "data\\dosbox\\DosBox.exe";
                game.StartInfo.Arguments = gSelection;
                game.Start();
            }
            else
            {
                MessageBox.Show("Please select a game from one of the dropdowns before hitting play!");
            }
            
        }

        private void btnForums_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://jh-laboratory.github.io/jhlabs/");
        }


        private void btndiscord_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://discord.gg/Jr8f5GbFmQ");
        }
    }
}
