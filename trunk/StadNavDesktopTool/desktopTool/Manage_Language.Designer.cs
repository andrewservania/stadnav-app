namespace StadNavDesktopTool
{
    partial class Manage_Language
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbAlleTalen = new System.Windows.Forms.ListBox();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBewerken = new System.Windows.Forms.Button();
            this.tbIDBewerken = new System.Windows.Forms.TextBox();
            this.lblIDBewerken = new System.Windows.Forms.Label();
            this.tbNaamBewerken = new System.Windows.Forms.TextBox();
            this.lblNaamBewerken = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.tbIDToevoegen = new System.Windows.Forms.TextBox();
            this.lblIDToevoegen = new System.Windows.Forms.Label();
            this.tbNaamToevoegen = new System.Windows.Forms.TextBox();
            this.lblNaamToevoegen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAlleTalen
            // 
            this.lbAlleTalen.FormattingEnabled = true;
            this.lbAlleTalen.Items.AddRange(new object[] {
            "Nederlands",
            "English"});
            this.lbAlleTalen.Location = new System.Drawing.Point(279, 37);
            this.lbAlleTalen.Name = "lbAlleTalen";
            this.lbAlleTalen.Size = new System.Drawing.Size(241, 186);
            this.lbAlleTalen.TabIndex = 0;
            this.lbAlleTalen.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(445, 229);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 27);
            this.btnVerwijderen.TabIndex = 1;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBewerken);
            this.groupBox1.Controls.Add(this.tbIDBewerken);
            this.groupBox1.Controls.Add(this.lblIDBewerken);
            this.groupBox1.Controls.Add(this.tbNaamBewerken);
            this.groupBox1.Controls.Add(this.lblNaamBewerken);
            this.groupBox1.Location = new System.Drawing.Point(14, 142);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Bewerken";
            // 
            // btnBewerken
            // 
            this.btnBewerken.Location = new System.Drawing.Point(178, 84);
            this.btnBewerken.Name = "btnBewerken";
            this.btnBewerken.Size = new System.Drawing.Size(75, 23);
            this.btnBewerken.TabIndex = 9;
            this.btnBewerken.Text = "Bewerken";
            this.btnBewerken.UseVisualStyleBackColor = true;
            this.btnBewerken.Click += new System.EventHandler(this.btnBewerken_Click);
            // 
            // tbIDBewerken
            // 
            this.tbIDBewerken.Location = new System.Drawing.Point(118, 52);
            this.tbIDBewerken.Name = "tbIDBewerken";
            this.tbIDBewerken.Size = new System.Drawing.Size(135, 20);
            this.tbIDBewerken.TabIndex = 8;
            // 
            // lblIDBewerken
            // 
            this.lblIDBewerken.AutoSize = true;
            this.lblIDBewerken.Location = new System.Drawing.Point(7, 55);
            this.lblIDBewerken.Name = "lblIDBewerken";
            this.lblIDBewerken.Size = new System.Drawing.Size(21, 13);
            this.lblIDBewerken.TabIndex = 7;
            this.lblIDBewerken.Text = "ID:";
            // 
            // tbNaamBewerken
            // 
            this.tbNaamBewerken.Location = new System.Drawing.Point(118, 26);
            this.tbNaamBewerken.Name = "tbNaamBewerken";
            this.tbNaamBewerken.Size = new System.Drawing.Size(135, 20);
            this.tbNaamBewerken.TabIndex = 6;
            // 
            // lblNaamBewerken
            // 
            this.lblNaamBewerken.AutoSize = true;
            this.lblNaamBewerken.Location = new System.Drawing.Point(7, 29);
            this.lblNaamBewerken.Name = "lblNaamBewerken";
            this.lblNaamBewerken.Size = new System.Drawing.Size(38, 13);
            this.lblNaamBewerken.TabIndex = 5;
            this.lblNaamBewerken.Text = "Naam:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnToevoegen);
            this.groupBox2.Controls.Add(this.tbIDToevoegen);
            this.groupBox2.Controls.Add(this.lblIDToevoegen);
            this.groupBox2.Controls.Add(this.tbNaamToevoegen);
            this.groupBox2.Controls.Add(this.lblNaamToevoegen);
            this.groupBox2.Location = new System.Drawing.Point(12, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Toevoegen";
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(180, 76);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(75, 23);
            this.btnToevoegen.TabIndex = 4;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // tbIDToevoegen
            // 
            this.tbIDToevoegen.Location = new System.Drawing.Point(120, 50);
            this.tbIDToevoegen.Name = "tbIDToevoegen";
            this.tbIDToevoegen.Size = new System.Drawing.Size(135, 20);
            this.tbIDToevoegen.TabIndex = 3;
            // 
            // lblIDToevoegen
            // 
            this.lblIDToevoegen.AutoSize = true;
            this.lblIDToevoegen.Location = new System.Drawing.Point(10, 53);
            this.lblIDToevoegen.Name = "lblIDToevoegen";
            this.lblIDToevoegen.Size = new System.Drawing.Size(21, 13);
            this.lblIDToevoegen.TabIndex = 2;
            this.lblIDToevoegen.Text = "ID:";
            // 
            // tbNaamToevoegen
            // 
            this.tbNaamToevoegen.Location = new System.Drawing.Point(120, 24);
            this.tbNaamToevoegen.Name = "tbNaamToevoegen";
            this.tbNaamToevoegen.Size = new System.Drawing.Size(135, 20);
            this.tbNaamToevoegen.TabIndex = 1;
            // 
            // lblNaamToevoegen
            // 
            this.lblNaamToevoegen.AutoSize = true;
            this.lblNaamToevoegen.Location = new System.Drawing.Point(10, 27);
            this.lblNaamToevoegen.Name = "lblNaamToevoegen";
            this.lblNaamToevoegen.Size = new System.Drawing.Size(38, 13);
            this.lblNaamToevoegen.TabIndex = 0;
            this.lblNaamToevoegen.Text = "Naam:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(527, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem1});
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afsluitenToolStripMenuItem.Text = "Bestand";
            // 
            // afsluitenToolStripMenuItem1
            // 
            this.afsluitenToolStripMenuItem1.Name = "afsluitenToolStripMenuItem1";
            this.afsluitenToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.afsluitenToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.afsluitenToolStripMenuItem1.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem1.Click += new System.EventHandler(this.afsluitenToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // Manage_Language
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.lbAlleTalen);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Manage_Language";
            this.Text = "Talen beheren";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbAlleTalen;
        private System.Windows.Forms.Button btnVerwijderen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBewerken;
        private System.Windows.Forms.TextBox tbIDBewerken;
        private System.Windows.Forms.Label lblIDBewerken;
        private System.Windows.Forms.TextBox tbNaamBewerken;
        private System.Windows.Forms.Label lblNaamBewerken;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.TextBox tbIDToevoegen;
        private System.Windows.Forms.Label lblIDToevoegen;
        private System.Windows.Forms.TextBox tbNaamToevoegen;
        private System.Windows.Forms.Label lblNaamToevoegen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem1;
    }
}