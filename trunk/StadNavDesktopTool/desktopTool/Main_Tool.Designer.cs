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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Tool));
            this.label1 = new System.Windows.Forms.Label();
            this.tbProductID = new System.Windows.Forms.TextBox();
            this.cbSchrijven = new System.Windows.Forms.CheckBox();
            this.cbKopieren = new System.Windows.Forms.CheckBox();
            this.cbGebruikEmulator = new System.Windows.Forms.CheckBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.tbBrowseURL = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.beherenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeDataOpslaanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routeDataOpenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetRouteDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
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
            this.btnUitvoeren = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbProductID
            // 
            resources.ApplyResources(this.tbProductID, "tbProductID");
            this.tbProductID.Name = "tbProductID";
            this.tbProductID.Enter += new System.EventHandler(this.textBox1_Enter);
            // 
            // cbSchrijven
            // 
            resources.ApplyResources(this.cbSchrijven, "cbSchrijven");
            this.cbSchrijven.Name = "cbSchrijven";
            this.cbSchrijven.UseVisualStyleBackColor = true;
            this.cbSchrijven.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // cbKopieren
            // 
            resources.ApplyResources(this.cbKopieren, "cbKopieren");
            this.cbKopieren.Name = "cbKopieren";
            this.cbKopieren.UseVisualStyleBackColor = true;
            this.cbKopieren.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // cbGebruikEmulator
            // 
            resources.ApplyResources(this.cbGebruikEmulator, "cbGebruikEmulator");
            this.cbGebruikEmulator.Name = "cbGebruikEmulator";
            this.cbGebruikEmulator.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            resources.ApplyResources(this.rtbOutput, "rtbOutput");
            this.rtbOutput.Name = "rtbOutput";
            // 
            // tbBrowseURL
            // 
            resources.ApplyResources(this.tbBrowseURL, "tbBrowseURL");
            this.tbBrowseURL.Name = "tbBrowseURL";
            // 
            // btnBrowse
            // 
            resources.ApplyResources(this.btnBrowse, "btnBrowse");
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BrowseBT_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.beherenToolStripMenuItem,
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // beherenToolStripMenuItem
            // 
            this.beherenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeDataOpslaanToolStripMenuItem,
            this.routeDataOpenenToolStripMenuItem,
            this.resetRouteDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.afsluitenToolStripMenuItem});
            this.beherenToolStripMenuItem.Name = "beherenToolStripMenuItem";
            resources.ApplyResources(this.beherenToolStripMenuItem, "beherenToolStripMenuItem");
            // 
            // routeDataOpslaanToolStripMenuItem
            // 
            this.routeDataOpslaanToolStripMenuItem.Name = "routeDataOpslaanToolStripMenuItem";
            resources.ApplyResources(this.routeDataOpslaanToolStripMenuItem, "routeDataOpslaanToolStripMenuItem");
            this.routeDataOpslaanToolStripMenuItem.Click += new System.EventHandler(this.routeDataOpslaanToolStripMenuItem_Click);
            // 
            // routeDataOpenenToolStripMenuItem
            // 
            this.routeDataOpenenToolStripMenuItem.Name = "routeDataOpenenToolStripMenuItem";
            resources.ApplyResources(this.routeDataOpenenToolStripMenuItem, "routeDataOpenenToolStripMenuItem");
            this.routeDataOpenenToolStripMenuItem.Click += new System.EventHandler(this.routeDataOpenenToolStripMenuItem_Click);
            // 
            // resetRouteDataToolStripMenuItem
            // 
            this.resetRouteDataToolStripMenuItem.Name = "resetRouteDataToolStripMenuItem";
            resources.ApplyResources(this.resetRouteDataToolStripMenuItem, "resetRouteDataToolStripMenuItem");
            this.resetRouteDataToolStripMenuItem.Click += new System.EventHandler(this.resetRouteDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            resources.ApplyResources(this.afsluitenToolStripMenuItem, "afsluitenToolStripMenuItem");
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.routeToolStripMenuItem,
            this.talenToolStripMenuItem,
            this.waypointsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // routeToolStripMenuItem
            // 
            this.routeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aanpassenToolStripMenuItem});
            this.routeToolStripMenuItem.Name = "routeToolStripMenuItem";
            resources.ApplyResources(this.routeToolStripMenuItem, "routeToolStripMenuItem");
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            resources.ApplyResources(this.aanpassenToolStripMenuItem, "aanpassenToolStripMenuItem");
            this.aanpassenToolStripMenuItem.Click += new System.EventHandler(this.aanpassenToolStripMenuItem_Click);
            // 
            // talenToolStripMenuItem
            // 
            this.talenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkenToolStripMenuItem1});
            this.talenToolStripMenuItem.Name = "talenToolStripMenuItem";
            resources.ApplyResources(this.talenToolStripMenuItem, "talenToolStripMenuItem");
            // 
            // bewerkenToolStripMenuItem1
            // 
            this.bewerkenToolStripMenuItem1.Name = "bewerkenToolStripMenuItem1";
            resources.ApplyResources(this.bewerkenToolStripMenuItem1, "bewerkenToolStripMenuItem1");
            this.bewerkenToolStripMenuItem1.Click += new System.EventHandler(this.bewerkenToolStripMenuItem1_Click);
            // 
            // waypointsToolStripMenuItem
            // 
            this.waypointsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bewerkenToolStripMenuItem});
            this.waypointsToolStripMenuItem.Name = "waypointsToolStripMenuItem";
            resources.ApplyResources(this.waypointsToolStripMenuItem, "waypointsToolStripMenuItem");
            // 
            // bewerkenToolStripMenuItem
            // 
            this.bewerkenToolStripMenuItem.Name = "bewerkenToolStripMenuItem";
            resources.ApplyResources(this.bewerkenToolStripMenuItem, "bewerkenToolStripMenuItem");
            this.bewerkenToolStripMenuItem.Click += new System.EventHandler(this.bewerkenToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            resources.ApplyResources(this.helpToolStripMenuItem, "helpToolStripMenuItem");
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAlert);
            this.groupBox1.Controls.Add(this.btnBrowse);
            this.groupBox1.Controls.Add(this.cbSchrijven);
            this.groupBox1.Controls.Add(this.tbBrowseURL);
            this.groupBox1.Controls.Add(this.cbKopieren);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblAlert
            // 
            resources.ApplyResources(this.lblAlert, "lblAlert");
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Name = "lblAlert";
            // 
            // btnUitvoeren
            // 
            resources.ApplyResources(this.btnUitvoeren, "btnUitvoeren");
            this.btnUitvoeren.Name = "btnUitvoeren";
            this.btnUitvoeren.UseVisualStyleBackColor = true;
            this.btnUitvoeren.Click += new System.EventHandler(this.btnUitvoeren_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip1, "contextMenuStrip1");
            // 
            // Main_Tool
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnUitvoeren);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.cbGebruikEmulator);
            this.Controls.Add(this.tbProductID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main_Tool";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbProductID;
        private System.Windows.Forms.CheckBox cbSchrijven;
        private System.Windows.Forms.CheckBox cbKopieren;
        private System.Windows.Forms.CheckBox cbGebruikEmulator;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox tbBrowseURL;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUitvoeren;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

