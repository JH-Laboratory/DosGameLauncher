using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DosGameLauncher
{
    public partial class DevToolsForm : Form
    {
        public DevToolsForm()
        {
            InitializeComponent();
        }

        private void devbtnDobox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process game = new System.Diagnostics.Process();
            game.StartInfo.FileName = "data\\dosbox\\DosBox.exe";
            game.StartInfo.Arguments = "-conf debug.conf";
            game.Start();
        }

        private void devbtnWindows_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process game = new System.Diagnostics.Process();
            game.StartInfo.FileName = "data\\dosbox\\DosBox.exe";
            game.StartInfo.Arguments = "-conf data\\win\\run_windows.conf";
            game.Start();
        }

        private void devbtnRepo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/JH-Laboratory/DosGameLauncher");
        }
    }
}
