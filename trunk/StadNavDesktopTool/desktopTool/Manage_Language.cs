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
        Language selectedLanguage;

        public Manage_Language(Main_Tool main_Tool)
        {
            InitializeComponent();

            this.main_Tool = main_Tool;

            lbAlleTalen.DataSource = LanguageManagement.GetAllLanguages();
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
            try
            {
                bool addedLanguage = LanguageManagement.AddLanguage(Convert.ToInt32(tbIDToevoegen.Text), tbNaamToevoegen.Text);

                if (!addedLanguage)
                    MessageBox.Show("Er bestaat al een taal met dit ID!");
            }
            catch (Exception) { MessageBox.Show("Foutieve invoer tijdens het aanmaken van de taal"); }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlleTalen.Items.Count > 0)
            {
                selectedLanguage = (Language)lbAlleTalen.SelectedItem;
                tbIDBewerken.Text = "" + selectedLanguage.ID;
                tbNaamBewerken.Text = selectedLanguage.Name;
            }
        }

        private void btnBewerken_Click(object sender, EventArgs e)
        {
            selectedLanguage.Name = tbNaamBewerken.Text;

            try
            {
                selectedLanguage.ID = Convert.ToInt32(tbIDBewerken.Text);
            }
            catch (Exception) { MessageBox.Show("Foutieve invoer tijdens het bewerken van de taal"); }

            LanguageManagement.UpdateLanguage(selectedLanguage);
        }

        private void opslaanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "DAT files (*.dat)|*.dat";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                LanguageManagement.SaveToFile(saveFileDialog.FileName);
            }
        }

        private void openenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "DAT files (*.dat)|*.dat";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LanguageManagement.LoadFromFile(openFileDialog.FileName);
            }

            lbAlleTalen.DataSource = LanguageManagement.GetAllLanguages();
        }
    }
}
