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

        /// <summary>
        /// Constructor for the Manage Route form
        /// </summary>
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

        /// <summary>
        /// Method that handles the 'Click' on the help toolstrip-item
        /// Used for displaying the help menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method that handles the 'Click' on 'btnToevoegenToevoegen'
        /// Used for adding new routes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            route.ID = newId;
            route.Waypoints = addingWaypoints;

            RouteManagement.AddRoute(route);
        }

        /// <summary>
        /// method that handles index changes on 'lbAlleRoutes' which displays all routes currently available
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method that handles the 'Click' on 'btnWaypointToevoegenToevoegen'
        /// Used for adding waypoints to the 'adding' part of the routemanagement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWaypointToevoegenToevoegen_Click(object sender, EventArgs e)
        {
            Waypoint selectedWaypoint = lbBeschikbaarToevoegen.SelectedItem as Waypoint;

            if (selectedWaypoint != null)
                addingWaypoints.Add(selectedWaypoint);
            else
                MessageBox.Show("Er is een fout opgetreden tijdens het verwijderen");
        }

        /// <summary>
        /// Method that handles the 'Click' on 'btnWaypointVerwijderenToevoegen'
        /// Used for removing waypoints from the 'adding' part of the routemanagement.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWaypointVerwijderenToevoegen_Click(object sender, EventArgs e)
        {
            Waypoint selectedWaypoint = lbBevatToevoegen.SelectedItem as Waypoint;

            if (selectedWaypoint != null)
                addingWaypoints.Remove(selectedWaypoint);
            else
                MessageBox.Show("Er is een fout opgetreden tijdens het verwijderen");
        }

        /// <summary>
        /// Method that handles the 'Click' on 'btnVerwijderen'
        /// Used for entirely removing routes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            RouteManagement.RemoveRoute(selectedRoute);
        }

        /// <summary>
        /// Method that handles the 'Click' on 'btnBewerken'
        /// Used for editing an entire waypoint (saving all the changes to the management)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method that handles the 'Click' on 'btnWaypointToevoegenBewerken'
        /// Used for adding waypoints to the 'editing' part of the route'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWaypointToevoegenBewerken_Click(object sender, EventArgs e)
        {
            Waypoint selectedWaypoint = lbBeschikbaarBewerken.SelectedItem as Waypoint;

            if (selectedWaypoint != null)
                editingWaypoints.Add(selectedWaypoint);
            else
                MessageBox.Show("Er is een fout opgetreden tijdens het toevoegen");
        }

        /// <summary>
        /// Method that handles the 'Click' on 'btnVerwijderenBewerken'
        /// Used for removing waypoints from the 'editing' part of the route.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWaypointVerwijderenBewerken_Click(object sender, EventArgs e)
        {
            Waypoint selectedWaypoint = lbBevatBewerken.SelectedItem as Waypoint;

            if (selectedWaypoint != null)
                editingWaypoints.Remove(selectedWaypoint);
            else
                MessageBox.Show("Er is een fout opgetreden tijdens het verwijderen");
        }

        /// <summary>
        /// Method that handles the 'Click' on the afsluiten toolstrip-item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afsluitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
