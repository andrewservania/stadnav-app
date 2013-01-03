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

        /// <summary>
        /// Constructor for the 'Manage Language' form.
        /// </summary>
        /// <param name="main_Tool"></param>
        public Manage_Language(Main_Tool main_Tool)
        {
            InitializeComponent();

            this.main_Tool = main_Tool;

            lbAlleTalen.DataSource = LanguageManagement.GetAllLanguages();
        }

        /// <summary>
        /// Method that handles the 'Click' on the help toolstrip-item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method that handles the 'Click' on 'btnToevoegen'
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                int newId;

                if(!int.TryParse(tbIDToevoegen.Text, out newId))
                {
                    MessageBox.Show("Er is een foutieve invoer bij de ID van de nieuwe taal");
                    return;
                }

                bool addedLanguage = LanguageManagement.AddLanguage(newId, tbNaamToevoegen.Text);

                if (!addedLanguage)
                    MessageBox.Show("Er bestaat al een taal met dit ID!");
            }
            catch (Exception) { MessageBox.Show("Foutieve invoer tijdens het aanmaken van de taal"); }
        }

        /// <summary>
        /// Method that handles index changes on the listbox that contains all the languages.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAlleTalen.Items.Count > 0)
            {
                selectedLanguage = (Language) lbAlleTalen.SelectedItem;
                tbIDBewerken.Text = "" + selectedLanguage.ID;
                tbNaamBewerken.Text = selectedLanguage.Name;
            }
        }

        /// <summary>
        /// Method that handles the 'Click' on 'btnBewerken'.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBewerken_Click(object sender, EventArgs e)
        {
            selectedLanguage.Name = tbNaamBewerken.Text;
            int newId;

            if (!int.TryParse(tbIDBewerken.Text, out newId))
            {
                MessageBox.Show("Er is een foutieve invoer bij de ID van de bewerkte taal");
                return;
            }

            selectedLanguage.ID = newId;

            LanguageManagement.UpdateLanguage(selectedLanguage);
        }

        /// <summary>
        /// Method that handles the 'Click' on the 'Afsluiten' toolstrip-item.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void afsluitenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
