using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// This app is built to be reused. 
/// Further documentation will be done below on how to edit
/// Dusty Beehler 2019

namespace FRC2019Hub
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void startInvaders()
        {
            //this starts the invaders.
            //change the String to change the path to the game
            //in all examples... Directory.GetCurrentDirectory() grabs the path where the .exe is exactly
            Process.Start(Directory.GetCurrentDirectory() + "/games/deepspaceinvaders/deepspaceinvaders.exe");
        }

        private void startMafia()
        {
            //This is for games that are built with SDL2.
            //It sets the location in the first line
            //The next lines edit the starting info to actually have the game render
            //just change the String to change the path to the game
            FileInfo mafiaFileInfo = new FileInfo(Directory.GetCurrentDirectory() + "/games/spacemafia/C-Sharp-Final-Project.exe");
            ProcessStartInfo info = new ProcessStartInfo(mafiaFileInfo.FullName);
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.UseShellExecute = false;
            info.WorkingDirectory = mafiaFileInfo.DirectoryName;
            Process mafia = new Process();
            mafia.StartInfo = info;
            mafia.EnableRaisingEvents = true;
            mafia.Start();
        }

        private void startSim()
        {
            //same as above
            FileInfo simFileInfo = new FileInfo(Directory.GetCurrentDirectory() + "/games/fieldsim/FRCField.exe");
            ProcessStartInfo info = new ProcessStartInfo(simFileInfo.FullName);
            info.RedirectStandardOutput = true;
            info.RedirectStandardError = true;
            info.UseShellExecute = false;
            info.WorkingDirectory = simFileInfo.DirectoryName;
            Process fieldSim = new Process();
            fieldSim.StartInfo = info;
            fieldSim.EnableRaisingEvents = true;
            fieldSim.Start();
        }

        //the next methods just check to see if the process is still running
        //if it is, this main form stays hidden
        //if it isn't, this main for comes back so you can choose more options
        private void mafiaBox_Click(object sender, EventArgs e)
        {
            bool running = true;
            startMafia();
            while (running)
            {
                //change process name to the name of the .exe you are running to check if it running
                //must be in a loop
                if (Process.GetProcessesByName("C-Sharp-Final-Project").Length > 0)
                {
                    this.Hide();
                }
                else
                {
                    this.Show();
                    //stops loop
                    running = false;
                }
            }
        }

        private void invaderBox_Click(object sender, EventArgs e)
        {
            bool running = true;
            startInvaders();
            while (running)
            {
                if (Process.GetProcessesByName("deepspaceinvaders").Length > 0)
                    this.Hide();
                else
                {
                    this.Show();
                    running = false;
                }
            }
        }

        private void simBox_Click(object sender, EventArgs e)
        {
            bool running = true;
            startSim();
            while (running)
            {
                if (Process.GetProcessesByName("FRCField").Length > 0)
                    this.Hide();
                else
                {
                    this.Show();
                    running = false;
                }
            }
        }

        //starts the website
        private void WebPicBtn_Click(object sender, EventArgs e)
        {
            Process website = new Process();
            website.StartInfo.FileName = Directory.GetCurrentDirectory() + "/web/index.html";
            website.Start();
        }
    }
}
