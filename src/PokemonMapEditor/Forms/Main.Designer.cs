
namespace PokemonMapEditor.Forms
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.FileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenROMMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveROMMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileMenuSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitAppMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OptionsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.MapTab = new System.Windows.Forms.TabPage();
            this.MapPanel = new System.Windows.Forms.Panel();
            this.PropertiesTab = new System.Windows.Forms.TabPage();
            this.HeaderTab = new System.Windows.Forms.TabPage();
            this.MapsTree = new System.Windows.Forms.TreeView();
            this.MainStatusBar = new System.Windows.Forms.StatusStrip();
            this.AppStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MapStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TileStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LocationStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.EditorTab = new System.Windows.Forms.TabControl();
            this.TilesTab = new System.Windows.Forms.TabPage();
            this.MovementsTab = new System.Windows.Forms.TabPage();
            this.EventsTab = new System.Windows.Forms.TabPage();
            this.PropertiesPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.TilesPanel = new System.Windows.Forms.Panel();
            this.MovementsPanel = new System.Windows.Forms.Panel();
            this.MapCanvas = new System.Windows.Forms.PictureBox();
            this.TilesCanvas = new System.Windows.Forms.PictureBox();
            this.MainMenu.SuspendLayout();
            this.MainTabs.SuspendLayout();
            this.MapTab.SuspendLayout();
            this.MapPanel.SuspendLayout();
            this.PropertiesTab.SuspendLayout();
            this.HeaderTab.SuspendLayout();
            this.MainStatusBar.SuspendLayout();
            this.EditorTab.SuspendLayout();
            this.TilesTab.SuspendLayout();
            this.MovementsTab.SuspendLayout();
            this.TilesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MapCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilesCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenu,
            this.OptionsMenu,
            this.ToolsMenu,
            this.HelpMenu});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(1818, 33);
            this.MainMenu.TabIndex = 0;
            // 
            // FileMenu
            // 
            this.FileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenROMMenuItem,
            this.SaveROMMenuItem,
            this.FileMenuSeparator1,
            this.ExitAppMenuItem});
            this.FileMenu.Name = "FileMenu";
            this.FileMenu.Size = new System.Drawing.Size(54, 29);
            this.FileMenu.Text = "&File";
            // 
            // OpenROMMenuItem
            // 
            this.OpenROMMenuItem.Name = "OpenROMMenuItem";
            this.OpenROMMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenROMMenuItem.Size = new System.Drawing.Size(281, 34);
            this.OpenROMMenuItem.Text = "Open ROM...";
            this.OpenROMMenuItem.Click += new System.EventHandler(this.OpenROMMenuItem_Click);
            // 
            // SaveROMMenuItem
            // 
            this.SaveROMMenuItem.Name = "SaveROMMenuItem";
            this.SaveROMMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveROMMenuItem.Size = new System.Drawing.Size(281, 34);
            this.SaveROMMenuItem.Text = "Save ROM";
            this.SaveROMMenuItem.Click += new System.EventHandler(this.SaveROMMenuItem_Click);
            // 
            // FileMenuSeparator1
            // 
            this.FileMenuSeparator1.Name = "FileMenuSeparator1";
            this.FileMenuSeparator1.Size = new System.Drawing.Size(278, 6);
            // 
            // ExitAppMenuItem
            // 
            this.ExitAppMenuItem.Name = "ExitAppMenuItem";
            this.ExitAppMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.ExitAppMenuItem.Size = new System.Drawing.Size(281, 34);
            this.ExitAppMenuItem.Text = "Exit";
            this.ExitAppMenuItem.Click += new System.EventHandler(this.ExitAppMenuItem_Click);
            // 
            // OptionsMenu
            // 
            this.OptionsMenu.Name = "OptionsMenu";
            this.OptionsMenu.Size = new System.Drawing.Size(92, 29);
            this.OptionsMenu.Text = "Options";
            // 
            // ToolsMenu
            // 
            this.ToolsMenu.Name = "ToolsMenu";
            this.ToolsMenu.Size = new System.Drawing.Size(69, 29);
            this.ToolsMenu.Text = "Tools";
            // 
            // HelpMenu
            // 
            this.HelpMenu.Name = "HelpMenu";
            this.HelpMenu.Size = new System.Drawing.Size(65, 29);
            this.HelpMenu.Text = "Help";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainToolStrip.Location = new System.Drawing.Point(0, 33);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.Size = new System.Drawing.Size(1818, 25);
            this.MainToolStrip.TabIndex = 1;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // MainTabs
            // 
            this.MainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabs.Controls.Add(this.MapTab);
            this.MainTabs.Controls.Add(this.PropertiesTab);
            this.MainTabs.Controls.Add(this.HeaderTab);
            this.MainTabs.Location = new System.Drawing.Point(352, 74);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(1068, 951);
            this.MainTabs.TabIndex = 2;
            // 
            // MapTab
            // 
            this.MapTab.Controls.Add(this.MapPanel);
            this.MapTab.Location = new System.Drawing.Point(4, 34);
            this.MapTab.Name = "MapTab";
            this.MapTab.Padding = new System.Windows.Forms.Padding(3);
            this.MapTab.Size = new System.Drawing.Size(1060, 913);
            this.MapTab.TabIndex = 0;
            this.MapTab.Text = "Map";
            this.MapTab.UseVisualStyleBackColor = true;
            // 
            // MapPanel
            // 
            this.MapPanel.Controls.Add(this.MapCanvas);
            this.MapPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MapPanel.Location = new System.Drawing.Point(3, 3);
            this.MapPanel.Name = "MapPanel";
            this.MapPanel.Size = new System.Drawing.Size(1054, 907);
            this.MapPanel.TabIndex = 0;
            // 
            // PropertiesTab
            // 
            this.PropertiesTab.Controls.Add(this.PropertiesPanel);
            this.PropertiesTab.Location = new System.Drawing.Point(4, 34);
            this.PropertiesTab.Name = "PropertiesTab";
            this.PropertiesTab.Padding = new System.Windows.Forms.Padding(3);
            this.PropertiesTab.Size = new System.Drawing.Size(1060, 913);
            this.PropertiesTab.TabIndex = 1;
            this.PropertiesTab.Text = "Properties";
            this.PropertiesTab.UseVisualStyleBackColor = true;
            // 
            // HeaderTab
            // 
            this.HeaderTab.Controls.Add(this.HeaderPanel);
            this.HeaderTab.Location = new System.Drawing.Point(4, 34);
            this.HeaderTab.Name = "HeaderTab";
            this.HeaderTab.Size = new System.Drawing.Size(1060, 913);
            this.HeaderTab.TabIndex = 2;
            this.HeaderTab.Text = "Header";
            this.HeaderTab.UseVisualStyleBackColor = true;
            // 
            // MapsTree
            // 
            this.MapsTree.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.MapsTree.Location = new System.Drawing.Point(12, 74);
            this.MapsTree.Name = "MapsTree";
            this.MapsTree.Size = new System.Drawing.Size(324, 951);
            this.MapsTree.TabIndex = 3;
            // 
            // MainStatusBar
            // 
            this.MainStatusBar.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AppStatusLabel,
            this.MapStatusLabel,
            this.TileStatusLabel,
            this.LocationStatusLabel});
            this.MainStatusBar.Location = new System.Drawing.Point(0, 1029);
            this.MainStatusBar.Name = "MainStatusBar";
            this.MainStatusBar.Size = new System.Drawing.Size(1818, 36);
            this.MainStatusBar.TabIndex = 4;
            this.MainStatusBar.Text = "statusStrip1";
            // 
            // AppStatusLabel
            // 
            this.AppStatusLabel.AutoSize = false;
            this.AppStatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.AppStatusLabel.Name = "AppStatusLabel";
            this.AppStatusLabel.Size = new System.Drawing.Size(335, 29);
            this.AppStatusLabel.Text = "Welcome ^^";
            this.AppStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // MapStatusLabel
            // 
            this.MapStatusLabel.Name = "MapStatusLabel";
            this.MapStatusLabel.Size = new System.Drawing.Size(0, 29);
            // 
            // TileStatusLabel
            // 
            this.TileStatusLabel.Name = "TileStatusLabel";
            this.TileStatusLabel.Size = new System.Drawing.Size(0, 29);
            // 
            // LocationStatusLabel
            // 
            this.LocationStatusLabel.Name = "LocationStatusLabel";
            this.LocationStatusLabel.Size = new System.Drawing.Size(0, 29);
            // 
            // EditorTab
            // 
            this.EditorTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditorTab.Controls.Add(this.TilesTab);
            this.EditorTab.Controls.Add(this.MovementsTab);
            this.EditorTab.Controls.Add(this.EventsTab);
            this.EditorTab.Location = new System.Drawing.Point(1437, 74);
            this.EditorTab.Name = "EditorTab";
            this.EditorTab.SelectedIndex = 0;
            this.EditorTab.Size = new System.Drawing.Size(369, 951);
            this.EditorTab.TabIndex = 5;
            // 
            // TilesTab
            // 
            this.TilesTab.Controls.Add(this.TilesPanel);
            this.TilesTab.Location = new System.Drawing.Point(4, 34);
            this.TilesTab.Name = "TilesTab";
            this.TilesTab.Padding = new System.Windows.Forms.Padding(3);
            this.TilesTab.Size = new System.Drawing.Size(361, 913);
            this.TilesTab.TabIndex = 0;
            this.TilesTab.Text = "Tiles";
            this.TilesTab.UseVisualStyleBackColor = true;
            // 
            // MovementsTab
            // 
            this.MovementsTab.Controls.Add(this.MovementsPanel);
            this.MovementsTab.Location = new System.Drawing.Point(4, 34);
            this.MovementsTab.Name = "MovementsTab";
            this.MovementsTab.Padding = new System.Windows.Forms.Padding(3);
            this.MovementsTab.Size = new System.Drawing.Size(361, 913);
            this.MovementsTab.TabIndex = 1;
            this.MovementsTab.Text = "Movements";
            this.MovementsTab.UseVisualStyleBackColor = true;
            // 
            // EventsTab
            // 
            this.EventsTab.Location = new System.Drawing.Point(4, 34);
            this.EventsTab.Name = "EventsTab";
            this.EventsTab.Size = new System.Drawing.Size(361, 913);
            this.EventsTab.TabIndex = 2;
            this.EventsTab.Text = "Events";
            this.EventsTab.UseVisualStyleBackColor = true;
            // 
            // PropertiesPanel
            // 
            this.PropertiesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertiesPanel.Location = new System.Drawing.Point(3, 3);
            this.PropertiesPanel.Name = "PropertiesPanel";
            this.PropertiesPanel.Size = new System.Drawing.Size(1054, 907);
            this.PropertiesPanel.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(1060, 913);
            this.HeaderPanel.TabIndex = 0;
            // 
            // TilesPanel
            // 
            this.TilesPanel.Controls.Add(this.TilesCanvas);
            this.TilesPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TilesPanel.Location = new System.Drawing.Point(3, 3);
            this.TilesPanel.Name = "TilesPanel";
            this.TilesPanel.Size = new System.Drawing.Size(355, 907);
            this.TilesPanel.TabIndex = 0;
            // 
            // MovementsPanel
            // 
            this.MovementsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MovementsPanel.Location = new System.Drawing.Point(3, 3);
            this.MovementsPanel.Name = "MovementsPanel";
            this.MovementsPanel.Size = new System.Drawing.Size(355, 907);
            this.MovementsPanel.TabIndex = 0;
            // 
            // MapCanvas
            // 
            this.MapCanvas.Location = new System.Drawing.Point(0, 0);
            this.MapCanvas.Name = "MapCanvas";
            this.MapCanvas.Size = new System.Drawing.Size(450, 353);
            this.MapCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MapCanvas.TabIndex = 0;
            this.MapCanvas.TabStop = false;
            // 
            // TilesCanvas
            // 
            this.TilesCanvas.Location = new System.Drawing.Point(0, 0);
            this.TilesCanvas.Name = "TilesCanvas";
            this.TilesCanvas.Size = new System.Drawing.Size(234, 181);
            this.TilesCanvas.TabIndex = 0;
            this.TilesCanvas.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1818, 1065);
            this.Controls.Add(this.EditorTab);
            this.Controls.Add(this.MainStatusBar);
            this.Controls.Add(this.MapsTree);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.MainToolStrip);
            this.Controls.Add(this.MainMenu);
            this.MainMenuStrip = this.MainMenu;
            this.Name = "Main";
            this.Text = "Pokemon Map Editor";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.MainTabs.ResumeLayout(false);
            this.MapTab.ResumeLayout(false);
            this.MapPanel.ResumeLayout(false);
            this.MapPanel.PerformLayout();
            this.PropertiesTab.ResumeLayout(false);
            this.HeaderTab.ResumeLayout(false);
            this.MainStatusBar.ResumeLayout(false);
            this.MainStatusBar.PerformLayout();
            this.EditorTab.ResumeLayout(false);
            this.TilesTab.ResumeLayout(false);
            this.MovementsTab.ResumeLayout(false);
            this.TilesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MapCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TilesCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem FileMenu;
        private System.Windows.Forms.ToolStripMenuItem OpenROMMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveROMMenuItem;
        private System.Windows.Forms.ToolStripSeparator FileMenuSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ExitAppMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OptionsMenu;
        private System.Windows.Forms.ToolStripMenuItem ToolsMenu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenu;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.TabControl MainTabs;
        private System.Windows.Forms.TabPage MapTab;
        private System.Windows.Forms.TabPage PropertiesTab;
        private System.Windows.Forms.TreeView MapsTree;
        private System.Windows.Forms.StatusStrip MainStatusBar;
        private System.Windows.Forms.TabControl EditorTab;
        private System.Windows.Forms.TabPage TilesTab;
        private System.Windows.Forms.TabPage MovementsTab;
        private System.Windows.Forms.ToolStripStatusLabel AppStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel MapStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel TileStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel LocationStatusLabel;
        private System.Windows.Forms.Panel MapPanel;
        private System.Windows.Forms.TabPage HeaderTab;
        private System.Windows.Forms.TabPage EventsTab;
        private System.Windows.Forms.Panel PropertiesPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Panel TilesPanel;
        private System.Windows.Forms.Panel MovementsPanel;
        private System.Windows.Forms.PictureBox MapCanvas;
        private System.Windows.Forms.PictureBox TilesCanvas;
    }
}

