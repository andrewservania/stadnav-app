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
    public partial class Manage_Language : Form
    {
        Main_Tool main_Tool;

        public Manage_Language(Main_Tool main_Tool)
        {
            this.main_Tool = main_Tool;
            InitializeComponent();
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void Manage_Language_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!main_Tool.getHulp())
            {
                main_Tool.setHulp(true);
                main_Tool.createHulp(2);
            }
            else
            {
                Help_Tool hulp = main_Tool.getHelpPage();
                hulp.setTab(2);
                hulp.ShowDialog(this);
            }
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            
        }
    }
}
