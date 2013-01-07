using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StadNavDesktopTool
{
    public partial class Manage_Waypoint : Form
    {
        Main_Tool main_Tool;

        Waypoint selectedWaypoint;
        Waypoint addingWaypoint;

        BindingList<string> selectedMedia;
        BindingList<string> addingMedia;

        public Manage_Waypoint(Main_Tool main_Tool)
        {
            addingMedia = selectedMedia =  new BindingList<string>();
            selectedWaypoint = addingWaypoint = new Waypoint();

            this.main_Tool = main_Tool;

            InitializeComponent();

            lbWaypoints.DataSource = WaypointManagement.GetAllWaypoints();
            cbTaalBewerken.DataSource = LanguageManagement.GetAllLanguages();
            cbTaalToevoegen.DataSource = LanguageManagement.GetAllLanguages();
            lbMediaToevoegen.DataSource = addingMedia;
            lbMediaBewerken.DataSource = selectedMedia;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            addingWaypoint = new Waypoint();

            addingWaypoint.Name = tbNaamToevoegen.Text;
            addingWaypoint.Descriptions[((Language) cbTaalToevoegen.SelectedItem).ID] = rtbBeschrijvingToevoegen.Text;

            int newId;
            double newLongitude;
            double newLatitude;

            if(!int.TryParse(tbIDToevoegen.Text, out newId))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het omzetten van ID");
                return;
            }

            addingWaypoint.ID = newId;

            if (!double.TryParse(tbLongToevoegen.Text, out newLongitude))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het omzetten van Longitude");
                return;
            }

            addingWaypoint.Longitude = newLongitude;

            if (!double.TryParse(tbLatToevoegen.Text, out newLatitude))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het omzetten van Latitude");
                return;
            }

            addingWaypoint.Latitude = newLatitude;

            addingWaypoint.Media = addingMedia;

            if (!WaypointManagement.AddWaypoint(addingWaypoint))
                MessageBox.Show("Waypoint bestaat al, of er is een fout opgetreden tijdens het toevoegen");

            addingMedia.Clear();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!main_Tool.getHulp())
            {
                main_Tool.setHulp(true);
                main_Tool.createHulp(3);
            }
            else
            {
                Help_Tool hulp = main_Tool.getHelpPage();
                hulp.setTab(3);
                hulp.ShowDialog(this);
            }
        }

        private void updateDisplay()
        {
            if (lbWaypoints.Items.Count > 0 && lbWaypoints.SelectedItem != null)
            {
                selectedWaypoint = (Waypoint)lbWaypoints.SelectedItem;
                selectedMedia = selectedWaypoint.Media;

                tbIDBewerken.Text = "" + selectedWaypoint.ID;
                tbNaamBewerken.Text = selectedWaypoint.Name;
                tbLatBewerken.Text = "" + selectedWaypoint.Latitude;
                tbLongBewerken.Text = "" + selectedWaypoint.Longitude;

                if (cbTaalBewerken.SelectedItem != null && selectedWaypoint.Descriptions.ContainsKey(((Language)cbTaalBewerken.SelectedItem).ID) && selectedWaypoint.Descriptions[((Language)cbTaalBewerken.SelectedItem).ID] != null)
                    rtbBeschrijvingBewerken.Text = selectedWaypoint.Descriptions[((Language)cbTaalBewerken.SelectedItem).ID];

                lbMediaBewerken.DataSource = selectedMedia;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void lbMediaBewerken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbBewerken_Click(object sender, EventArgs e)
        {
            selectedWaypoint.Name = tbNaamBewerken.Text;
            selectedWaypoint.Descriptions[((Language) cbTaalBewerken.SelectedItem).ID] = rtbBeschrijvingBewerken.Text;

            int newId;
            double newLongitude;
            double newLatitude;

            if (!int.TryParse(tbIDToevoegen.Text, out newId))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het omzetten van ID");
                return;
            }

            selectedWaypoint.ID = newId;

            if (!double.TryParse(tbLongToevoegen.Text, out newLongitude))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het omzetten van Longitude");
                return;
            }

            selectedWaypoint.Longitude = newLongitude;

            if (!double.TryParse(tbLatToevoegen.Text, out newLatitude))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het omzetten van Latitude");
                return;
            }

            selectedWaypoint.Latitude = newLatitude;
            selectedWaypoint.Media = selectedMedia;

            WaypointManagement.UpdateWaypoint(selectedWaypoint);
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            WaypointManagement.RemoveWaypoint(selectedWaypoint);
        }

        private void btnBrowseMediaToevoegen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbBrowseMediaToevoegen.Text = openFileDialog.FileName;
            }
        }

        private void btnToevoegenMediaToevoegen_Click(object sender, EventArgs e)
        {
            if (tbBrowseMediaToevoegen.Text != string.Empty && tbBrowseMediaToevoegen.Text != "Mediabestand")
            {
                addingMedia.Add(tbBrowseMediaToevoegen.Text);
                tbBrowseMediaToevoegen.Text = "";
            }
        }

        private void lbMediaToevoegen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerwijderenMediaToevoegen_Click(object sender, EventArgs e)
        {
            if(lbMediaToevoegen.SelectedItem != null && lbMediaToevoegen.Items.Count > 0)
                addingMedia.Remove((string) lbMediaToevoegen.SelectedItem);
        }

        private void btnVerwijderenMediaBewerken_Click(object sender, EventArgs e)
        {
            if (lbMediaBewerken.SelectedItem != null && lbMediaBewerken.Items.Count > 0)
                selectedMedia.Remove((string) lbMediaBewerken.SelectedItem);
        }

        private void btnBrowseMediaBewerken_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tbBrowseMediaBewerken.Text = openFileDialog.FileName;
            }
        }

        private void btnToevoegenMediaBewerken_Click(object sender, EventArgs e)
        {
            if (tbBrowseMediaBewerken.Text != string.Empty && tbBrowseMediaBewerken.Text != "Mediabestand")
            {
                selectedMedia.Add(tbBrowseMediaBewerken.Text);
                tbBrowseMediaBewerken.Text = "";
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaypointManagement.ClearWaypoints();
            lbWaypoints.DataSource = WaypointManagement.GetAllWaypoints();
        }

        private void afsluitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbTaalToevoegen_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }

        private void cbTaalBewerken_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateDisplay();
        }
    }
}
