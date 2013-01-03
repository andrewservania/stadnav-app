namespace StadNavDesktopTool
{
    partial class Main_Tool
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.BrowseText = new System.Windows.Forms.TextBox();
            this.BrowseBT = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beherenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.talenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.waypointsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bewerkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAlert = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.routeDataOpslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeDataOpenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRouteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Product ID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "vul hier de product ID in";
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(8, 39);
            this.checkBox2.MinimumSize = new System.Drawing.Size(59, 23);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(70, 23);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "Schrijven";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(182, 39);
            this.checkBox3.MinimumSize = new System.Drawing.Size(59, 23);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(68, 23);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "Kopieren";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(9, 313);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(67, 17);
            this.checkBox4.TabIndex = 7;
            this.checkBox4.Text = "Emulator";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(278, 30);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(364, 300);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // BrowseText
            // 
            this.BrowseText.Location = new System.Drawing.Point(8, 19);
            this.BrowseText.Name = "BrowseText";
            this.BrowseText.Size = new System.Drawing.Size(162, 20);
            this.BrowseText.TabIndex = 10;
            // 
            // BrowseBT
            // 
            this.BrowseBT.Location = new System.Drawing.Point(182, 19);
            this.BrowseBT.Name = "BrowseBT";
            this.BrowseBT.Size = new System.Drawing.Size(71, 20);
            this.BrowseBT.TabIndex = 11;
            this.BrowseBT.Text = "Browse";
            this.BrowseBT.UseVisualStyleBackColor = true;
            this.BrowseBT.Click += new System.EventHandler(this.BrowseBT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beherenToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(654, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // beherenToolStripMenuItem
            // 
            this.beherenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afsluitenToolStripMenuItem,
            this.routeDataOpslaanToolStripMenuItem,
            this.routeDataOpenenToolStripMenuItem,
            this.resetRouteDataToolStripMenuItem});
            this.beherenToolStripMenuItem.Name = "beherenToolStripMenuItem";
            this.beherenToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.beherenToolStripMenuItem.Text = "File";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeToolStripMenuItem,
            this.talenToolStripMenuItem,
            this.waypointsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.fileToolStripMenuItem.Text = "Beheren";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aanpassenToolStripMenuItem});
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            this.routeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.routeToolStripMenuItem.Text = "Route\'s";
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            this.aanpassenToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.aanpassenToolStripMenuItem.Text = "Beheren..";
            this.aanpassenToolStripMenuItem.Click += new System.EventHandler(this.aanpassenToolStripMenuItem_Click);
            // 
            // talenToolStripMenuItem
            // 
            this.talenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkenToolStripMenuItem1});
            this.talenToolStripMenuItem.Name = "talenToolStripMenuItem";
            this.talenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.talenToolStripMenuItem.Text = "Talen";
            // 
            // bewerkenToolStripMenuItem1
            // 
            this.bewerkenToolStripMenuItem1.Name = "bewerkenToolStripMenuItem1";
            this.bewerkenToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.bewerkenToolStripMenuItem1.Text = "Beheren..";
            this.bewerkenToolStripMenuItem1.Click += new System.EventHandler(this.bewerkenToolStripMenuItem1_Click);
            // 
            // waypointsToolStripMenuItem
            // 
            this.waypointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkenToolStripMenuItem});
            this.waypointsToolStripMenuItem.Name = "waypointsToolStripMenuItem";
            this.waypointsToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.waypointsToolStripMenuItem.Text = "Waypoints";
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            this.bewerkenToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.bewerkenToolStripMenuItem.Text = "Beheren..";
            this.bewerkenToolStripMenuItem.Click += new System.EventHandler(this.bewerkenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlert);
            this.groupBox1.Controls.Add(this.BrowseBT);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.BrowseText);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Location = new System.Drawing.Point(9, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 229);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Actie\'s";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(5, 64);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(243, 13);
            this.lblAlert.TabIndex = 12;
            this.lblAlert.Text = "Pas op! Dit overschrijft de gehele isolated storage!";
            this.lblAlert.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(194, 307);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "Uitvoeren";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // routeDataOpslaanToolStripMenuItem
            // 
            this.routeDataOpslaanToolStripMenuItem.Name = "routeDataOpslaanToolStripMenuItem";
            this.routeDataOpslaanToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.routeDataOpslaanToolStripMenuItem.Text = "Route Data Opslaan..";
            this.routeDataOpslaanToolStripMenuItem.Click += new System.EventHandler(this.routeDataOpslaanToolStripMenuItem_Click);
            // 
            // routeDataOpenenToolStripMenuItem
            // 
            this.routeDataOpenenToolStripMenuItem.Name = "routeDataOpenenToolStripMenuItem";
            this.routeDataOpenenToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.routeDataOpenenToolStripMenuItem.Text = "Route Data Openen..";
            this.routeDataOpenenToolStripMenuItem.Click += new System.EventHandler(this.routeDataOpenenToolStripMenuItem_Click);
            // 
            // resetRouteDataToolStripMenuItem
            // 
            this.resetRouteDataToolStripMenuItem.Name = "resetRouteDataToolStripMenuItem";
            this.resetRouteDataToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.resetRouteDataToolStripMenuItem.Text = "Reset Route Data";
            this.resetRouteDataToolStripMenuItem.Click += new System.EventHandler(this.resetRouteDataToolStripMenuItem_Click);
            // 
            // Main_Tool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 342);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Tool";
            this.Text = "Desktoptool StadNav";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox BrowseText;
        private System.Windows.Forms.Button BrowseBT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.ToolStripMenuItem routeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem talenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewerkenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem waypointsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bewerkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem beherenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeDataOpslaanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routeDataOpenenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetRouteDataToolStripMenuItem;
    }
}

