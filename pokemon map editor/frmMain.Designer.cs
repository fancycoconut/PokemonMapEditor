namespace PokemonMapEditor
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.AppMenu = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpacer1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPalette = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMorning = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAfternoon = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEvening = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuNight = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPlugins = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSpacer2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuFreeSpaceFinder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.AppToolbar = new System.Windows.Forms.ToolStrip();
            this.tbrOpen = new System.Windows.Forms.ToolStripButton();
            this.tbrSave = new System.Windows.Forms.ToolStripButton();
            this.tbrSpace1 = new System.Windows.Forms.ToolStripSeparator();
            this.AppStatusBar = new System.Windows.Forms.StatusStrip();
            this.lblROM = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentBank = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentMap = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCurrentTile = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlMapList = new System.Windows.Forms.Panel();
            this.treeMaps = new System.Windows.Forms.TreeView();
            this.NodeImages = new System.Windows.Forms.ImageList(this.components);
            this.pnlEditor = new System.Windows.Forms.Panel();
            this.tabEditor = new System.Windows.Forms.TabControl();
            this.tabTiles = new System.Windows.Forms.TabPage();
            this.pnlTileset = new System.Windows.Forms.Panel();
            this.picTileset = new System.Windows.Forms.PictureBox();
            this.tabAttributes = new System.Windows.Forms.TabPage();
            this.picAttributes = new System.Windows.Forms.PictureBox();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.pnlEventProps = new System.Windows.Forms.Panel();
            this.propEvents = new System.Windows.Forms.PropertyGrid();
            this.pnlEvents = new System.Windows.Forms.Panel();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.lblEventIndex = new System.Windows.Forms.Label();
            this.numEvents = new System.Windows.Forms.NumericUpDown();
            this.cmbEvents = new System.Windows.Forms.ComboBox();
            this.pnlCanvas = new System.Windows.Forms.Panel();
            this.tabCanvas = new System.Windows.Forms.TabControl();
            this.tabMap = new System.Windows.Forms.TabPage();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.tabProperties = new System.Windows.Forms.TabPage();
            this.pnlProperties = new System.Windows.Forms.Panel();
            this.picBorder = new System.Windows.Forms.PictureBox();
            this.cmdChangeName = new System.Windows.Forms.Button();
            this.numFloorLevel = new System.Windows.Forms.NumericUpDown();
            this.lblFloorLevel = new System.Windows.Forms.Label();
            this.cmbShowName = new System.Windows.Forms.ComboBox();
            this.lblShowName = new System.Windows.Forms.Label();
            this.lblBorder = new System.Windows.Forms.Label();
            this.fraDimension = new System.Windows.Forms.GroupBox();
            this.cmdResize = new System.Windows.Forms.Button();
            this.lblHeight = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.fraTilesets = new System.Windows.Forms.GroupBox();
            this.cmdChange = new System.Windows.Forms.Button();
            this.lblMinor = new System.Windows.Forms.Label();
            this.txtMinor = new System.Windows.Forms.TextBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.lblMajor = new System.Windows.Forms.Label();
            this.fraMapScripts = new System.Windows.Forms.GroupBox();
            this.fraMapOptions = new System.Windows.Forms.GroupBox();
            this.cmbSong = new System.Windows.Forms.ComboBox();
            this.cmbBattleStyle = new System.Windows.Forms.ComboBox();
            this.lblBattleStyle = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbCaveBehaviour = new System.Windows.Forms.ComboBox();
            this.lblCaveBehaviour = new System.Windows.Forms.Label();
            this.cmbWeather = new System.Windows.Forms.ComboBox();
            this.lblWeather = new System.Windows.Forms.Label();
            this.txtSong = new System.Windows.Forms.TextBox();
            this.lblSong = new System.Windows.Forms.Label();
            this.txtMapName = new System.Windows.Forms.TextBox();
            this.cmbMapNames = new System.Windows.Forms.ComboBox();
            this.lblMapName = new System.Windows.Forms.Label();
            this.tabHeader = new System.Windows.Forms.TabPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.cmdHeader = new System.Windows.Forms.Button();
            this.cmdSaveMinor = new System.Windows.Forms.Button();
            this.cmdSaveMajor = new System.Windows.Forms.Button();
            this.fraBorder = new System.Windows.Forms.GroupBox();
            this.cmdResizeBorder = new System.Windows.Forms.Button();
            this.lblBorderHeight = new System.Windows.Forms.Label();
            this.txtBorderHeight = new System.Windows.Forms.TextBox();
            this.txtBorderWidth = new System.Windows.Forms.TextBox();
            this.lblBorderWidth = new System.Windows.Forms.Label();
            this.fraMinorTileset = new System.Windows.Forms.GroupBox();
            this.lblAnimation2 = new System.Windows.Forms.Label();
            this.lblBehaviours2 = new System.Windows.Forms.Label();
            this.lblBlocks2 = new System.Windows.Forms.Label();
            this.lblPalette2 = new System.Windows.Forms.Label();
            this.txtAnimation2 = new System.Windows.Forms.TextBox();
            this.txtBehaviours2 = new System.Windows.Forms.TextBox();
            this.txtBlocks2 = new System.Windows.Forms.TextBox();
            this.txtPalette2 = new System.Windows.Forms.TextBox();
            this.txtImage2 = new System.Windows.Forms.TextBox();
            this.lblImage2 = new System.Windows.Forms.Label();
            this.chkMajorTileset2 = new System.Windows.Forms.CheckBox();
            this.chkLZ772 = new System.Windows.Forms.CheckBox();
            this.fraMajorTileset = new System.Windows.Forms.GroupBox();
            this.lblAnimation1 = new System.Windows.Forms.Label();
            this.lblBehaviours1 = new System.Windows.Forms.Label();
            this.lblBlocks1 = new System.Windows.Forms.Label();
            this.lblPalette1 = new System.Windows.Forms.Label();
            this.txtAnimation1 = new System.Windows.Forms.TextBox();
            this.txtBehaviours1 = new System.Windows.Forms.TextBox();
            this.txtBlocks1 = new System.Windows.Forms.TextBox();
            this.txtPalette1 = new System.Windows.Forms.TextBox();
            this.txtImage1 = new System.Windows.Forms.TextBox();
            this.lblImage1 = new System.Windows.Forms.Label();
            this.chkMajorTileset1 = new System.Windows.Forms.CheckBox();
            this.chkLZ771 = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMinorTileset = new System.Windows.Forms.Label();
            this.lblMajorTileset = new System.Windows.Forms.Label();
            this.lblMapTileData = new System.Windows.Forms.Label();
            this.lblBorderData = new System.Windows.Forms.Label();
            this.txtMinorTileset = new System.Windows.Forms.TextBox();
            this.txtMajorTileset = new System.Windows.Forms.TextBox();
            this.txtMapTileData = new System.Windows.Forms.TextBox();
            this.txtBorderData = new System.Windows.Forms.TextBox();
            this.fraMapHeader = new System.Windows.Forms.GroupBox();
            this.lblConnections = new System.Windows.Forms.Label();
            this.lblMapScripts = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblMapData = new System.Windows.Forms.Label();
            this.txtConnections = new System.Windows.Forms.TextBox();
            this.txtMapScripts = new System.Windows.Forms.TextBox();
            this.txtEvents = new System.Windows.Forms.TextBox();
            this.txtMapData = new System.Windows.Forms.TextBox();
            this.lblMapHeader = new System.Windows.Forms.Label();
            this.txtMapHeader = new System.Windows.Forms.TextBox();
            this.txtBank = new System.Windows.Forms.TextBox();
            this.lblBank = new System.Windows.Forms.Label();
            this.AppMenu.SuspendLayout();
            this.AppToolbar.SuspendLayout();
            this.AppStatusBar.SuspendLayout();
            this.pnlMapList.SuspendLayout();
            this.pnlEditor.SuspendLayout();
            this.tabEditor.SuspendLayout();
            this.tabTiles.SuspendLayout();
            this.pnlTileset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileset)).BeginInit();
            this.tabAttributes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttributes)).BeginInit();
            this.tabEvents.SuspendLayout();
            this.pnlEventProps.SuspendLayout();
            this.pnlEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEvents)).BeginInit();
            this.pnlCanvas.SuspendLayout();
            this.tabCanvas.SuspendLayout();
            this.tabMap.SuspendLayout();
            this.pnlMap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.tabProperties.SuspendLayout();
            this.pnlProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloorLevel)).BeginInit();
            this.fraDimension.SuspendLayout();
            this.fraTilesets.SuspendLayout();
            this.fraMapOptions.SuspendLayout();
            this.tabHeader.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.fraBorder.SuspendLayout();
            this.fraMinorTileset.SuspendLayout();
            this.fraMajorTileset.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.fraMapHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // AppMenu
            // 
            this.AppMenu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOptions,
            this.mnuTools,
            this.mnuHelp});
            this.AppMenu.Location = new System.Drawing.Point(0, 0);
            this.AppMenu.Name = "AppMenu";
            this.AppMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.AppMenu.Size = new System.Drawing.Size(885, 24);
            this.AppMenu.TabIndex = 0;
            // 
            // mnuFile
            // 
            this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOpen,
            this.mnuSave,
            this.mnuSpacer1,
            this.mnuExit});
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "&File";
            // 
            // mnuOpen
            // 
            this.mnuOpen.Image = global::PokemonMapEditor.Properties.Resources.Open;
            this.mnuOpen.Name = "mnuOpen";
            this.mnuOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mnuOpen.Size = new System.Drawing.Size(185, 22);
            this.mnuOpen.Text = "Open ROM...";
            this.mnuOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // mnuSave
            // 
            this.mnuSave.Enabled = false;
            this.mnuSave.Image = global::PokemonMapEditor.Properties.Resources.Save;
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mnuSave.Size = new System.Drawing.Size(185, 22);
            this.mnuSave.Text = "Save ROM";
            this.mnuSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // mnuSpacer1
            // 
            this.mnuSpacer1.Name = "mnuSpacer1";
            this.mnuSpacer1.Size = new System.Drawing.Size(182, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mnuExit.Size = new System.Drawing.Size(185, 22);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuOptions
            // 
            this.mnuOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPalette});
            this.mnuOptions.Name = "mnuOptions";
            this.mnuOptions.Size = new System.Drawing.Size(61, 20);
            this.mnuOptions.Text = "&Options";
            // 
            // mnuPalette
            // 
            this.mnuPalette.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuNormal,
            this.mnuMorning,
            this.mnuAfternoon,
            this.mnuEvening,
            this.mnuNight,
            this.mnuAuto});
            this.mnuPalette.Name = "mnuPalette";
            this.mnuPalette.Size = new System.Drawing.Size(119, 22);
            this.mnuPalette.Text = "Palette...";
            // 
            // mnuNormal
            // 
            this.mnuNormal.Name = "mnuNormal";
            this.mnuNormal.Size = new System.Drawing.Size(128, 22);
            this.mnuNormal.Text = "Normal";
            this.mnuNormal.Click += new System.EventHandler(this.PaletteSet_Changed);
            // 
            // mnuMorning
            // 
            this.mnuMorning.Name = "mnuMorning";
            this.mnuMorning.Size = new System.Drawing.Size(128, 22);
            this.mnuMorning.Text = "Morning";
            this.mnuMorning.Click += new System.EventHandler(this.PaletteSet_Changed);
            // 
            // mnuAfternoon
            // 
            this.mnuAfternoon.Name = "mnuAfternoon";
            this.mnuAfternoon.Size = new System.Drawing.Size(128, 22);
            this.mnuAfternoon.Text = "Afternoon";
            this.mnuAfternoon.Click += new System.EventHandler(this.PaletteSet_Changed);
            // 
            // mnuEvening
            // 
            this.mnuEvening.Name = "mnuEvening";
            this.mnuEvening.Size = new System.Drawing.Size(128, 22);
            this.mnuEvening.Text = "Evening";
            this.mnuEvening.Click += new System.EventHandler(this.PaletteSet_Changed);
            // 
            // mnuNight
            // 
            this.mnuNight.Name = "mnuNight";
            this.mnuNight.Size = new System.Drawing.Size(128, 22);
            this.mnuNight.Text = "Night";
            this.mnuNight.Click += new System.EventHandler(this.PaletteSet_Changed);
            // 
            // mnuAuto
            // 
            this.mnuAuto.Name = "mnuAuto";
            this.mnuAuto.Size = new System.Drawing.Size(128, 22);
            this.mnuAuto.Text = "Auto";
            this.mnuAuto.Click += new System.EventHandler(this.PaletteSet_Changed);
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuPlugins,
            this.mnuSpacer2,
            this.mnuFreeSpaceFinder});
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(48, 20);
            this.mnuTools.Text = "&Tools";
            this.mnuTools.DropDownOpened += new System.EventHandler(this.mnuTools_DropDownOpened);
            // 
            // mnuPlugins
            // 
            this.mnuPlugins.Name = "mnuPlugins";
            this.mnuPlugins.Size = new System.Drawing.Size(166, 22);
            this.mnuPlugins.Text = "Plugins";
            // 
            // mnuSpacer2
            // 
            this.mnuSpacer2.Name = "mnuSpacer2";
            this.mnuSpacer2.Size = new System.Drawing.Size(163, 6);
            // 
            // mnuFreeSpaceFinder
            // 
            this.mnuFreeSpaceFinder.Name = "mnuFreeSpaceFinder";
            this.mnuFreeSpaceFinder.Size = new System.Drawing.Size(166, 22);
            this.mnuFreeSpaceFinder.Text = "Free Space Finder";
            this.mnuFreeSpaceFinder.Click += new System.EventHandler(this.mnuFreeSpaceFinder_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "&Help";
            // 
            // AppToolbar
            // 
            this.AppToolbar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AppToolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbrOpen,
            this.tbrSave,
            this.tbrSpace1});
            this.AppToolbar.Location = new System.Drawing.Point(0, 24);
            this.AppToolbar.Name = "AppToolbar";
            this.AppToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.AppToolbar.Size = new System.Drawing.Size(885, 25);
            this.AppToolbar.TabIndex = 1;
            // 
            // tbrOpen
            // 
            this.tbrOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrOpen.Image = global::PokemonMapEditor.Properties.Resources.Open;
            this.tbrOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrOpen.Name = "tbrOpen";
            this.tbrOpen.Size = new System.Drawing.Size(23, 22);
            this.tbrOpen.ToolTipText = "Open ROM";
            this.tbrOpen.Click += new System.EventHandler(this.mnuOpen_Click);
            // 
            // tbrSave
            // 
            this.tbrSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbrSave.Enabled = false;
            this.tbrSave.Image = global::PokemonMapEditor.Properties.Resources.Save;
            this.tbrSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbrSave.Name = "tbrSave";
            this.tbrSave.Size = new System.Drawing.Size(23, 22);
            this.tbrSave.ToolTipText = "Save ROM";
            this.tbrSave.Click += new System.EventHandler(this.mnuSave_Click);
            // 
            // tbrSpace1
            // 
            this.tbrSpace1.Name = "tbrSpace1";
            this.tbrSpace1.Size = new System.Drawing.Size(6, 25);
            // 
            // AppStatusBar
            // 
            this.AppStatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblROM,
            this.lblStatus,
            this.toolStripStatusLabel1,
            this.lblCurrentBank,
            this.lblCurrentMap,
            this.lblCurrentTile,
            this.lblLocation});
            this.AppStatusBar.Location = new System.Drawing.Point(0, 528);
            this.AppStatusBar.Name = "AppStatusBar";
            this.AppStatusBar.Size = new System.Drawing.Size(885, 24);
            this.AppStatusBar.TabIndex = 2;
            // 
            // lblROM
            // 
            this.lblROM.AutoSize = false;
            this.lblROM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblROM.Name = "lblROM";
            this.lblROM.Size = new System.Drawing.Size(176, 19);
            this.lblROM.Text = "Welcome ^^";
            this.lblROM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = false;
            this.lblStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(320, 19);
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 19);
            // 
            // lblCurrentBank
            // 
            this.lblCurrentBank.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblCurrentBank.Name = "lblCurrentBank";
            this.lblCurrentBank.Size = new System.Drawing.Size(53, 19);
            this.lblCurrentBank.Text = "Bank: ??";
            // 
            // lblCurrentMap
            // 
            this.lblCurrentMap.Name = "lblCurrentMap";
            this.lblCurrentMap.Size = new System.Drawing.Size(47, 19);
            this.lblCurrentMap.Text = "Map: ??";
            // 
            // lblCurrentTile
            // 
            this.lblCurrentTile.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblCurrentTile.Name = "lblCurrentTile";
            this.lblCurrentTile.Size = new System.Drawing.Size(94, 19);
            this.lblCurrentTile.Text = "Current Tile: ???";
            // 
            // lblLocation
            // 
            this.lblLocation.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(78, 19);
            this.lblLocation.Text = "Location: ???";
            // 
            // pnlMapList
            // 
            this.pnlMapList.Controls.Add(this.treeMaps);
            this.pnlMapList.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMapList.Location = new System.Drawing.Point(0, 49);
            this.pnlMapList.Name = "pnlMapList";
            this.pnlMapList.Size = new System.Drawing.Size(184, 479);
            this.pnlMapList.TabIndex = 3;
            // 
            // treeMaps
            // 
            this.treeMaps.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeMaps.ImageIndex = 0;
            this.treeMaps.ImageList = this.NodeImages;
            this.treeMaps.Location = new System.Drawing.Point(0, 0);
            this.treeMaps.Name = "treeMaps";
            this.treeMaps.SelectedImageIndex = 1;
            this.treeMaps.Size = new System.Drawing.Size(176, 479);
            this.treeMaps.TabIndex = 5;
            this.treeMaps.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeMaps_NodeMouseDoubleClick);
            // 
            // NodeImages
            // 
            this.NodeImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("NodeImages.ImageStream")));
            this.NodeImages.TransparentColor = System.Drawing.Color.Transparent;
            this.NodeImages.Images.SetKeyName(0, "Bank.png");
            this.NodeImages.Images.SetKeyName(1, "Map.png");
            // 
            // pnlEditor
            // 
            this.pnlEditor.Controls.Add(this.tabEditor);
            this.pnlEditor.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlEditor.Location = new System.Drawing.Point(720, 49);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(165, 479);
            this.pnlEditor.TabIndex = 4;
            // 
            // tabEditor
            // 
            this.tabEditor.Controls.Add(this.tabTiles);
            this.tabEditor.Controls.Add(this.tabAttributes);
            this.tabEditor.Controls.Add(this.tabEvents);
            this.tabEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEditor.Location = new System.Drawing.Point(0, 0);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.SelectedIndex = 0;
            this.tabEditor.Size = new System.Drawing.Size(165, 479);
            this.tabEditor.TabIndex = 0;
            this.tabEditor.SelectedIndexChanged += new System.EventHandler(this.tabEditor_SelectedIndexChanged);
            // 
            // tabTiles
            // 
            this.tabTiles.Controls.Add(this.pnlTileset);
            this.tabTiles.Location = new System.Drawing.Point(4, 22);
            this.tabTiles.Name = "tabTiles";
            this.tabTiles.Padding = new System.Windows.Forms.Padding(4);
            this.tabTiles.Size = new System.Drawing.Size(157, 453);
            this.tabTiles.TabIndex = 0;
            this.tabTiles.Text = "Tiles";
            this.tabTiles.UseVisualStyleBackColor = true;
            // 
            // pnlTileset
            // 
            this.pnlTileset.AutoScroll = true;
            this.pnlTileset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTileset.Controls.Add(this.picTileset);
            this.pnlTileset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTileset.Location = new System.Drawing.Point(4, 4);
            this.pnlTileset.Name = "pnlTileset";
            this.pnlTileset.Size = new System.Drawing.Size(149, 445);
            this.pnlTileset.TabIndex = 0;
            this.pnlTileset.Visible = false;
            // 
            // picTileset
            // 
            this.picTileset.Location = new System.Drawing.Point(-2, -2);
            this.picTileset.Name = "picTileset";
            this.picTileset.Size = new System.Drawing.Size(120, 160);
            this.picTileset.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picTileset.TabIndex = 0;
            this.picTileset.TabStop = false;
            this.picTileset.Paint += new System.Windows.Forms.PaintEventHandler(this.picTileset_Paint);
            this.picTileset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTileset_Handle);
            this.picTileset.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picTileset_Handle);
            // 
            // tabAttributes
            // 
            this.tabAttributes.Controls.Add(this.picAttributes);
            this.tabAttributes.Location = new System.Drawing.Point(4, 22);
            this.tabAttributes.Name = "tabAttributes";
            this.tabAttributes.Padding = new System.Windows.Forms.Padding(4);
            this.tabAttributes.Size = new System.Drawing.Size(209, 453);
            this.tabAttributes.TabIndex = 1;
            this.tabAttributes.Text = "Attributes";
            this.tabAttributes.UseVisualStyleBackColor = true;
            // 
            // picAttributes
            // 
            this.picAttributes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAttributes.Location = new System.Drawing.Point(4, 4);
            this.picAttributes.Name = "picAttributes";
            this.picAttributes.Size = new System.Drawing.Size(48, 56);
            this.picAttributes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picAttributes.TabIndex = 0;
            this.picAttributes.TabStop = false;
            this.picAttributes.Visible = false;
            this.picAttributes.Paint += new System.Windows.Forms.PaintEventHandler(this.picAttributes_Paint);
            this.picAttributes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picAttributes_MouseHandle);
            this.picAttributes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picAttributes_MouseHandle);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.pnlEventProps);
            this.tabEvents.Controls.Add(this.pnlEvents);
            this.tabEvents.Location = new System.Drawing.Point(4, 22);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Padding = new System.Windows.Forms.Padding(4);
            this.tabEvents.Size = new System.Drawing.Size(209, 453);
            this.tabEvents.TabIndex = 2;
            this.tabEvents.Text = "Events";
            this.tabEvents.UseVisualStyleBackColor = true;
            // 
            // pnlEventProps
            // 
            this.pnlEventProps.Controls.Add(this.propEvents);
            this.pnlEventProps.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEventProps.Location = new System.Drawing.Point(4, 88);
            this.pnlEventProps.Name = "pnlEventProps";
            this.pnlEventProps.Size = new System.Drawing.Size(201, 361);
            this.pnlEventProps.TabIndex = 1;
            this.pnlEventProps.Visible = false;
            // 
            // propEvents
            // 
            this.propEvents.BackColor = System.Drawing.SystemColors.Window;
            this.propEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propEvents.Location = new System.Drawing.Point(0, 0);
            this.propEvents.Name = "propEvents";
            this.propEvents.Size = new System.Drawing.Size(201, 361);
            this.propEvents.TabIndex = 0;
            // 
            // pnlEvents
            // 
            this.pnlEvents.Controls.Add(this.cmdDelete);
            this.pnlEvents.Controls.Add(this.lblEventIndex);
            this.pnlEvents.Controls.Add(this.numEvents);
            this.pnlEvents.Controls.Add(this.cmbEvents);
            this.pnlEvents.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEvents.Location = new System.Drawing.Point(4, 4);
            this.pnlEvents.Name = "pnlEvents";
            this.pnlEvents.Size = new System.Drawing.Size(201, 84);
            this.pnlEvents.TabIndex = 0;
            this.pnlEvents.Visible = false;
            // 
            // cmdDelete
            // 
            this.cmdDelete.Location = new System.Drawing.Point(8, 56);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(136, 24);
            this.cmdDelete.TabIndex = 6;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            // 
            // lblEventIndex
            // 
            this.lblEventIndex.AutoSize = true;
            this.lblEventIndex.Location = new System.Drawing.Point(8, 35);
            this.lblEventIndex.Name = "lblEventIndex";
            this.lblEventIndex.Size = new System.Drawing.Size(75, 13);
            this.lblEventIndex.TabIndex = 5;
            this.lblEventIndex.Text = "Event Number";
            // 
            // numEvents
            // 
            this.numEvents.Location = new System.Drawing.Point(104, 32);
            this.numEvents.Name = "numEvents";
            this.numEvents.Size = new System.Drawing.Size(40, 21);
            this.numEvents.TabIndex = 4;
            // 
            // cmbEvents
            // 
            this.cmbEvents.FormattingEnabled = true;
            this.cmbEvents.Items.AddRange(new object[] {
            "Person",
            "Warp",
            "Script",
            "Signpost",
            "Landing Spot"});
            this.cmbEvents.Location = new System.Drawing.Point(8, 8);
            this.cmbEvents.Name = "cmbEvents";
            this.cmbEvents.Size = new System.Drawing.Size(136, 21);
            this.cmbEvents.TabIndex = 3;
            this.cmbEvents.SelectedIndexChanged += new System.EventHandler(this.cmbEvents_SelectedIndexChanged);
            // 
            // pnlCanvas
            // 
            this.pnlCanvas.Controls.Add(this.tabCanvas);
            this.pnlCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCanvas.Location = new System.Drawing.Point(184, 49);
            this.pnlCanvas.Name = "pnlCanvas";
            this.pnlCanvas.Size = new System.Drawing.Size(536, 479);
            this.pnlCanvas.TabIndex = 5;
            // 
            // tabCanvas
            // 
            this.tabCanvas.Controls.Add(this.tabMap);
            this.tabCanvas.Controls.Add(this.tabProperties);
            this.tabCanvas.Controls.Add(this.tabHeader);
            this.tabCanvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCanvas.Location = new System.Drawing.Point(0, 0);
            this.tabCanvas.Name = "tabCanvas";
            this.tabCanvas.SelectedIndex = 0;
            this.tabCanvas.Size = new System.Drawing.Size(536, 479);
            this.tabCanvas.TabIndex = 0;
            // 
            // tabMap
            // 
            this.tabMap.Controls.Add(this.pnlMap);
            this.tabMap.Location = new System.Drawing.Point(4, 22);
            this.tabMap.Name = "tabMap";
            this.tabMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMap.Size = new System.Drawing.Size(528, 453);
            this.tabMap.TabIndex = 0;
            this.tabMap.Text = "Map";
            this.tabMap.UseVisualStyleBackColor = true;
            // 
            // pnlMap
            // 
            this.pnlMap.AutoScroll = true;
            this.pnlMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMap.Controls.Add(this.picMap);
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(3, 3);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.pnlMap.Size = new System.Drawing.Size(522, 447);
            this.pnlMap.TabIndex = 0;
            this.pnlMap.Visible = false;
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(0, 0);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(336, 256);
            this.picMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picMap.TabIndex = 0;
            this.picMap.TabStop = false;
            this.picMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseDown);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseMove);
            // 
            // tabProperties
            // 
            this.tabProperties.Controls.Add(this.pnlProperties);
            this.tabProperties.Location = new System.Drawing.Point(4, 22);
            this.tabProperties.Name = "tabProperties";
            this.tabProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabProperties.Size = new System.Drawing.Size(512, 453);
            this.tabProperties.TabIndex = 1;
            this.tabProperties.Text = "Properties";
            this.tabProperties.UseVisualStyleBackColor = true;
            // 
            // pnlProperties
            // 
            this.pnlProperties.Controls.Add(this.picBorder);
            this.pnlProperties.Controls.Add(this.cmdChangeName);
            this.pnlProperties.Controls.Add(this.numFloorLevel);
            this.pnlProperties.Controls.Add(this.lblFloorLevel);
            this.pnlProperties.Controls.Add(this.cmbShowName);
            this.pnlProperties.Controls.Add(this.lblShowName);
            this.pnlProperties.Controls.Add(this.lblBorder);
            this.pnlProperties.Controls.Add(this.fraDimension);
            this.pnlProperties.Controls.Add(this.fraTilesets);
            this.pnlProperties.Controls.Add(this.fraMapScripts);
            this.pnlProperties.Controls.Add(this.fraMapOptions);
            this.pnlProperties.Controls.Add(this.txtMapName);
            this.pnlProperties.Controls.Add(this.cmbMapNames);
            this.pnlProperties.Controls.Add(this.lblMapName);
            this.pnlProperties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlProperties.Location = new System.Drawing.Point(3, 3);
            this.pnlProperties.Name = "pnlProperties";
            this.pnlProperties.Size = new System.Drawing.Size(506, 447);
            this.pnlProperties.TabIndex = 0;
            this.pnlProperties.Visible = false;
            // 
            // picBorder
            // 
            this.picBorder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBorder.Location = new System.Drawing.Point(304, 336);
            this.picBorder.Name = "picBorder";
            this.picBorder.Size = new System.Drawing.Size(32, 32);
            this.picBorder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBorder.TabIndex = 7;
            this.picBorder.TabStop = false;
            this.picBorder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBorder_MouseHandle);
            this.picBorder.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBorder_MouseHandle);
            // 
            // cmdChangeName
            // 
            this.cmdChangeName.Location = new System.Drawing.Point(368, 72);
            this.cmdChangeName.Name = "cmdChangeName";
            this.cmdChangeName.Size = new System.Drawing.Size(120, 24);
            this.cmdChangeName.TabIndex = 13;
            this.cmdChangeName.Text = "Change Name";
            this.cmdChangeName.UseVisualStyleBackColor = true;
            this.cmdChangeName.Click += new System.EventHandler(this.cmdChangeName_Click);
            // 
            // numFloorLevel
            // 
            this.numFloorLevel.Location = new System.Drawing.Point(368, 40);
            this.numFloorLevel.Maximum = new decimal(new int[] {
            127,
            0,
            0,
            0});
            this.numFloorLevel.Minimum = new decimal(new int[] {
            128,
            0,
            0,
            -2147483648});
            this.numFloorLevel.Name = "numFloorLevel";
            this.numFloorLevel.Size = new System.Drawing.Size(48, 21);
            this.numFloorLevel.TabIndex = 12;
            // 
            // lblFloorLevel
            // 
            this.lblFloorLevel.AutoSize = true;
            this.lblFloorLevel.Location = new System.Drawing.Point(368, 24);
            this.lblFloorLevel.Name = "lblFloorLevel";
            this.lblFloorLevel.Size = new System.Drawing.Size(59, 13);
            this.lblFloorLevel.TabIndex = 11;
            this.lblFloorLevel.Text = "Floor Level";
            // 
            // cmbShowName
            // 
            this.cmbShowName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbShowName.FormattingEnabled = true;
            this.cmbShowName.Items.AddRange(new object[] {
            "00 - Do not show",
            "01 - All (RS only)",
            "02 - ???",
            "03 - ???",
            "04 - ???",
            "05 - ???",
            "06 - All (FRLG only)",
            "07 - ???",
            "08 - ???",
            "09 - ???",
            "0A - ???",
            "0B - ???",
            "0C - Secret Base (EM only)",
            "0D - All (EM only)",
            "0E - ???",
            "0F - ???"});
            this.cmbShowName.Location = new System.Drawing.Point(208, 40);
            this.cmbShowName.Name = "cmbShowName";
            this.cmbShowName.Size = new System.Drawing.Size(128, 21);
            this.cmbShowName.TabIndex = 10;
            // 
            // lblShowName
            // 
            this.lblShowName.AutoSize = true;
            this.lblShowName.Location = new System.Drawing.Point(208, 24);
            this.lblShowName.Name = "lblShowName";
            this.lblShowName.Size = new System.Drawing.Size(63, 13);
            this.lblShowName.TabIndex = 9;
            this.lblShowName.Text = "Show Name";
            // 
            // lblBorder
            // 
            this.lblBorder.AutoSize = true;
            this.lblBorder.Location = new System.Drawing.Point(304, 320);
            this.lblBorder.Name = "lblBorder";
            this.lblBorder.Size = new System.Drawing.Size(39, 13);
            this.lblBorder.TabIndex = 8;
            this.lblBorder.Text = "Border";
            // 
            // fraDimension
            // 
            this.fraDimension.Controls.Add(this.cmdResize);
            this.fraDimension.Controls.Add(this.lblHeight);
            this.fraDimension.Controls.Add(this.txtHeight);
            this.fraDimension.Controls.Add(this.lblWidth);
            this.fraDimension.Controls.Add(this.txtWidth);
            this.fraDimension.Location = new System.Drawing.Point(152, 320);
            this.fraDimension.Name = "fraDimension";
            this.fraDimension.Size = new System.Drawing.Size(136, 112);
            this.fraDimension.TabIndex = 6;
            this.fraDimension.TabStop = false;
            this.fraDimension.Text = "Dimension";
            // 
            // cmdResize
            // 
            this.cmdResize.Location = new System.Drawing.Point(16, 72);
            this.cmdResize.Name = "cmdResize";
            this.cmdResize.Size = new System.Drawing.Size(104, 24);
            this.cmdResize.TabIndex = 4;
            this.cmdResize.Text = "Resize";
            this.cmdResize.UseVisualStyleBackColor = true;
            this.cmdResize.Click += new System.EventHandler(this.cmdResize_Click);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(16, 50);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(38, 13);
            this.lblHeight.TabIndex = 3;
            this.lblHeight.Text = "Height";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(64, 48);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(56, 21);
            this.txtHeight.TabIndex = 2;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(16, 26);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(35, 13);
            this.lblWidth.TabIndex = 1;
            this.lblWidth.Text = "Width";
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(64, 24);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(56, 21);
            this.txtWidth.TabIndex = 0;
            // 
            // fraTilesets
            // 
            this.fraTilesets.Controls.Add(this.cmdChange);
            this.fraTilesets.Controls.Add(this.lblMinor);
            this.fraTilesets.Controls.Add(this.txtMinor);
            this.fraTilesets.Controls.Add(this.txtMajor);
            this.fraTilesets.Controls.Add(this.lblMajor);
            this.fraTilesets.Location = new System.Drawing.Point(8, 320);
            this.fraTilesets.Name = "fraTilesets";
            this.fraTilesets.Size = new System.Drawing.Size(136, 112);
            this.fraTilesets.TabIndex = 5;
            this.fraTilesets.TabStop = false;
            this.fraTilesets.Text = "Tilesets";
            // 
            // cmdChange
            // 
            this.cmdChange.Location = new System.Drawing.Point(16, 72);
            this.cmdChange.Name = "cmdChange";
            this.cmdChange.Size = new System.Drawing.Size(104, 24);
            this.cmdChange.TabIndex = 4;
            this.cmdChange.Text = "Change";
            this.cmdChange.UseVisualStyleBackColor = true;
            this.cmdChange.Click += new System.EventHandler(this.cmdChange_Click);
            // 
            // lblMinor
            // 
            this.lblMinor.AutoSize = true;
            this.lblMinor.Location = new System.Drawing.Point(8, 50);
            this.lblMinor.Name = "lblMinor";
            this.lblMinor.Size = new System.Drawing.Size(33, 13);
            this.lblMinor.TabIndex = 3;
            this.lblMinor.Text = "Minor";
            // 
            // txtMinor
            // 
            this.txtMinor.Location = new System.Drawing.Point(56, 48);
            this.txtMinor.Name = "txtMinor";
            this.txtMinor.Size = new System.Drawing.Size(64, 21);
            this.txtMinor.TabIndex = 2;
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(56, 24);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(64, 21);
            this.txtMajor.TabIndex = 1;
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(8, 26);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(34, 13);
            this.lblMajor.TabIndex = 0;
            this.lblMajor.Text = "Major";
            // 
            // fraMapScripts
            // 
            this.fraMapScripts.Location = new System.Drawing.Point(8, 224);
            this.fraMapScripts.Name = "fraMapScripts";
            this.fraMapScripts.Size = new System.Drawing.Size(480, 88);
            this.fraMapScripts.TabIndex = 4;
            this.fraMapScripts.TabStop = false;
            this.fraMapScripts.Text = "Map Scripts";
            // 
            // fraMapOptions
            // 
            this.fraMapOptions.Controls.Add(this.cmbSong);
            this.fraMapOptions.Controls.Add(this.cmbBattleStyle);
            this.fraMapOptions.Controls.Add(this.lblBattleStyle);
            this.fraMapOptions.Controls.Add(this.cmbType);
            this.fraMapOptions.Controls.Add(this.lblType);
            this.fraMapOptions.Controls.Add(this.cmbCaveBehaviour);
            this.fraMapOptions.Controls.Add(this.lblCaveBehaviour);
            this.fraMapOptions.Controls.Add(this.cmbWeather);
            this.fraMapOptions.Controls.Add(this.lblWeather);
            this.fraMapOptions.Controls.Add(this.txtSong);
            this.fraMapOptions.Controls.Add(this.lblSong);
            this.fraMapOptions.Location = new System.Drawing.Point(8, 96);
            this.fraMapOptions.Name = "fraMapOptions";
            this.fraMapOptions.Size = new System.Drawing.Size(480, 120);
            this.fraMapOptions.TabIndex = 3;
            this.fraMapOptions.TabStop = false;
            this.fraMapOptions.Text = "Map Options";
            // 
            // cmbSong
            // 
            this.cmbSong.FormattingEnabled = true;
            this.cmbSong.Location = new System.Drawing.Point(72, 32);
            this.cmbSong.Name = "cmbSong";
            this.cmbSong.Size = new System.Drawing.Size(248, 21);
            this.cmbSong.TabIndex = 12;
            this.cmbSong.SelectedIndexChanged += new System.EventHandler(this.cmbSong_SelectedIndexChanged);
            // 
            // cmbBattleStyle
            // 
            this.cmbBattleStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBattleStyle.FormattingEnabled = true;
            this.cmbBattleStyle.Items.AddRange(new object[] {
            "00 - Random",
            "01 - Gym",
            "02 - Evil Team",
            "03 - ???",
            "04 - Elite 4 I",
            "05 - Elite 4 II",
            "06 - Elite 4 III",
            "07 - Elite 4 IV",
            "08 - Big Red PokeBall"});
            this.cmbBattleStyle.Location = new System.Drawing.Point(352, 80);
            this.cmbBattleStyle.Name = "cmbBattleStyle";
            this.cmbBattleStyle.Size = new System.Drawing.Size(112, 21);
            this.cmbBattleStyle.TabIndex = 9;
            // 
            // lblBattleStyle
            // 
            this.lblBattleStyle.AutoSize = true;
            this.lblBattleStyle.Location = new System.Drawing.Point(352, 64);
            this.lblBattleStyle.Name = "lblBattleStyle";
            this.lblBattleStyle.Size = new System.Drawing.Size(62, 13);
            this.lblBattleStyle.TabIndex = 8;
            this.lblBattleStyle.Text = "Battle Style";
            // 
            // cmbType
            // 
            this.cmbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "00 - None",
            "01 - Town",
            "02 - City",
            "03 - Route",
            "04 - Cave",
            "05 - Underwater",
            "06 - ???",
            "07 - ???",
            "08 - Indoor",
            "09 - Secret Base",
            "0A - ???",
            "0B - ???",
            "0C - ???",
            "0D - ???",
            "0E - ???",
            "0F - ???"});
            this.cmbType.Location = new System.Drawing.Point(192, 80);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(104, 21);
            this.cmbType.TabIndex = 7;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(192, 64);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type";
            // 
            // cmbCaveBehaviour
            // 
            this.cmbCaveBehaviour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCaveBehaviour.FormattingEnabled = true;
            this.cmbCaveBehaviour.Items.AddRange(new object[] {
            "00 - Normal",
            "01 - Flash Allowed",
            "02 - Flash Disallowed",
            "03 - ???",
            "04 - ???",
            "05 - ???",
            "06 - ???",
            "07 - ???",
            "08 - ???",
            "09 - ???",
            "0A - ???",
            "0B - ???",
            "0C - ???",
            "0D - ???",
            "0E - ???",
            "0F - ???"});
            this.cmbCaveBehaviour.Location = new System.Drawing.Point(16, 80);
            this.cmbCaveBehaviour.Name = "cmbCaveBehaviour";
            this.cmbCaveBehaviour.Size = new System.Drawing.Size(120, 21);
            this.cmbCaveBehaviour.TabIndex = 5;
            // 
            // lblCaveBehaviour
            // 
            this.lblCaveBehaviour.AutoSize = true;
            this.lblCaveBehaviour.Location = new System.Drawing.Point(16, 64);
            this.lblCaveBehaviour.Name = "lblCaveBehaviour";
            this.lblCaveBehaviour.Size = new System.Drawing.Size(83, 13);
            this.lblCaveBehaviour.TabIndex = 4;
            this.lblCaveBehaviour.Text = "Cave Behaviour";
            // 
            // cmbWeather
            // 
            this.cmbWeather.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWeather.FormattingEnabled = true;
            this.cmbWeather.Items.AddRange(new object[] {
            "00 - None",
            "01 - Reflected Clouds",
            "02 - Normal",
            "03 - Rain",
            "04 - Snowflakes",
            "05 - Thunderstorm I",
            "06 - Fog",
            "07 - Snow",
            "08 - Sandstorm",
            "09 - Fog (Diagonal)",
            "0A - Fog (Thin)",
            "0B - Darkness",
            "0C - Overheat",
            "0D - Thunderstorm II",
            "0E - Underwater",
            "0F - None "});
            this.cmbWeather.Location = new System.Drawing.Point(352, 32);
            this.cmbWeather.Name = "cmbWeather";
            this.cmbWeather.Size = new System.Drawing.Size(112, 21);
            this.cmbWeather.TabIndex = 3;
            // 
            // lblWeather
            // 
            this.lblWeather.AutoSize = true;
            this.lblWeather.Location = new System.Drawing.Point(352, 16);
            this.lblWeather.Name = "lblWeather";
            this.lblWeather.Size = new System.Drawing.Size(49, 13);
            this.lblWeather.TabIndex = 2;
            this.lblWeather.Text = "Weather";
            // 
            // txtSong
            // 
            this.txtSong.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSong.Location = new System.Drawing.Point(16, 32);
            this.txtSong.MaxLength = 3;
            this.txtSong.Name = "txtSong";
            this.txtSong.Size = new System.Drawing.Size(48, 21);
            this.txtSong.TabIndex = 1;
            this.txtSong.TextChanged += new System.EventHandler(this.txtSong_TextChanged);
            // 
            // lblSong
            // 
            this.lblSong.AutoSize = true;
            this.lblSong.Location = new System.Drawing.Point(16, 16);
            this.lblSong.Name = "lblSong";
            this.lblSong.Size = new System.Drawing.Size(31, 13);
            this.lblSong.TabIndex = 0;
            this.lblSong.Text = "Song";
            // 
            // txtMapName
            // 
            this.txtMapName.Location = new System.Drawing.Point(64, 40);
            this.txtMapName.MaxLength = 18;
            this.txtMapName.Name = "txtMapName";
            this.txtMapName.Size = new System.Drawing.Size(120, 21);
            this.txtMapName.TabIndex = 2;
            // 
            // cmbMapNames
            // 
            this.cmbMapNames.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbMapNames.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbMapNames.FormattingEnabled = true;
            this.cmbMapNames.Location = new System.Drawing.Point(64, 16);
            this.cmbMapNames.Name = "cmbMapNames";
            this.cmbMapNames.Size = new System.Drawing.Size(120, 21);
            this.cmbMapNames.TabIndex = 1;
            this.cmbMapNames.SelectedIndexChanged += new System.EventHandler(this.cmbMapNames_SelectedIndexChanged);
            // 
            // lblMapName
            // 
            this.lblMapName.AutoSize = true;
            this.lblMapName.Location = new System.Drawing.Point(24, 18);
            this.lblMapName.Name = "lblMapName";
            this.lblMapName.Size = new System.Drawing.Size(34, 13);
            this.lblMapName.TabIndex = 0;
            this.lblMapName.Text = "Name";
            // 
            // tabHeader
            // 
            this.tabHeader.Controls.Add(this.pnlHeader);
            this.tabHeader.Location = new System.Drawing.Point(4, 22);
            this.tabHeader.Name = "tabHeader";
            this.tabHeader.Size = new System.Drawing.Size(512, 453);
            this.tabHeader.TabIndex = 2;
            this.tabHeader.Text = "Header";
            this.tabHeader.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.cmdHeader);
            this.pnlHeader.Controls.Add(this.cmdSaveMinor);
            this.pnlHeader.Controls.Add(this.cmdSaveMajor);
            this.pnlHeader.Controls.Add(this.fraBorder);
            this.pnlHeader.Controls.Add(this.fraMinorTileset);
            this.pnlHeader.Controls.Add(this.fraMajorTileset);
            this.pnlHeader.Controls.Add(this.groupBox1);
            this.pnlHeader.Controls.Add(this.fraMapHeader);
            this.pnlHeader.Controls.Add(this.lblMapHeader);
            this.pnlHeader.Controls.Add(this.txtMapHeader);
            this.pnlHeader.Controls.Add(this.txtBank);
            this.pnlHeader.Controls.Add(this.lblBank);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(512, 453);
            this.pnlHeader.TabIndex = 0;
            this.pnlHeader.Visible = false;
            // 
            // cmdHeader
            // 
            this.cmdHeader.Location = new System.Drawing.Point(376, 424);
            this.cmdHeader.Name = "cmdHeader";
            this.cmdHeader.Size = new System.Drawing.Size(112, 24);
            this.cmdHeader.TabIndex = 11;
            this.cmdHeader.Text = "Save Header";
            this.cmdHeader.UseVisualStyleBackColor = true;
            this.cmdHeader.Click += new System.EventHandler(this.cmdHeader_Click);
            // 
            // cmdSaveMinor
            // 
            this.cmdSaveMinor.Location = new System.Drawing.Point(376, 400);
            this.cmdSaveMinor.Name = "cmdSaveMinor";
            this.cmdSaveMinor.Size = new System.Drawing.Size(112, 24);
            this.cmdSaveMinor.TabIndex = 10;
            this.cmdSaveMinor.Tag = "2";
            this.cmdSaveMinor.Text = "Save Minor Tileset";
            this.cmdSaveMinor.UseVisualStyleBackColor = true;
            this.cmdSaveMinor.Click += new System.EventHandler(this.SaveTileset_Click);
            // 
            // cmdSaveMajor
            // 
            this.cmdSaveMajor.Location = new System.Drawing.Point(376, 376);
            this.cmdSaveMajor.Name = "cmdSaveMajor";
            this.cmdSaveMajor.Size = new System.Drawing.Size(112, 24);
            this.cmdSaveMajor.TabIndex = 9;
            this.cmdSaveMajor.Tag = "";
            this.cmdSaveMajor.Text = "Save Major Tileset";
            this.cmdSaveMajor.UseVisualStyleBackColor = true;
            this.cmdSaveMajor.Click += new System.EventHandler(this.SaveTileset_Click);
            // 
            // fraBorder
            // 
            this.fraBorder.Controls.Add(this.cmdResizeBorder);
            this.fraBorder.Controls.Add(this.lblBorderHeight);
            this.fraBorder.Controls.Add(this.txtBorderHeight);
            this.fraBorder.Controls.Add(this.txtBorderWidth);
            this.fraBorder.Controls.Add(this.lblBorderWidth);
            this.fraBorder.Location = new System.Drawing.Point(344, 256);
            this.fraBorder.Name = "fraBorder";
            this.fraBorder.Size = new System.Drawing.Size(128, 112);
            this.fraBorder.TabIndex = 8;
            this.fraBorder.TabStop = false;
            this.fraBorder.Text = "Border";
            // 
            // cmdResizeBorder
            // 
            this.cmdResizeBorder.Location = new System.Drawing.Point(16, 72);
            this.cmdResizeBorder.Name = "cmdResizeBorder";
            this.cmdResizeBorder.Size = new System.Drawing.Size(96, 24);
            this.cmdResizeBorder.TabIndex = 4;
            this.cmdResizeBorder.Text = "Resize";
            this.cmdResizeBorder.UseVisualStyleBackColor = true;
            this.cmdResizeBorder.Click += new System.EventHandler(this.cmdResizeBorder_Click);
            // 
            // lblBorderHeight
            // 
            this.lblBorderHeight.AutoSize = true;
            this.lblBorderHeight.Location = new System.Drawing.Point(16, 50);
            this.lblBorderHeight.Name = "lblBorderHeight";
            this.lblBorderHeight.Size = new System.Drawing.Size(38, 13);
            this.lblBorderHeight.TabIndex = 3;
            this.lblBorderHeight.Text = "Height";
            // 
            // txtBorderHeight
            // 
            this.txtBorderHeight.Location = new System.Drawing.Point(80, 48);
            this.txtBorderHeight.Name = "txtBorderHeight";
            this.txtBorderHeight.Size = new System.Drawing.Size(32, 21);
            this.txtBorderHeight.TabIndex = 2;
            // 
            // txtBorderWidth
            // 
            this.txtBorderWidth.Location = new System.Drawing.Point(80, 24);
            this.txtBorderWidth.Name = "txtBorderWidth";
            this.txtBorderWidth.Size = new System.Drawing.Size(32, 21);
            this.txtBorderWidth.TabIndex = 1;
            // 
            // lblBorderWidth
            // 
            this.lblBorderWidth.AutoSize = true;
            this.lblBorderWidth.Location = new System.Drawing.Point(16, 26);
            this.lblBorderWidth.Name = "lblBorderWidth";
            this.lblBorderWidth.Size = new System.Drawing.Size(35, 13);
            this.lblBorderWidth.TabIndex = 0;
            this.lblBorderWidth.Text = "Width";
            // 
            // fraMinorTileset
            // 
            this.fraMinorTileset.Controls.Add(this.lblAnimation2);
            this.fraMinorTileset.Controls.Add(this.lblBehaviours2);
            this.fraMinorTileset.Controls.Add(this.lblBlocks2);
            this.fraMinorTileset.Controls.Add(this.lblPalette2);
            this.fraMinorTileset.Controls.Add(this.txtAnimation2);
            this.fraMinorTileset.Controls.Add(this.txtBehaviours2);
            this.fraMinorTileset.Controls.Add(this.txtBlocks2);
            this.fraMinorTileset.Controls.Add(this.txtPalette2);
            this.fraMinorTileset.Controls.Add(this.txtImage2);
            this.fraMinorTileset.Controls.Add(this.lblImage2);
            this.fraMinorTileset.Controls.Add(this.chkMajorTileset2);
            this.fraMinorTileset.Controls.Add(this.chkLZ772);
            this.fraMinorTileset.Location = new System.Drawing.Point(176, 256);
            this.fraMinorTileset.Name = "fraMinorTileset";
            this.fraMinorTileset.Size = new System.Drawing.Size(152, 192);
            this.fraMinorTileset.TabIndex = 7;
            this.fraMinorTileset.TabStop = false;
            this.fraMinorTileset.Text = "Major Tileset";
            // 
            // lblAnimation2
            // 
            this.lblAnimation2.AutoSize = true;
            this.lblAnimation2.Location = new System.Drawing.Point(16, 162);
            this.lblAnimation2.Name = "lblAnimation2";
            this.lblAnimation2.Size = new System.Drawing.Size(54, 13);
            this.lblAnimation2.TabIndex = 11;
            this.lblAnimation2.Text = "Animation";
            // 
            // lblBehaviours2
            // 
            this.lblBehaviours2.AutoSize = true;
            this.lblBehaviours2.Location = new System.Drawing.Point(16, 138);
            this.lblBehaviours2.Name = "lblBehaviours2";
            this.lblBehaviours2.Size = new System.Drawing.Size(60, 13);
            this.lblBehaviours2.TabIndex = 10;
            this.lblBehaviours2.Text = "Behaviours";
            // 
            // lblBlocks2
            // 
            this.lblBlocks2.AutoSize = true;
            this.lblBlocks2.Location = new System.Drawing.Point(16, 114);
            this.lblBlocks2.Name = "lblBlocks2";
            this.lblBlocks2.Size = new System.Drawing.Size(36, 13);
            this.lblBlocks2.TabIndex = 9;
            this.lblBlocks2.Text = "Blocks";
            // 
            // lblPalette2
            // 
            this.lblPalette2.AutoSize = true;
            this.lblPalette2.Location = new System.Drawing.Point(16, 90);
            this.lblPalette2.Name = "lblPalette2";
            this.lblPalette2.Size = new System.Drawing.Size(41, 13);
            this.lblPalette2.TabIndex = 8;
            this.lblPalette2.Text = "Palette";
            // 
            // txtAnimation2
            // 
            this.txtAnimation2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnimation2.Location = new System.Drawing.Point(80, 160);
            this.txtAnimation2.MaxLength = 7;
            this.txtAnimation2.Name = "txtAnimation2";
            this.txtAnimation2.Size = new System.Drawing.Size(64, 21);
            this.txtAnimation2.TabIndex = 7;
            // 
            // txtBehaviours2
            // 
            this.txtBehaviours2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBehaviours2.Location = new System.Drawing.Point(80, 136);
            this.txtBehaviours2.MaxLength = 7;
            this.txtBehaviours2.Name = "txtBehaviours2";
            this.txtBehaviours2.Size = new System.Drawing.Size(64, 21);
            this.txtBehaviours2.TabIndex = 6;
            // 
            // txtBlocks2
            // 
            this.txtBlocks2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBlocks2.Location = new System.Drawing.Point(80, 112);
            this.txtBlocks2.MaxLength = 7;
            this.txtBlocks2.Name = "txtBlocks2";
            this.txtBlocks2.Size = new System.Drawing.Size(64, 21);
            this.txtBlocks2.TabIndex = 5;
            // 
            // txtPalette2
            // 
            this.txtPalette2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPalette2.Location = new System.Drawing.Point(80, 88);
            this.txtPalette2.MaxLength = 7;
            this.txtPalette2.Name = "txtPalette2";
            this.txtPalette2.Size = new System.Drawing.Size(64, 21);
            this.txtPalette2.TabIndex = 4;
            // 
            // txtImage2
            // 
            this.txtImage2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImage2.Location = new System.Drawing.Point(80, 64);
            this.txtImage2.MaxLength = 7;
            this.txtImage2.Name = "txtImage2";
            this.txtImage2.Size = new System.Drawing.Size(64, 21);
            this.txtImage2.TabIndex = 3;
            // 
            // lblImage2
            // 
            this.lblImage2.AutoSize = true;
            this.lblImage2.Location = new System.Drawing.Point(16, 66);
            this.lblImage2.Name = "lblImage2";
            this.lblImage2.Size = new System.Drawing.Size(37, 13);
            this.lblImage2.TabIndex = 2;
            this.lblImage2.Text = "Image";
            // 
            // chkMajorTileset2
            // 
            this.chkMajorTileset2.AutoSize = true;
            this.chkMajorTileset2.Location = new System.Drawing.Point(16, 40);
            this.chkMajorTileset2.Name = "chkMajorTileset2";
            this.chkMajorTileset2.Size = new System.Drawing.Size(87, 17);
            this.chkMajorTileset2.TabIndex = 1;
            this.chkMajorTileset2.Text = "Major Tileset";
            this.chkMajorTileset2.UseVisualStyleBackColor = true;
            // 
            // chkLZ772
            // 
            this.chkLZ772.AutoSize = true;
            this.chkLZ772.Location = new System.Drawing.Point(16, 24);
            this.chkLZ772.Name = "chkLZ772";
            this.chkLZ772.Size = new System.Drawing.Size(111, 17);
            this.chkLZ772.TabIndex = 0;
            this.chkLZ772.Text = "LZ77 Compressed";
            this.chkLZ772.UseVisualStyleBackColor = true;
            // 
            // fraMajorTileset
            // 
            this.fraMajorTileset.Controls.Add(this.lblAnimation1);
            this.fraMajorTileset.Controls.Add(this.lblBehaviours1);
            this.fraMajorTileset.Controls.Add(this.lblBlocks1);
            this.fraMajorTileset.Controls.Add(this.lblPalette1);
            this.fraMajorTileset.Controls.Add(this.txtAnimation1);
            this.fraMajorTileset.Controls.Add(this.txtBehaviours1);
            this.fraMajorTileset.Controls.Add(this.txtBlocks1);
            this.fraMajorTileset.Controls.Add(this.txtPalette1);
            this.fraMajorTileset.Controls.Add(this.txtImage1);
            this.fraMajorTileset.Controls.Add(this.lblImage1);
            this.fraMajorTileset.Controls.Add(this.chkMajorTileset1);
            this.fraMajorTileset.Controls.Add(this.chkLZ771);
            this.fraMajorTileset.Location = new System.Drawing.Point(16, 256);
            this.fraMajorTileset.Name = "fraMajorTileset";
            this.fraMajorTileset.Size = new System.Drawing.Size(152, 192);
            this.fraMajorTileset.TabIndex = 6;
            this.fraMajorTileset.TabStop = false;
            this.fraMajorTileset.Text = "Major Tileset";
            // 
            // lblAnimation1
            // 
            this.lblAnimation1.AutoSize = true;
            this.lblAnimation1.Location = new System.Drawing.Point(16, 162);
            this.lblAnimation1.Name = "lblAnimation1";
            this.lblAnimation1.Size = new System.Drawing.Size(54, 13);
            this.lblAnimation1.TabIndex = 11;
            this.lblAnimation1.Text = "Animation";
            // 
            // lblBehaviours1
            // 
            this.lblBehaviours1.AutoSize = true;
            this.lblBehaviours1.Location = new System.Drawing.Point(16, 138);
            this.lblBehaviours1.Name = "lblBehaviours1";
            this.lblBehaviours1.Size = new System.Drawing.Size(60, 13);
            this.lblBehaviours1.TabIndex = 10;
            this.lblBehaviours1.Text = "Behaviours";
            // 
            // lblBlocks1
            // 
            this.lblBlocks1.AutoSize = true;
            this.lblBlocks1.Location = new System.Drawing.Point(16, 114);
            this.lblBlocks1.Name = "lblBlocks1";
            this.lblBlocks1.Size = new System.Drawing.Size(36, 13);
            this.lblBlocks1.TabIndex = 9;
            this.lblBlocks1.Text = "Blocks";
            // 
            // lblPalette1
            // 
            this.lblPalette1.AutoSize = true;
            this.lblPalette1.Location = new System.Drawing.Point(16, 90);
            this.lblPalette1.Name = "lblPalette1";
            this.lblPalette1.Size = new System.Drawing.Size(41, 13);
            this.lblPalette1.TabIndex = 8;
            this.lblPalette1.Text = "Palette";
            // 
            // txtAnimation1
            // 
            this.txtAnimation1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAnimation1.Location = new System.Drawing.Point(80, 160);
            this.txtAnimation1.MaxLength = 7;
            this.txtAnimation1.Name = "txtAnimation1";
            this.txtAnimation1.Size = new System.Drawing.Size(64, 21);
            this.txtAnimation1.TabIndex = 7;
            // 
            // txtBehaviours1
            // 
            this.txtBehaviours1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBehaviours1.Location = new System.Drawing.Point(80, 136);
            this.txtBehaviours1.MaxLength = 7;
            this.txtBehaviours1.Name = "txtBehaviours1";
            this.txtBehaviours1.Size = new System.Drawing.Size(64, 21);
            this.txtBehaviours1.TabIndex = 6;
            // 
            // txtBlocks1
            // 
            this.txtBlocks1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBlocks1.Location = new System.Drawing.Point(80, 112);
            this.txtBlocks1.MaxLength = 7;
            this.txtBlocks1.Name = "txtBlocks1";
            this.txtBlocks1.Size = new System.Drawing.Size(64, 21);
            this.txtBlocks1.TabIndex = 5;
            // 
            // txtPalette1
            // 
            this.txtPalette1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPalette1.Location = new System.Drawing.Point(80, 88);
            this.txtPalette1.MaxLength = 7;
            this.txtPalette1.Name = "txtPalette1";
            this.txtPalette1.Size = new System.Drawing.Size(64, 21);
            this.txtPalette1.TabIndex = 4;
            // 
            // txtImage1
            // 
            this.txtImage1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtImage1.Location = new System.Drawing.Point(80, 64);
            this.txtImage1.MaxLength = 7;
            this.txtImage1.Name = "txtImage1";
            this.txtImage1.Size = new System.Drawing.Size(64, 21);
            this.txtImage1.TabIndex = 3;
            // 
            // lblImage1
            // 
            this.lblImage1.AutoSize = true;
            this.lblImage1.Location = new System.Drawing.Point(16, 66);
            this.lblImage1.Name = "lblImage1";
            this.lblImage1.Size = new System.Drawing.Size(37, 13);
            this.lblImage1.TabIndex = 2;
            this.lblImage1.Text = "Image";
            // 
            // chkMajorTileset1
            // 
            this.chkMajorTileset1.AutoSize = true;
            this.chkMajorTileset1.Location = new System.Drawing.Point(16, 40);
            this.chkMajorTileset1.Name = "chkMajorTileset1";
            this.chkMajorTileset1.Size = new System.Drawing.Size(87, 17);
            this.chkMajorTileset1.TabIndex = 1;
            this.chkMajorTileset1.Text = "Major Tileset";
            this.chkMajorTileset1.UseVisualStyleBackColor = true;
            // 
            // chkLZ771
            // 
            this.chkLZ771.AutoSize = true;
            this.chkLZ771.Location = new System.Drawing.Point(16, 24);
            this.chkLZ771.Name = "chkLZ771";
            this.chkLZ771.Size = new System.Drawing.Size(111, 17);
            this.chkLZ771.TabIndex = 0;
            this.chkLZ771.Text = "LZ77 Compressed";
            this.chkLZ771.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMinorTileset);
            this.groupBox1.Controls.Add(this.lblMajorTileset);
            this.groupBox1.Controls.Add(this.lblMapTileData);
            this.groupBox1.Controls.Add(this.lblBorderData);
            this.groupBox1.Controls.Add(this.txtMinorTileset);
            this.groupBox1.Controls.Add(this.txtMajorTileset);
            this.groupBox1.Controls.Add(this.txtMapTileData);
            this.groupBox1.Controls.Add(this.txtBorderData);
            this.groupBox1.Location = new System.Drawing.Point(16, 168);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(472, 80);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map Data";
            // 
            // lblMinorTileset
            // 
            this.lblMinorTileset.AutoSize = true;
            this.lblMinorTileset.Location = new System.Drawing.Point(384, 24);
            this.lblMinorTileset.Name = "lblMinorTileset";
            this.lblMinorTileset.Size = new System.Drawing.Size(67, 13);
            this.lblMinorTileset.TabIndex = 7;
            this.lblMinorTileset.Text = "Minor Tileset";
            // 
            // lblMajorTileset
            // 
            this.lblMajorTileset.AutoSize = true;
            this.lblMajorTileset.Location = new System.Drawing.Point(264, 24);
            this.lblMajorTileset.Name = "lblMajorTileset";
            this.lblMajorTileset.Size = new System.Drawing.Size(68, 13);
            this.lblMajorTileset.TabIndex = 6;
            this.lblMajorTileset.Text = "Major Tileset";
            // 
            // lblMapTileData
            // 
            this.lblMapTileData.AutoSize = true;
            this.lblMapTileData.Location = new System.Drawing.Point(136, 24);
            this.lblMapTileData.Name = "lblMapTileData";
            this.lblMapTileData.Size = new System.Drawing.Size(72, 13);
            this.lblMapTileData.TabIndex = 5;
            this.lblMapTileData.Text = "Map Tile Data";
            // 
            // lblBorderData
            // 
            this.lblBorderData.AutoSize = true;
            this.lblBorderData.Location = new System.Drawing.Point(16, 24);
            this.lblBorderData.Name = "lblBorderData";
            this.lblBorderData.Size = new System.Drawing.Size(65, 13);
            this.lblBorderData.TabIndex = 4;
            this.lblBorderData.Text = "Border Data";
            // 
            // txtMinorTileset
            // 
            this.txtMinorTileset.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMinorTileset.Location = new System.Drawing.Point(384, 40);
            this.txtMinorTileset.MaxLength = 7;
            this.txtMinorTileset.Name = "txtMinorTileset";
            this.txtMinorTileset.Size = new System.Drawing.Size(72, 21);
            this.txtMinorTileset.TabIndex = 3;
            // 
            // txtMajorTileset
            // 
            this.txtMajorTileset.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMajorTileset.Location = new System.Drawing.Point(264, 40);
            this.txtMajorTileset.MaxLength = 7;
            this.txtMajorTileset.Name = "txtMajorTileset";
            this.txtMajorTileset.Size = new System.Drawing.Size(72, 21);
            this.txtMajorTileset.TabIndex = 2;
            // 
            // txtMapTileData
            // 
            this.txtMapTileData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMapTileData.Location = new System.Drawing.Point(136, 40);
            this.txtMapTileData.MaxLength = 7;
            this.txtMapTileData.Name = "txtMapTileData";
            this.txtMapTileData.Size = new System.Drawing.Size(72, 21);
            this.txtMapTileData.TabIndex = 1;
            // 
            // txtBorderData
            // 
            this.txtBorderData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBorderData.Location = new System.Drawing.Point(16, 40);
            this.txtBorderData.MaxLength = 7;
            this.txtBorderData.Name = "txtBorderData";
            this.txtBorderData.Size = new System.Drawing.Size(72, 21);
            this.txtBorderData.TabIndex = 0;
            // 
            // fraMapHeader
            // 
            this.fraMapHeader.Controls.Add(this.lblConnections);
            this.fraMapHeader.Controls.Add(this.lblMapScripts);
            this.fraMapHeader.Controls.Add(this.lblEvents);
            this.fraMapHeader.Controls.Add(this.lblMapData);
            this.fraMapHeader.Controls.Add(this.txtConnections);
            this.fraMapHeader.Controls.Add(this.txtMapScripts);
            this.fraMapHeader.Controls.Add(this.txtEvents);
            this.fraMapHeader.Controls.Add(this.txtMapData);
            this.fraMapHeader.Location = new System.Drawing.Point(16, 80);
            this.fraMapHeader.Name = "fraMapHeader";
            this.fraMapHeader.Size = new System.Drawing.Size(472, 80);
            this.fraMapHeader.TabIndex = 4;
            this.fraMapHeader.TabStop = false;
            this.fraMapHeader.Text = "Map Header";
            // 
            // lblConnections
            // 
            this.lblConnections.AutoSize = true;
            this.lblConnections.Location = new System.Drawing.Point(384, 24);
            this.lblConnections.Name = "lblConnections";
            this.lblConnections.Size = new System.Drawing.Size(66, 13);
            this.lblConnections.TabIndex = 7;
            this.lblConnections.Text = "Connections";
            // 
            // lblMapScripts
            // 
            this.lblMapScripts.AutoSize = true;
            this.lblMapScripts.Location = new System.Drawing.Point(264, 24);
            this.lblMapScripts.Name = "lblMapScripts";
            this.lblMapScripts.Size = new System.Drawing.Size(39, 13);
            this.lblMapScripts.TabIndex = 6;
            this.lblMapScripts.Text = "Scripts";
            // 
            // lblEvents
            // 
            this.lblEvents.AutoSize = true;
            this.lblEvents.Location = new System.Drawing.Point(136, 24);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(40, 13);
            this.lblEvents.TabIndex = 5;
            this.lblEvents.Text = "Events";
            // 
            // lblMapData
            // 
            this.lblMapData.AutoSize = true;
            this.lblMapData.Location = new System.Drawing.Point(16, 24);
            this.lblMapData.Name = "lblMapData";
            this.lblMapData.Size = new System.Drawing.Size(53, 13);
            this.lblMapData.TabIndex = 4;
            this.lblMapData.Text = "Map Data";
            // 
            // txtConnections
            // 
            this.txtConnections.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtConnections.Location = new System.Drawing.Point(384, 40);
            this.txtConnections.MaxLength = 7;
            this.txtConnections.Name = "txtConnections";
            this.txtConnections.Size = new System.Drawing.Size(72, 21);
            this.txtConnections.TabIndex = 3;
            // 
            // txtMapScripts
            // 
            this.txtMapScripts.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMapScripts.Location = new System.Drawing.Point(264, 40);
            this.txtMapScripts.MaxLength = 7;
            this.txtMapScripts.Name = "txtMapScripts";
            this.txtMapScripts.Size = new System.Drawing.Size(72, 21);
            this.txtMapScripts.TabIndex = 2;
            // 
            // txtEvents
            // 
            this.txtEvents.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEvents.Location = new System.Drawing.Point(136, 40);
            this.txtEvents.MaxLength = 7;
            this.txtEvents.Name = "txtEvents";
            this.txtEvents.Size = new System.Drawing.Size(72, 21);
            this.txtEvents.TabIndex = 1;
            // 
            // txtMapData
            // 
            this.txtMapData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMapData.Location = new System.Drawing.Point(16, 40);
            this.txtMapData.MaxLength = 7;
            this.txtMapData.Name = "txtMapData";
            this.txtMapData.Size = new System.Drawing.Size(72, 21);
            this.txtMapData.TabIndex = 0;
            // 
            // lblMapHeader
            // 
            this.lblMapHeader.AutoSize = true;
            this.lblMapHeader.Location = new System.Drawing.Point(16, 40);
            this.lblMapHeader.Name = "lblMapHeader";
            this.lblMapHeader.Size = new System.Drawing.Size(65, 13);
            this.lblMapHeader.TabIndex = 3;
            this.lblMapHeader.Text = "Map Header";
            // 
            // txtMapHeader
            // 
            this.txtMapHeader.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMapHeader.Location = new System.Drawing.Point(120, 38);
            this.txtMapHeader.Name = "txtMapHeader";
            this.txtMapHeader.ReadOnly = true;
            this.txtMapHeader.Size = new System.Drawing.Size(64, 21);
            this.txtMapHeader.TabIndex = 2;
            // 
            // txtBank
            // 
            this.txtBank.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBank.Location = new System.Drawing.Point(120, 14);
            this.txtBank.Name = "txtBank";
            this.txtBank.ReadOnly = true;
            this.txtBank.Size = new System.Drawing.Size(64, 21);
            this.txtBank.TabIndex = 1;
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Location = new System.Drawing.Point(16, 16);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(30, 13);
            this.lblBank.TabIndex = 0;
            this.lblBank.Text = "Bank";
            // 
            // frmMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(885, 552);
            this.Controls.Add(this.pnlCanvas);
            this.Controls.Add(this.pnlEditor);
            this.Controls.Add(this.pnlMapList);
            this.Controls.Add(this.AppStatusBar);
            this.Controls.Add(this.AppToolbar);
            this.Controls.Add(this.AppMenu);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.AppMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokémon Map Editor";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.AppMenu.ResumeLayout(false);
            this.AppMenu.PerformLayout();
            this.AppToolbar.ResumeLayout(false);
            this.AppToolbar.PerformLayout();
            this.AppStatusBar.ResumeLayout(false);
            this.AppStatusBar.PerformLayout();
            this.pnlMapList.ResumeLayout(false);
            this.pnlEditor.ResumeLayout(false);
            this.tabEditor.ResumeLayout(false);
            this.tabTiles.ResumeLayout(false);
            this.pnlTileset.ResumeLayout(false);
            this.pnlTileset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picTileset)).EndInit();
            this.tabAttributes.ResumeLayout(false);
            this.tabAttributes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAttributes)).EndInit();
            this.tabEvents.ResumeLayout(false);
            this.pnlEventProps.ResumeLayout(false);
            this.pnlEvents.ResumeLayout(false);
            this.pnlEvents.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEvents)).EndInit();
            this.pnlCanvas.ResumeLayout(false);
            this.tabCanvas.ResumeLayout(false);
            this.tabMap.ResumeLayout(false);
            this.pnlMap.ResumeLayout(false);
            this.pnlMap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.tabProperties.ResumeLayout(false);
            this.pnlProperties.ResumeLayout(false);
            this.pnlProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFloorLevel)).EndInit();
            this.fraDimension.ResumeLayout(false);
            this.fraDimension.PerformLayout();
            this.fraTilesets.ResumeLayout(false);
            this.fraTilesets.PerformLayout();
            this.fraMapOptions.ResumeLayout(false);
            this.fraMapOptions.PerformLayout();
            this.tabHeader.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.fraBorder.ResumeLayout(false);
            this.fraBorder.PerformLayout();
            this.fraMinorTileset.ResumeLayout(false);
            this.fraMinorTileset.PerformLayout();
            this.fraMajorTileset.ResumeLayout(false);
            this.fraMajorTileset.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.fraMapHeader.ResumeLayout(false);
            this.fraMapHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip AppMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuOpen;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.ToolStripSeparator mnuSpacer1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStrip AppToolbar;
        private System.Windows.Forms.StatusStrip AppStatusBar;
        private System.Windows.Forms.Panel pnlMapList;
        private System.Windows.Forms.TreeView treeMaps;
        private System.Windows.Forms.Panel pnlEditor;
        private System.Windows.Forms.Panel pnlCanvas;
        private System.Windows.Forms.TabControl tabEditor;
        private System.Windows.Forms.TabPage tabTiles;
        private System.Windows.Forms.TabPage tabAttributes;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabControl tabCanvas;
        private System.Windows.Forms.TabPage tabMap;
        private System.Windows.Forms.TabPage tabProperties;
        private System.Windows.Forms.TabPage tabHeader;
        private System.Windows.Forms.ToolStripButton tbrOpen;
        private System.Windows.Forms.ToolStripButton tbrSave;
        private System.Windows.Forms.ToolStripSeparator tbrSpace1;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.Panel pnlTileset;
        private System.Windows.Forms.PictureBox picTileset;
        private System.Windows.Forms.ToolStripStatusLabel lblROM;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.Panel pnlProperties;
        private System.Windows.Forms.TextBox txtMapName;
        private System.Windows.Forms.ComboBox cmbMapNames;
        private System.Windows.Forms.Label lblMapName;
        private System.Windows.Forms.GroupBox fraMapOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuPlugins;
        private System.Windows.Forms.ImageList NodeImages;
        private System.Windows.Forms.TextBox txtSong;
        private System.Windows.Forms.Label lblSong;
        private System.Windows.Forms.ComboBox cmbWeather;
        private System.Windows.Forms.Label lblWeather;
        private System.Windows.Forms.ComboBox cmbCaveBehaviour;
        private System.Windows.Forms.Label lblCaveBehaviour;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cmbBattleStyle;
        private System.Windows.Forms.Label lblBattleStyle;
        private System.Windows.Forms.GroupBox fraDimension;
        private System.Windows.Forms.GroupBox fraTilesets;
        private System.Windows.Forms.GroupBox fraMapScripts;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Button cmdChange;
        private System.Windows.Forms.Label lblMinor;
        private System.Windows.Forms.TextBox txtMinor;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.Button cmdResize;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.Label lblBorder;
        private System.Windows.Forms.Label lblMapHeader;
        private System.Windows.Forms.TextBox txtMapHeader;
        private System.Windows.Forms.TextBox txtBank;
        private System.Windows.Forms.Label lblBank;
        private System.Windows.Forms.GroupBox fraMapHeader;
        private System.Windows.Forms.Label lblConnections;
        private System.Windows.Forms.Label lblMapScripts;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblMapData;
        private System.Windows.Forms.TextBox txtConnections;
        private System.Windows.Forms.TextBox txtMapScripts;
        private System.Windows.Forms.TextBox txtEvents;
        private System.Windows.Forms.TextBox txtMapData;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMinorTileset;
        private System.Windows.Forms.Label lblMajorTileset;
        private System.Windows.Forms.Label lblMapTileData;
        private System.Windows.Forms.Label lblBorderData;
        private System.Windows.Forms.TextBox txtMinorTileset;
        private System.Windows.Forms.TextBox txtMajorTileset;
        private System.Windows.Forms.TextBox txtMapTileData;
        private System.Windows.Forms.TextBox txtBorderData;
        private System.Windows.Forms.GroupBox fraMinorTileset;
        private System.Windows.Forms.Label lblAnimation2;
        private System.Windows.Forms.Label lblBehaviours2;
        private System.Windows.Forms.Label lblBlocks2;
        private System.Windows.Forms.Label lblPalette2;
        private System.Windows.Forms.TextBox txtAnimation2;
        private System.Windows.Forms.TextBox txtBehaviours2;
        private System.Windows.Forms.TextBox txtBlocks2;
        private System.Windows.Forms.TextBox txtPalette2;
        private System.Windows.Forms.TextBox txtImage2;
        private System.Windows.Forms.Label lblImage2;
        private System.Windows.Forms.CheckBox chkMajorTileset2;
        private System.Windows.Forms.CheckBox chkLZ772;
        private System.Windows.Forms.GroupBox fraMajorTileset;
        private System.Windows.Forms.Label lblAnimation1;
        private System.Windows.Forms.Label lblBehaviours1;
        private System.Windows.Forms.Label lblBlocks1;
        private System.Windows.Forms.Label lblPalette1;
        private System.Windows.Forms.TextBox txtAnimation1;
        private System.Windows.Forms.TextBox txtBehaviours1;
        private System.Windows.Forms.TextBox txtBlocks1;
        private System.Windows.Forms.TextBox txtPalette1;
        private System.Windows.Forms.TextBox txtImage1;
        private System.Windows.Forms.Label lblImage1;
        private System.Windows.Forms.CheckBox chkMajorTileset1;
        private System.Windows.Forms.CheckBox chkLZ771;
        private System.Windows.Forms.Button cmdHeader;
        private System.Windows.Forms.Button cmdSaveMinor;
        private System.Windows.Forms.Button cmdSaveMajor;
        private System.Windows.Forms.GroupBox fraBorder;
        private System.Windows.Forms.Button cmdResizeBorder;
        private System.Windows.Forms.Label lblBorderHeight;
        private System.Windows.Forms.TextBox txtBorderHeight;
        private System.Windows.Forms.TextBox txtBorderWidth;
        private System.Windows.Forms.Label lblBorderWidth;
        private System.Windows.Forms.ComboBox cmbShowName;
        private System.Windows.Forms.Label lblShowName;
        private System.Windows.Forms.NumericUpDown numFloorLevel;
        private System.Windows.Forms.Label lblFloorLevel;
        private System.Windows.Forms.PictureBox picAttributes;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentBank;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentMap;
        private System.Windows.Forms.ToolStripStatusLabel lblCurrentTile;
        private System.Windows.Forms.ToolStripStatusLabel lblLocation;
        private System.Windows.Forms.ToolStripMenuItem mnuOptions;
        private System.Windows.Forms.ToolStripMenuItem mnuPalette;
        private System.Windows.Forms.ToolStripMenuItem mnuNormal;
        private System.Windows.Forms.ToolStripMenuItem mnuMorning;
        private System.Windows.Forms.ToolStripMenuItem mnuAfternoon;
        private System.Windows.Forms.ToolStripMenuItem mnuEvening;
        private System.Windows.Forms.ToolStripMenuItem mnuNight;
        private System.Windows.Forms.ToolStripMenuItem mnuAuto;
        private System.Windows.Forms.ComboBox cmbSong;

        #region Song Lists

        private object[] RSSongs = new object[] {
            "",
            "15E - Littleroot Town Test \'Tetsuji\'",
            "15F - Gold & Silver - Route 38",
            "160 - Wild Pokemon Defeat",
            "161 - Wild Pokemon Defeat w/Intro",
            "162 - Gym Leader Defeat",
            "163 - Acquired Badge",
            "164 - Crystal - Pokémon Center",
            "165 - Gold & Silver - Saffron City",
            "166 - Crystal - Battle with Legendary Dogs",
            "167 - Route Theme 1",
            "168 - Route Theme 2",
            "169 - Route Theme 3",
            "16A - Petalburg City",
            "16B - Oldale Town & Lavaridge Town",
            "16C - Gym",
            "16D - Surfing",
            "16E - Caves & Darkness",
            "16F - Level Up",
            "170 - Pokemon Healed",
            "171 - Big Victory",
            "172 - Acquired Item",
            "173 - Pokemon Caught",
            "174 - Got TM/HM",
            "175 - Lilycove Museum",
            "176 - Route Theme 4",
            "177 - Slateport Museum (Oceanic Museum)",
            "178 - Evolve Intro",
            "179 - Evolving",
            "17A - Unknown Victory 1",
            "17B - Tuber Encounter",
            "17C - Boy Encounter",
            "17D - A Far-away Place (Shipwreck - Abandoned Ship)",
            "17E - Fortree City",
            "17F - Birch\'s Lab",
            "180 - Battle Tower",
            "181 - Swimmer Ecounter",
            "182 - Meteor Falls",
            "183 - Got a Berry",
            "184 - Unknown Victory 2",
            "185 - Unknown Victory 3",
            "186 - Unknown Victory 4",
            "187 - Pay No Attention!",
            "188 - Unknown Victory 1",
            "189 - Beauty Contest 1",
            "18A - Beauty Contest 2",
            "18B - Beauty Contest 3",
            "18C - Beauty Contest 4",
            "18D - Ship Ecounter",
            "18E - Verdanturf Town",
            "18F - Rustboro City, Mauville City, Mossdeep City",
            "190 - Pokemon Center",
            "191 - Route Theme 5",
            "192 - Route Theme 6",
            "193 - Bicycle Ride",
            "194 - PokéMart",
            "195 - Littleroot Town",
            "196 - Sky Pillar, Mt.Chimney",
            "197 - Girl Encounter",
            "198 - Lilycove City",
            "199 - The Sandy Desert",
            "19A - Help Me! (Rescue Birch)",
            "19B - Underwater Dive",
            "19C - Trainer Defeat",
            "19D - Title Screen",
            "19E - Introduction",
            "19F - May\'s Theme",
            "1A0 - Electric Encounter",
            "1A1 - Biker Encounter",
            "1A2 - Route Theme 7",
            "1A3 - Aqua Encounter",
            "1A4 - Show Me Around",
            "1A5 - Brendan\'s Theme",
            "1A6 - Evergrande City",
            "1A7 - Psychic Encounter",
            "1A8 - Important Defeat",
            "1A9 - Riding the Cable Car",
            "1AA - Game Corner",
            "1AB - Dewford Town",
            "1AC - Safari Zone",
            "1AD - Path to Victory - Victory Road",
            "1AE - Team Magma/Aqua Hideout",
            "1AF - Sailing the Sea (M.S. Tide)",
            "1B0 - Mt.Pyre, Shoal Cave, New Mauville",
            "1B1 - Slateport City",
            "1B2 - The Fog of Mt. Pyre",
            "1B3 - Pokémon Trainer School",
            "1B4 - You\'re the Champ!",
            "1B5 - Fallarbor Town",
            "1B6 - Desert Ruins, Island Cave, Ancient Tomb",
            "1B7 - Important Defeat 2",
            "1B8 - Beauty Contest",
            "1B9 - Magma Encounter",
            "1BA - The Pokémon!",
            "1BB - The Flood",
            "1BC - The Drought",
            "1BD - Sootopolis City",
            "1BE - Berry Blending Results",
            "1BF - Hall of Fame",
            "1C0 - You\'re Being Watched!",
            "1C1 - Kid Encounter",
            "1C2 - Elite Four Theme",
            "1C3 - Sailor Encounter",
            "1C4 - Beauty Contest Lobby (Pokemon Contest)",
            "1C5 - What\'s On TV?",
            "1C6 - Unknown Encounter",
            "1C7 - Ending Credits",
            "1C8 - The End!",
            "1C9 - Battle - Wild Pokémon",
            "1CA - Battle - Aqua/Magma",
            "1CB - Battle - Pokémon Trainer",
            "1CC - Battle - Gym Leader",
            "1CD - Battle - Champion Steven",
            "1CE - Battle - Regirock, Regice and Registeel",
            "1CF - Battle - Legendary Pokémon",
            "1D0 - Battle - Rival",
            "1D1 - Battle - Elite Four",
            "1D2 - Battle - Team Leader",
            "1D3 - Gold & Silver - Team Rocket (US Ruby Version Only)"};

        private object[] FRLGSongs = new object[] {
            "",
            "100 - Healing (Ruby & Sapphire)",
            "101 - Level Up",
            "102 - ???",
            "103 - ???",
            "104 - ???",
            "105 - ???",
            "106 - ???",
            "107 - Evolution Start",
            "108 - Evolution/Safari Zone",
            "109 - Battle 1",
            "10A - Battle 2",
            "10B - ???",
            "10C - Fanfare 1",
            "10D - Fanfare 2",
            "10E - You Fail It!",
            "10F - You Fail It Again!",
            "110 - Follow Me",
            "111 - Game Corner",
            "112 - Evil Lurks",
            "113 - Gym",
            "114 - Jigglypuff\'s Lullaby",
            "115 - Introducion",
            "116 - Pokemon Theme",
            "117 - Cinnabar Island",
            "118 - Lavender Town",
            "119 - Healing",
            "11A - Bicycle",
            "11B - Encounter 1",
            "11C - Encounter 2",
            "11D - Encounter 3",
            "11E - You\'re In The Hall Of Fame!",
            "11F - Viridian Forest",
            "120 - Mount Moon",
            "121 - Abandoned Place",
            "122 - End Credits",
            "123 - Route Theme 1",
            "124 - Route Theme 2 / Intro",
            "125 - Route Theme 3",
            "126 - Route Theme 4",
            "127 - Indigo Plateau",
            "128 - Battle 3",
            "129 - Battle 4",
            "12A - Battle 5",
            "12B - Battle 6",
            "12C - Pallet Town",
            "12D - Oak\'s Lab",
            "12E - Oak\'s Theme",
            "12F - Pokémon Center",
            "130 - SS Anne",
            "131 - Surf\'s Up",
            "132 - Pokémon Tower",
            "133 - Silph Co.",
            "134 - Cerulean City",
            "135 - Celadon City",
            "136 - Victory 1",
            "137 - Victory 2",
            "138 - Victory 3",
            "139 - Vermillion City",
            "13A - Viridian City",
            "13B - Gary\'s Theme",
            "13C - Gary\'s Theme (bis)",
            "13D - Fanfare 3",
            "13E - Fanfare 4",
            "13F - You caught a Pokémon!",
            "140 - Trainer Card Photo",
            "141 - Gamefreak",
            "142 - Victory 2 (bis)",
            "143 - Intro Message 1",
            "144 - Intro Message 2",
            "145 - Intro Message 3",
            "146 - Game Corner (+1)",
            "147 - Game Corner (+2)",
            "148 - Net Center",
            "149 - Mystery Connection",
            "14A - Game Corner (+3)",
            "14B - Mount Ember",
            "14C - Follow Me (Alternate)",
            "14D - Water Labyrinth",
            "14E - Tanoby Ruins",
            "14F - Islands 1-3",
            "150 - Islands 4-5",
            "151 - Islands 6-7",
            "152 - PokéFlute",
            "153 - Battle - Deoys",
            "154 - Battle 5 (+1)",
            "155 - Battle 5 (+2)",
            "156 - Encounter 4",
            "157 - Deoxys Encounter",
            "158 - Trainer Tower",
            "159 - Pallet Town (Fame mix)",
            "15A - Teachy TV"};

        private object[] EMSongs = new object[] {
            "",
            "15E - Littleroot Town Test \'Tetsuji\'",
            "15F - Gold & Silver - Route 38",
            "160 - Wild Pokemon Defeat",
            "161 - Wild Pokemon Defeat w/Intro",
            "162 - Gym Leader Defeat",
            "163 - Acquired Badge",
            "164 - Crystal - Pokémon Center",
            "165 - Gold & Silver - Saffron City",
            "166 - Crystal - Battle with Legendary Dogs",
            "167 - Route Theme 1",
            "168 - Route Theme 2",
            "169 - Route Theme 3",
            "16A - Petalburg City",
            "16B - Oldale Town & Lavaridge Town",
            "16C - Gym",
            "16D - Surfing",
            "16E - Caves & Darkness",
            "16F - Level Up",
            "170 - Pokemon Healed",
            "171 - Big Victory",
            "172 - Acquired Item",
            "173 - Pokemon Caught",
            "174 - Got TM/HM",
            "175 - Lilycove Museum",
            "176 - Route Theme 4",
            "177 - Slateport Museum",
            "178 - Evolve Intro",
            "179 - Evolving",
            "17A - Unknown Victory 1",
            "17B - Tuber Encounter",
            "17C - Boy Encounter",
            "17D - A Far-away Place",
            "17E - Fortree City",
            "17F - Birch\'s Lab",
            "180 - Battle Tower",
            "181 - Swimmer Encounter",
            "182 - Meteor Falls",
            "183 - Got a Berry",
            "184 - Unknown Victory 1",
            "185 - Unknown Victory 3",
            "186 - Unknown Victory 4",
            "187 - Pay No Attention!",
            "188 - Unknown Theme 1",
            "189 - Beauty Contest Test 1",
            "18A - Beauty Contest Test 2",
            "18B - Beauty Contest Test 3",
            "18C - Beauty Contest Test 4",
            "18D - Ship Encounter",
            "18E - Verdanturf Town",
            "18F - Rustboro City",
            "190 - Pokémon Center",
            "191 - Route Theme 5",
            "192 - Route Theme 6",
            "193 - Bicycle Ride",
            "194 - PokéMart",
            "195 - Littleroot Town",
            "196 - Sky Pillar",
            "197 - Girl Encounter",
            "198 - Lilycove City",
            "199 - The Sandy Desert",
            "19A - Help Me! (Rescue Birch)",
            "19B - Underwater Dive",
            "19C - Trainer Defeat",
            "19D - Title Screen",
            "19E - Introduction",
            "19F - May\'s Theme",
            "1A0 - Electric Encounter",
            "1A1 - Biker Encounter",
            "1A2 - Route Theme 7",
            "1A3 - Aqua Encounter",
            "1A4 - Show Me Around",
            "1A5 - Brendan\'s Theme",
            "1A6 - Evergrande City",
            "1A7 - Psychic Encounter",
            "1A8 - Important Defeat",
            "1A9 - Riding the Cable Car",
            "1AA - Game Corner",
            "1AB - Dewford Town",
            "1AC - Safari Zone",
            "1AD - Path to Victory - Victory Road",
            "1AE - Team Hideout",
            "1AF - Sailing the Sea",
            "1B0 - Shoal Cave",
            "1B1 - Slateport City",
            "1B2 - The Fog of Mt. Pyre",
            "1B3 - Pokémon Trainer School",
            "1B4 - You\'re the Champ!",
            "1B5 - Fallarbor Town",
            "1B6 - Island Cave",
            "1B7 - Important 2 Defeat",
            "1B8 - Beauty Contest",
            "1B9 - Magma Encounter",
            "1BA - The Pokémon!",
            "1BB - The Flood",
            "1BC - The Drought",
            "1BD - Sootopolis City",
            "1BE - Berry Blending Results",
            "1BF - Hall of Fame",
            "1C0 - You\'re Being Watched!",
            "1C1 - Kid Encounter",
            "1C2 - Elite Four Theme",
            "1C3 - Sailor Encounter",
            "1C4 - Beauty Contest Lobby",
            "1C5 - What\'s On TV?",
            "1C6 - Unknown Encounter",
            "1C7 - Ending Credits",
            "1C8 - The End!",
            "1C9 - Battle Frontier",
            "1CA - Battle Arena",
            "1CB - Battle Point!",
            "1CC - Registered Trainer",
            "1CD - Battle Pyramid",
            "1CE - Pyramid Top",
            "1CF - Battle Palace",
            "1D0 - Rayquaza Enters",
            "1D1 - Battle Tower",
            "1D2 - Frontier Badge!",
            "1D3 - Dome Tournament",
            "1D4 - Battle Tube",
            "1D5 - Battle Factory",
            "1D6 - Battle - Legendary Pokémon",
            "1D7 - Battle - Frontier Brains",
            "1D8 - Battle - Mew",
            "1D9 - Battle Dome Lobby",
            "1DA - Battle - Wild Pokémon",
            "1DB - Battle - Aqua/Magma",
            "1DC - Battle - Pokémon Trainer",
            "1DD - Battle - Gym Leader",
            "1DE - Battle - Champion Wallace",
            "1DF - Battle - Regirock, Regice and Registeel",
            "1E0 - Battle - Legendary Pokémon",
            "1E1 - Battle - Rival",
            "1E2 - Battle - Elite Four",
            "1E3 - Battle - Team Leader",
            "1E4 - Follow Me",
            "1E5 - Game Corner",
            "1E6 - Evil Lurks",
            "1E7 - Gym (Fire Red & Leaf Green)",
            "1E8 - Jigglypuff\'s Song",
            "1E9 - Introduction (Fire Red & Leaf Green)",
            "1EA - Pokémon Theme",
            "1EB - Cinnabar Island",
            "1EC - Lavender Town",
            "1ED - Healing",
            "1EE - Bicycle",
            "1EF - Encounter 1",
            "1F0 - Encounter 2",
            "1F1 - Encounter 3",
            "1F2 - You\'re in the Hall Of Fame!",
            "1F3 - Viridian Forest",
            "1F4 - Mount Moon",
            "1F5 - Abandoned Place",
            "1F6 - End Credits (Fire Red & Leaf Green)",
            "1F7 - Route Theme 8",
            "1F8 - Route Theme 9 (Fire Red & Leaf Green Intro)",
            "1F9 - Route Theme 10",
            "1FA - Route Theme 11",
            "1FB - Indigo Plateau",
            "1FC - Battle 3",
            "1FD - Battle 4",
            "1FE - Battle 5",
            "1FF - Battle 6",
            "200 - Pallet Town",
            "201 - Oak\'s Lab",
            "202 - Oak\'s Theme",
            "203 - Pokémon Center",
            "204 - SS Anne",
            "205 - Surf\'s Up",
            "206 - Pokémon Tower",
            "207 - Silph Co.",
            "208 - Cerulean City",
            "209 - Celadon City",
            "20A - Victory 1",
            "20B - Victory 2",
            "20C - Victory 3",
            "20D - Vermillion City",
            "20E - Viridian City",
            "20F - Gary\'s Theme",
            "210 - Gary\'s Theme (bis)",
            "211 - Fanfare 3",
            "212 - Fanfare 4",
            "213 - You caught a Pokémon!",
            "214 - Trainer Card Photo",
            "215 - Gamefreak",
            "216 - Victory 2 (bis)",
            "217 - Intro Message 1",
            "218 - Intro Message 2",
            "219 - Intro Message 3",
            "21A - Game Corner (+1)",
            "21B - Game Corner (+2)",
            "21C - Net Center",
            "21D - Mystery Connection",
            "21E - Game Corner (+3)",
            "21F - Mount Ember",
            "220 - Follow Me (Alternate)",
            "221 - Sevii Island Paths",
            "222 - Tanoby Ruins",
            "223 - Islands 1-3",
            "224 - Islands 4-5",
            "225 - Islands 6-7",
            "226 - PokéFlute",
            "227 - Battle - Deoxys",
            "228 - Battle 5 (+1)",
            "229 - Battle 5 (+2)",
            "22A - Encounter 4",
            "22B - Deoxys Encounter",
            "22C - Trainer Tower",
            "22D - Pallet Town (Fame mix)",
            "22E - Teachy TV"};

        #endregion
        private System.Windows.Forms.Button cmdChangeName;
        private System.Windows.Forms.ToolStripSeparator mnuSpacer2;
        private System.Windows.Forms.ToolStripMenuItem mnuFreeSpaceFinder;
        private System.Windows.Forms.Panel pnlEvents;
        private System.Windows.Forms.Label lblEventIndex;
        private System.Windows.Forms.NumericUpDown numEvents;
        private System.Windows.Forms.ComboBox cmbEvents;
        private System.Windows.Forms.Panel pnlEventProps;
        private System.Windows.Forms.PropertyGrid propEvents;
        private System.Windows.Forms.PictureBox picBorder;
        private System.Windows.Forms.Button cmdDelete;


    }
}

