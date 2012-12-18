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
    public partial class Help_Tool : Form
    {
        int tab;
        Main_Tool maint_Tool;
        ContextMenuStrip menuding = new ContextMenuStrip();
        ToolTip tip = new ToolTip();

        public Help_Tool(Main_Tool tool,int tab)
        {
           
            this.maint_Tool = tool;
            this.tab = tab;
            InitializeComponent();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region maintab
        //Main TabBlad
        private void MenuBarClick_Click(object sender, EventArgs e)
        {
            lblTitelInfo.ForeColor = Color.Red;
            lblTitelInfo.Text = "Menu Bar";
            lblTitelInfo.Visible = true;

            lblInfoInfo.Text = "Met de Menu bar navigeert u door de applicatie. Met de knop File kan u applicatie afsluiten. Met de knop beheren kan u kiezen uit Routes, Talen en Waypoints. Bij Routes kunt u routes toevoegen of bewerken. Bij talen kunt u talen toevoegen of bewerken. Bij Waypoints kunt u waypoints toevoegen of bewerken.";
            lblInfoInfo.Visible = true;
        }

        private void ProductIDClick_Click(object sender, EventArgs e)
        {
            lblTitelInfo.ForeColor = Color.Blue;
            lblTitelInfo.Text = "Product ID";
            lblTitelInfo.Visible = true;

            lblInfoInfo.Text = "Daar kunt u het id van de applicatie in vullen waar de routes en waypoints heen gestuurd moeten worden. Als u dit niet weet dan moet u het standaart ingevulde ID laten staan.";
            lblInfoInfo.Visible = true;
        }

        private void ActiesClick_Click(object sender, EventArgs e)
        {
            lblTitelInfo.ForeColor = Color.Lime;
            lblTitelInfo.Text = "Acties";
            lblTitelInfo.Visible = true;

            lblInfoInfo.Text = "Hier kunt u beslissen wat u wilt doen. U kunt aan vinken of u naar de telefoon wilt schrijven, of dat u alles er af wilt kopieren. daar boven kunt u met de knop Browse een locatie selecteren om naar toe te kopieren, of een map die u naar de telefoon wilt schrijven.";
            lblInfoInfo.Visible = true;
        }

        private void EmulatorClick_Click(object sender, EventArgs e)
        {
            lblTitelInfo.ForeColor = Color.Orange;
            lblTitelInfo.Text = "Emulator";
            lblTitelInfo.Visible = true;

            lblInfoInfo.Text = "In dit vak kunt u aanvinken of U de gegevens naar de standaart emulator wilt sturen of dat u een fysieke telefoon gebruikt.";
            lblInfoInfo.Visible = true;
        }

        private void LogClick_Click(object sender, EventArgs e)
        {
            lblTitelInfo.ForeColor = Color.DeepPink;
            lblTitelInfo.Text = "Log";
            lblTitelInfo.Visible = true;

            lblInfoInfo.Text = "In dit vak komt een log te staan van de actie die u uitvoert, of mogelijke errors.";
            lblInfoInfo.Visible = true;
        }

        private void ProductIDClick_MouseHover(object sender, EventArgs e)
        {
            
        }

        #endregion

        #region RouteTab
        //Route tabblad
        private void MenuBarClickRoute_Click(object sender, EventArgs e)
        {
            lblTitelInfoRoutes.ForeColor = Color.Red;
            lblTitelInfoRoutes.Text = "Menu Bar";
            lblTitelInfoRoutes.Visible = true;

            lblInfoInfoRoutes.Text = "Met dit vak kunt u het scherm sluiten als u klaar bent";
            lblInfoInfoRoutes.Visible = true;
        }

        private void ToevoegenClickRoute_Click(object sender, EventArgs e)
        {
            lblTitelInfoRoutes.ForeColor = Color.Blue;
            lblTitelInfoRoutes.Text = "Toevoegen";
            lblTitelInfoRoutes.Visible = true;

            lblInfoInfoRoutes.Text = "Met dit vak kunt u routes toevoegen. Hier moet u een naam in vullen achter Naam, en een ID achter ID, dit moet een nummer zijn. Verder kunt u waypoints toevoegen aan de route, dit doet u door een waypoint te selecteren in het beschikbaar vak, en een index in te vullen voor dat waypoint, en dan op het pijltje richting het bevat vak te klikken. De index wordt gebruikt voor de volgorde van de route. Om een waypoint te verwijderen selecteerd u eerst een waypoint uit het bevat vak, en daarna klikt u op de pijltjes knop in de richting van beschikbaar.";
            lblInfoInfoRoutes.Visible = true;
            //RoutesInfoGroupBox.Size = new Size(822, lblInfoInfoRoutes.Bottom+5);
            //this.Size = new Size(860, RoutesInfoGroupBox.Bottom + 95);
        }

        private void BewerkenClickRoute_Click(object sender, EventArgs e)
        {
            lblTitelInfoRoutes.ForeColor = Color.Lime;
            lblTitelInfoRoutes.Text = "Bewerken";
            lblTitelInfoRoutes.Visible = true;

            lblInfoInfoRoutes.Text = "Met dit vak kunt u routes bewerken. als u een route selecteerd uit het routes vak, dan wordt de informatie ingevuld in het bewerken vak. Dit kunt u dan aanpassen. Door op de knop toevoegen te klikken wordt de aangepaste informatie opgeslagen. Verder werken de waypoints het zelfde als in het toevoegen vak.";
            lblInfoInfoRoutes.Visible = true;
        }

        private void RoutesClickRoute_Click(object sender, EventArgs e)
        {
            lblTitelInfoRoutes.ForeColor = Color.DeepPink;
            lblTitelInfoRoutes.Text = "Routes";
            lblTitelInfoRoutes.Visible = true;

            lblInfoInfoRoutes.Text = "in dit vak staan alle routes die beschikbaar zijn, u kunt ze selecteren en bewerken, of u kunt een geselecteerde route verwijderen door op de verwijder knop te klikken.";
            lblInfoInfoRoutes.Visible = true;
        }
        #endregion

        #region talenTab
        //Talen TabBlad
        private void MenuBarTalenClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoTalen.ForeColor = Color.Red;
            lblTitelInfoTalen.Text = "MenuBar";
            lblTitelInfoTalen.Visible = true;

            lblInfoIntoTalen.Text = "Met de Menu Bar kunt u dit scherm sluiten als u klaar bent";
            lblInfoIntoTalen.Visible = true;
        }

        private void ToevoegenTalenClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoTalen.ForeColor = Color.Blue;
            lblTitelInfoTalen.Text = "Toevoegen";
            lblTitelInfoTalen.Visible = true;

            lblInfoIntoTalen.Text = "In het toevoegen vak kunt u Talen toevoegen. dit doet U door een Naam en een ID van de Taal in te vullen en dan op toevoegen te klikken op de taal op te slaan";
            lblInfoIntoTalen.Visible = true;
        }

        private void BewerkenTalenClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoTalen.ForeColor = Color.Lime;
            lblTitelInfoTalen.Text = "Bewerken";
            lblTitelInfoTalen.Visible = true;

            lblInfoIntoTalen.Text = "In het bewerken van Kunt u talen bewerken. Dit doet u door een taal uit het talen van te selecteren en dan wordt de naam en ID in gevuld in het bewerken van, waarna u het kan aanpassen. Door daarna op de Bewerk knop te drukken slaat u de taal weer op";
            lblInfoIntoTalen.Visible = true;
        }

        private void TalenTalenClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoTalen.ForeColor = Color.DeepPink;
            lblTitelInfoTalen.Text = "Talen";
            lblTitelInfoTalen.Visible = true;

            lblInfoIntoTalen.Text = "In dit vak ziet u alle beschikbare talen. U kunt deze talen selecteren en bewerken of selecteren en verwijderen door op de verwijderen knop te drukken.";
            lblInfoIntoTalen.Visible = true;
        }
        #endregion

        #region waypointTab
        //Waypoint tabblad
        private void WaypointsMenuBarClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoWaypoints.ForeColor = Color.Red;
            lblTitelInfoWaypoints.Text = "MenuBar";
            lblTitelInfoWaypoints.Visible = true;

            lblInfoInfoWaypoints.Text = "Met de menu bar Kunt u dit scherm sluiten als u klaar bent.";
            lblInfoInfoWaypoints.Visible = true;
        }

        private void WaypointsToevoegenClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoWaypoints.ForeColor = Color.Blue;
            lblTitelInfoWaypoints.Text = "Toevoegen";
            lblTitelInfoWaypoints.Visible = true;

            lblInfoInfoWaypoints.Text = "In dit van kan je Waypoints toevoegen, je moet een naam invullen, een ID en van de locatie een latitude en longtitude, en een beschrijving van het waypoint. daarnaast is het nog optioneel om een media bestand toe tevoegen. Dat doe je door op de knop browse te klikken, dan een bestand te selecteren en dan op toe voegen te klikken. Het verwijderen van media gaat door het media bestand te selecteren en dan op de knop verwijderen te klikken. U slaat het waypoints dan op door op toevoegen knop te klikken";
            lblInfoInfoWaypoints.Visible = true;
            //TalenInfoGroupBox.Size = new Size(822, lblInfoInfoWaypoints.Bottom+5);
            //this.Size = new Size(860, TalenInfoGroupBox.Bottom + 95);
        }

        private void WaypointsBewerkenClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoWaypoints.ForeColor = Color.Lime;
            lblTitelInfoWaypoints.Text = "Bewerken";
            lblTitelInfoWaypoints.Visible = true;

            lblInfoInfoWaypoints.Text = "In dit van kan je waypoints bewerken. Eerst moet er een waypoint geselecteerd worden uit het waypoints vak, en dan wordt de informatie zichtbaar in het bewerken van en kunt u alles aan passen. De media in het bewerken werkt het zelfde als in het toevoegen vak. U kan het waypoint dan weer opslaan door op de bewerken knop te drukken.";
            lblInfoInfoWaypoints.Visible = true;
        }

        private void WaypointsWaypointsClick_Click(object sender, EventArgs e)
        {
            lblTitelInfoWaypoints.ForeColor = Color.DeepPink;
            lblTitelInfoWaypoints.Text = "Waypoints";
            lblTitelInfoWaypoints.Visible = true;

            lblInfoInfoWaypoints.Text = "In dit vak zijn alle waypoints te zien die er al ooit zijn toegevoegd. je kan ze selecteren en bewerken, of verwijderen door op de verwijder knop te klikken";
            lblInfoInfoWaypoints.Visible = true;
        }
        #endregion

        private void Help_Tool_Shown(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[tab];
        }
        

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Help_Tool_FormClosing(object sender, FormClosingEventArgs e)
        {
            maint_Tool.setHulp(false);
        }

        public void setTab(int tabpage)
        {
            tabControl1.SelectedTab = tabControl1.TabPages[tabpage];
            tab = tabpage;
        }

        private void Help_Tool_Load(object sender, EventArgs e)
        {
        }        
    }
}
