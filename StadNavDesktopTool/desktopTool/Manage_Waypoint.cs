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

        BindingList<Image> selectedImages;
        BindingList<Image> addingImages;

        public Manage_Waypoint(Main_Tool main_Tool)
        {
            addingImages = selectedImages =  new BindingList<Image>();
            selectedWaypoint = addingWaypoint = new Waypoint();

            this.main_Tool = main_Tool;

            InitializeComponent();

            lbWaypoints.DataSource = WaypointManagement.GetAllWaypoints();
            lbMediaToevoegen.DataSource = addingImages;
            lbMediaBewerken.DataSource = selectedImages;
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
            addingWaypoint.Description = rtbBeschrijvingToevoegen.Text;

            try
            {
                addingWaypoint.ID = Convert.ToInt32(tbIDToevoegen.Text, CultureInfo.InvariantCulture);
                addingWaypoint.Longitude = Convert.ToDouble(tbLongToevoegen.Text, CultureInfo.InvariantCulture);
                addingWaypoint.Latitude = Convert.ToDouble(tbLatToevoegen.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception) { MessageBox.Show("Foutieve invoer tijdens het aanmaken van de taal"); }

            addingWaypoint.Images = addingImages;

            if (!WaypointManagement.AddWaypoint(addingWaypoint))
                MessageBox.Show("Waypoint bestaat al, of er is een fout opgetreden tijdens het toevoegen");


            addingImages.Clear();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbWaypoints.Items.Count > 0 && lbWaypoints.SelectedItem != null)
            {
                selectedWaypoint = (Waypoint)lbWaypoints.SelectedItem;
                selectedImages = selectedWaypoint.Images;

                tbIDBewerken.Text = "" + selectedWaypoint.ID;
                tbNaamBewerken.Text = selectedWaypoint.Name;
                tbLatBewerken.Text = "" + selectedWaypoint.Latitude;
                tbLongBewerken.Text = "" + selectedWaypoint.Longitude;
                rtbBeschrijvingBewerken.Text = selectedWaypoint.Description;
                lbMediaBewerken.DataSource = selectedImages;
            }
        }

        private void lbMediaBewerken_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbBewerken_Click(object sender, EventArgs e)
        {
            selectedWaypoint.Name = tbNaamBewerken.Text;
            selectedWaypoint.Description = rtbBeschrijvingBewerken.Text;

            try
            {
                selectedWaypoint.ID = Convert.ToInt32(tbIDBewerken.Text, CultureInfo.InvariantCulture);
                selectedWaypoint.Longitude = Convert.ToDouble(tbLongBewerken.Text, CultureInfo.InvariantCulture);
                selectedWaypoint.Latitude = Convert.ToDouble(tbLatBewerken.Text, CultureInfo.InvariantCulture);
            }
            catch (Exception) { MessageBox.Show("Foutieve invoer tijdens het bewerken van de taal"); }

            selectedWaypoint.Images = selectedImages;
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
            try
            {
                addingImages.Add(Image.FromFile(tbBrowseMediaToevoegen.Text));
                tbBrowseMediaToevoegen.Text = "";
            }
            catch (Exception) { MessageBox.Show("Er is een fout opgetreden tijdens het toevoegen van media"); }
        }

        private void lbMediaToevoegen_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVerwijderenMediaToevoegen_Click(object sender, EventArgs e)
        {
            if(lbMediaToevoegen.SelectedItem != null && lbMediaToevoegen.Items.Count > 0)
                addingImages.Remove((Image) lbMediaToevoegen.SelectedItem);
        }

        private void btnVerwijderenMediaBewerken_Click(object sender, EventArgs e)
        {
            if (lbMediaBewerken.SelectedItem != null && lbMediaBewerken.Items.Count > 0)
                selectedImages.Remove((Image)lbMediaBewerken.SelectedItem);
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
            try
            {
                selectedImages.Add(Image.FromFile(tbBrowseMediaBewerken.Text));
                tbBrowseMediaBewerken.Text = "";
            }
            catch (Exception) { MessageBox.Show("An error occured while loading the page"); }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DAT files (*.dat)|*.dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                WaypointManagement.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DAT files (*.dat)|*.dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                WaypointManagement.loadFromFile(openFileDialog.FileName);
            }

            lbWaypoints.DataSource = WaypointManagement.GetAllWaypoints();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WaypointManagement.Clear();
            lbWaypoints.DataSource = WaypointManagement.GetAllWaypoints();
        }

        private void afsluitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
