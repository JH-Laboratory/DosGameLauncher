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
        string VERSION = "1.3.0";

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


            lblLauncherVer.Text = "v" + VERSION;
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

            else if (glistHunterFaves.Text == "Duke Nukem 3D")
            {
                gSelection = "data\\duke3d\\DUKE3D.EXE";
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

            else if (glistHunterFaves.Text == "The Lost Vikings")
            {
                gSelection = "data\\lostvikings\\VIKINGS.EXE";
            }

            else if (glistHunterFaves.Text == "Microsoft Flight Sim 3")
            {
                gSelection = "data\\mfs3\\Fs3.exe";
            }

            else if (glistHunterFaves.Text == "Battlezone")
            {
                gSelection = "data\\battlezone\\ZONE.EXE";
            }

            else if (glistHunterFaves.Text == "Heimdall")
            {
                gSelection = "data\\heimdall\\heimdall.EXE";
            }

            else if (glistHunterFaves.Text == "Heimdall 2")
            {
                gSelection = "data\\heim2\\h2pc.exe";
            }

            else if (glistHunterFaves.Text == "SimCity 2000")
            {
                gSelection = "data\\simcity2000\\sc2000.exe";
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

            else if (glistOther.Text == "The Elder Scrolls: Daggerfall")
            {
                gSelection = "-conf data\\DAGGER\\run_daggerfall.conf";
            }

            else if (glistOther.Text == "Prince of Persia")
            {
                gSelection = "data\\persia\\PRINCE.EXE";
            }

            else if (glistOther.Text == "Battlehawks 1942")
            {
                gSelection = "data\\battlehawks\\BH.EXE";
            }

            else if (glistOther.Text == "Sim Refinery")
            {
                gSelection = "data\\simrefinery\\SIMREF.EXE";
            }

            else if (glistOther.Text == "Klax")
            {
                gSelection = "data\\klax\\KLAX.EXE";
            }

            else if (glistOther.Text == "Dungeons & Dragons")
            {
                gSelection = "data\\dnd\\dnd.exe";
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

        private void jhlLogo_Click(object sender, EventArgs e)
        {
            string logoMsgBox = "DOS Game Launcher|Developed by: Johnny Hunter|Copyright JHLabs 2021||https://github.com/JH-Laboratory/DosGameLauncher";
            logoMsgBox = logoMsgBox.Replace("|", System.Environment.NewLine);
            MessageBox.Show(logoMsgBox);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string helpMsg = "Choose a game from the dropdown menus, then press play!%You must only choose a game from ONE dropdown. If you choose one in one list on accident, change it to the empty entry, and%you may select a game from the other list.%%Global Controls while in-game:%Ctrl + F12 - Increase Emulation CPU speed (visible in DOSBox titlebar)%Ctrl + F11 - Decrease Emulation CPU speed (visible in DOSBox titlebar)%Alt + Enter - Toggle fullscreen%Ctrl + Alt + F5 - Start/Stop screen recording%Ctrl + F5 - Take screenshot%Ctrl + F10 - Capture/Release the mouse";
            helpMsg = helpMsg.Replace("%", System.Environment.NewLine);
            MessageBox.Show(helpMsg);
        }

        private void lblLauncherVer_Click(object sender, EventArgs e)
        {
            DevToolsForm DevTools = new DevToolsForm();
            DevTools.ShowDialog();
            DevTools.TopMost = true;
        }
    }
}
