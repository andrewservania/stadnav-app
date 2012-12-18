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
    public partial class Manage_Waypoint : Form
    {
        Main_Tool main_Tool;

        public Manage_Waypoint(Main_Tool main_Tool)
        {
            this.main_Tool = main_Tool;
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {

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
    }
}
