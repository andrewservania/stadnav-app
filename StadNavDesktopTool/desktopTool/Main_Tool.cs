using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StadNavDesktopTool
{
    public partial class Main_Tool : Form
    {
        string path = ";";

        public Main_Tool()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.CheckState == CheckState.Checked)
            {
                if (checkBox3.CheckState == CheckState.Checked)
                    checkBox3.CheckState = CheckState.Unchecked;

                lblAlert.Visible = true;
            }
            else
                lblAlert.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.CheckState == CheckState.Checked)
            {
                if (checkBox2.CheckState == CheckState.Checked)
                    checkBox2.CheckState = CheckState.Unchecked;

                lblAlert.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "vul hier de product ID in")
            {
                textBox1.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text = "...";
            string productID = " " + textBox1.Text;
            string actie;
            string emu;
            path = " " + BrowseText.Text;
           
            if (checkBox4.CheckState == CheckState.Checked)
            {
                emu = " xd";
            }
            else
            {
                emu = " ed";
            }
            
            if (checkBox2.CheckState == CheckState.Checked)
            {
                actie = " rs";
            }
            else
            {
                actie = " ts";
            }

            
   
            richTextBox1.Text = ExecuteCommandSync(actie, emu, productID, path);

            

        }

        private void BrowseBT_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();

            // Call the ShowDialog method to show the dialog box.
            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            // Process input if the user clicked OK.
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                path = openFileDialog1.SelectedPath;
                BrowseText.Text = path;
                BrowseText.Select(BrowseText.Text.Length, 0);
            }    
        }

        public string ExecuteCommandSync(string actie, string emu, string productID, string path)
        {
            try
            {
                // create the ProcessStartInfo using "cmd" as the program to be run,
                // and "/c " as the parameters.
                // Incidentally, /c tells cmd that we want it to execute the command that follows,
                // and then exit.

                System.Diagnostics.ProcessStartInfo procStartInfo = new System.Diagnostics.ProcessStartInfo();
                if (path == ";")
                {
                    procStartInfo = new System.Diagnostics.ProcessStartInfo(@"Resources\ISETool.exe", actie + emu + productID);
                }
                else
                {
                    procStartInfo = new System.Diagnostics.ProcessStartInfo(@"Resources\ISETool.exe", actie + emu + productID + path);
                }


                // The following commands are needed to redirect the standard output.
                // This means that it will be redirected to the Process.StandardOutput StreamReader.
                procStartInfo.RedirectStandardOutput = true;
                procStartInfo.UseShellExecute = false;
                // Do not create the black window.
                procStartInfo.CreateNoWindow = true;
                // Now we create a process, assign its ProcessStartInfo and start it
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo = procStartInfo;
                proc.Start();
                // Get the output into a string
                string result = proc.StandardOutput.ReadToEnd();
                // Display the command output.
                return result;
            }
            catch (Exception objException)
            {
                // Log the exception
                return objException.ToString();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void aanpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manageRoute = new Manage_Route();
            manageRoute.ShowDialog(this);
        }

        private void bewerkenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form manageLanguage = new Manage_Language();
            manageLanguage.ShowDialog(this);
        }

        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manageWaypoints = new Manage_Waypoint();
            manageWaypoints.ShowDialog(this);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }
    }
}
