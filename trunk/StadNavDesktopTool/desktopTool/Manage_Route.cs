using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StadNavDesktopTool
{
    public partial class Manage_Route : Form
    {
        Main_Tool main_Tool;
        Route selectedRoute;
        BindingList<Waypoint> addingWaypoints;
        BindingList<Waypoint> editingWaypoints;

        public Manage_Route(Main_Tool main_Tool)
        {
            this.main_Tool = main_Tool;
            InitializeComponent();

            addingWaypoints = new BindingList<Waypoint>();
            editingWaypoints = new BindingList<Waypoint>();

            lbBeschikbaarBewerken.DataSource = WaypointManagement.GetAllWaypoints();
            lbBeschikbaarToevoegen.DataSource = WaypointManagement.GetAllWaypoints();
            lbBevatToevoegen.DataSource = addingWaypoints;
            lbAlleRoutes.DataSource = RouteManagement.GetAllRoutes();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!main_Tool.getHulp())
            {
                main_Tool.setHulp(true);
                main_Tool.createHulp(1);
            }
            else
            {
                Help_Tool hulp = main_Tool.getHelpPage();
                hulp.setTab(1);
                hulp.ShowDialog(this);
            }
        }

        private void btnToevoegenToevoegen_Click(object sender, EventArgs e)
        {
            Route route = new Route();

            int newId = 0;

            if (!int.TryParse(tbIDToevoegen.Text, out newId))
            {
                MessageBox.Show("Er is een foutief ID ingevoerd");
                return;
            }

            if (RouteManagement.GetRoute(newId) != null)
            {
                MessageBox.Show("Er is al een route met het ingegeven ID");
                return;
            }

            route.Name = tbNaamToevoegen.Text;
            route.ID = Convert.ToInt32(tbIDToevoegen.Text);
            route.Waypoints = addingWaypoints;

            RouteManagement.AddRoute(route);
        }

        private void lbBeschikbaarToevoegen_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lbAlleRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlleRoutes.Items.Count > 0)
            {
                selectedRoute = (Route)lbAlleRoutes.SelectedItem;

                if (selectedRoute != null)
                {
                    tbNaamBewerken.Text = selectedRoute.Name;
                    tbIDBewerken.Text = "" + selectedRoute.ID;

                    lbBevatBewerken.DataSource = selectedRoute.Waypoints;
                    editingWaypoints = selectedRoute.Waypoints;
                }
            }
        }

        private void btnWaypointToevoegenToevoegen_Click(object sender, EventArgs e)
        {
            addingWaypoints.Add((Waypoint) lbBeschikbaarToevoegen.SelectedItem);
        }

        private void btnWaypointVerwijderenToevoegen_Click(object sender, EventArgs e)
        {
            addingWaypoints.Remove((Waypoint)lbBevatToevoegen.SelectedItem);
        }

        private void Manage_Route_Load(object sender, EventArgs e)
        {

        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            RouteManagement.RemoveRoute(selectedRoute);
        }

        private void btnToevoegenBewerken_Click(object sender, EventArgs e)
        {
            int newId = 0;

            if (!int.TryParse(tbIDBewerken.Text, out newId))
            {
                MessageBox.Show("Er is een fout opgetreden tijdens het opslaan van het bewerkte ID");
                return;
            }

            if (RouteManagement.GetRoute(newId) != null)
            {
                MessageBox.Show("Er is al een route met dit ID");
                return;
            }

            selectedRoute.ID = newId;
            selectedRoute.Name = tbNaamBewerken.Text;

            selectedRoute.Waypoints = editingWaypoints;
            RouteManagement.UpdateRoute(selectedRoute);

            if(lbAlleRoutes.Items.Count > 0)
            selectedRoute = (Route) lbAlleRoutes.Items[0];
        }

        private void btnWaypointToevoegenBewerken_Click(object sender, EventArgs e)
        {
            editingWaypoints.Add((Waypoint)lbBeschikbaarBewerken.SelectedItem);
        }

        private void btnWaypointVerwijderenBewerken_Click(object sender, EventArgs e)
        {
            editingWaypoints.Remove((Waypoint)lbBevatBewerken.SelectedItem);
        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DAT files (*.dat)|*.dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                RouteManagement.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void bewerkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DAT files (*.dat)|*.dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                RouteManagement.loadFromFile(openFileDialog.FileName);
            }

            lbAlleRoutes.DataSource = RouteManagement.GetAllRoutes();
        }
    }
}
