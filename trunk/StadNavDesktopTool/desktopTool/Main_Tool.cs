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
        private string path = ";";
        private bool hulp = false;
        private Help_Tool help;
        

        public Main_Tool()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbSchrijven.CheckState == CheckState.Checked)
            {
                if (cbKopieren.CheckState == CheckState.Checked)
                    cbKopieren.CheckState = CheckState.Unchecked;

                lblAlert.Visible = true;
            }
            else
                lblAlert.Visible = false;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKopieren.CheckState == CheckState.Checked)
            {
                if (cbSchrijven.CheckState == CheckState.Checked)
                    cbSchrijven.CheckState = CheckState.Unchecked;

                lblAlert.Visible = false;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (tbProductID.Text == "vul hier de product ID in")
            {
                tbProductID.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtbOutput.Clear();
            rtbOutput.Text = "...";
            string productID = " " + tbProductID.Text;
            string actie;
            string emu;
            path = " " + tbBrowseURL.Text;
           
            if (cbGebruikEmulator.CheckState == CheckState.Checked)
            {
                emu = " xd";
            }
            else
            {
                emu = " ed";
            }
            
            if (cbSchrijven.CheckState == CheckState.Checked)
            {
                actie = " rs";
            }
            else
            {
                actie = " ts";
            }

            
   
            rtbOutput.Text = ExecuteCommandSync(actie, emu, productID, path);
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
                tbBrowseURL.Text = path;
                tbBrowseURL.Select(tbBrowseURL.Text.Length, 0);
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
            Form manageRoute = new Manage_Route(this);
            manageRoute.ShowDialog(this);
        }

        private void bewerkenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form manageLanguage = new Manage_Language(this);
            manageLanguage.ShowDialog(this);
        }

        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form manageWaypoints = new Manage_Waypoint(this);
            manageWaypoints.ShowDialog(this);
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!hulp)
            {
                hulp = true;
                createHulp(0);
                
            }
            else
            {
                setTabHulp(0);
            }
        }

        public void setHulp(bool hulp)
        {
            this.hulp = hulp;
        }

        public bool getHulp()
        {
            return hulp;
        }

        public void createHulp(int type)
        {
            help = new Help_Tool(this, type);
            help.Show();
            help.Location = new Point(Screen.PrimaryScreen.Bounds.Right - help.Width, Screen.PrimaryScreen.Bounds.Top);
        }

        public void setTabHulp(int tab)
        {
            help.setTab(tab);
        }
        public Help_Tool getHelpPage()
        {
            help.Visible = false;
            return help;
        }

        public void deleteHelpPage()
        {
            help.Dispose();
        }

        private void routeDataOpslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();

            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.SelectedPath;

                using (StreamWriter languagesWriter = new StreamWriter(path + @"\languages.json"))
                {
                    languagesWriter.WriteLine(JSONManagement.LanguagesToJSON());
                }

                using (StreamWriter waypointWriter = new StreamWriter(path + @"\waypoints.json"))
                {
                    waypointWriter.WriteLine(JSONManagement.WaypointsToJSON());
                }

                using (StreamWriter routesWriter = new StreamWriter(path + @"\routes.json"))
                {
                    routesWriter.WriteLine(JSONManagement.RoutesToJSON());
                }
            }   
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void routeDataOpenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFileDialog1 = new FolderBrowserDialog();

            DialogResult userClickedOK = openFileDialog1.ShowDialog();

            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                string path = openFileDialog1.SelectedPath;

                using (StreamReader languagesReader = new StreamReader(path + @"\languages.json"))
                {
                    string jsonLanguages = languagesReader.ReadToEnd();
                    LanguageManagement.SetAllLanguages(JSONManagement.LanguagesFromJSON(jsonLanguages));
                }

                using (StreamReader waypointReader = new StreamReader(path + @"\waypoints.json"))
                {
                    string jsonWaypoints = waypointReader.ReadToEnd();
                    WaypointManagement.SetAllWaypoints(JSONManagement.WaypointsFromJSON(jsonWaypoints));
                }

                using (StreamReader routeReader = new StreamReader(path + @"\routes.json"))
                {
                    string jsonRoutes = routeReader.ReadToEnd();
                    RouteManagement.SetAllRoutes(JSONManagement.RoutesFromJSON(jsonRoutes));
                }
            }   
        }

        private void resetRouteDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Dit verwijdert alle lokale data uit de applicatie, \nhierdoor zal je opnieuw alle routegegevens moeten openen! \nWeet je het zeker?", "Bevestig reset", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                LanguageManagement.ClearLanguages();
                RouteManagement.ClearRoutes();
                WaypointManagement.ClearWaypoints();
            }
            
        }
    }
}
