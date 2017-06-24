using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Xml;
using System.Text;
using System.Windows.Forms;

namespace PokemonMapEditor
{
    public partial class frmMain : Form
    {
        private const int DEC = 10;
        private const int HEX = 16;

        private const int TileSize = 16;
        private const int TileWidth = 16;
        private const int TileHeight = 16;
        private const int TilesPerRow = 8;

        private int CurrentTile = 0;
        private int CurrentAttribute = 0;
        private int SelectedBank, SelectedMap;

        private int CurrentPerson;

        private Map CurrentMap;
        private Tileset MajorTileset, MinorTileset;

        public bool TaskDialogSupported;
        public ROM CurrentROM = new ROM();
        //public Plugin Plugins = new Plugin();

        public static byte[] PaletteSet = new byte[6];

        private Graphics MapGraphics, AttributeGraphics, FinalGraphics, BorderGraphics;
        private Bitmap TilesetImage, AttributeBlocks, MapImage, AttributeMap, FinalMapImage, BorderImage;

        public frmMain()
        {
            InitializeComponent();

            AttributeBlocks = new Bitmap(PokemonMapEditor.Properties.Resources.Attributes);
            picAttributes.Image = AttributeBlocks;

            if (Environment.OSVersion.Version.Major >= 6)
                TaskDialogSupported = true;
        }

        private void mnuOpen_Click(object sender, EventArgs e)
        {
            ROM LoadedROM;
            OpenFileDialog cdgOpen = new OpenFileDialog();

            cdgOpen.Title = "Open ROM...";
            cdgOpen.Filter = "Gameboy Advance ROMs (.*.agb;*.bin;*.gba)|*.agb;*.bin;*.gba";
            cdgOpen.DefaultExt = "gba";

            if (cdgOpen.ShowDialog() != DialogResult.OK) // Exit if no ROM is loaded
                return;
            if (CurrentROM.FilePath == cdgOpen.FileName) // Exit if same ROM is loaded
                return;

            LoadedROM = new ROM();
            LoadedROM.Load(cdgOpen.FileName);

            if (!OpenROM(LoadedROM))
            {
                if (TaskDialogSupported)
                    TaskDialog.Show(this, "The ROM you have loaded is not supported.\nYou can add support for it by editing the PME.ROMs.xml file or wait for future versions of the tool.", "Error - Unsupported ROM!", Application.ProductName, TaskDialogButtons.OK, TaskDialogIcon.Warning);
                else
                    MessageBox.Show("Error - Unsupported ROM!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }

            CurrentROM = LoadedROM; // Confirm loaded ROM
            mnuSave.Enabled = true;
            tbrSave.Enabled = true;
            lblROM.Text = CurrentROM.GameTitle + " - " + CurrentROM.GameCode;

            InitialisePointers();
            Maps.PopulateMapList(CurrentROM, treeMaps, cmbMapNames); // Load maps
        }

        private bool OpenROM(ROM rom)
        {
            if (!File.Exists(Path.Combine(Application.StartupPath, "PME.ROMs.xml"))) // Load ROM database if it doesn't exist
            {
                string Test = Path.Combine(Application.StartupPath, "PME.ROMs.xml");
                string PMEROMs = PokemonMapEditor.Properties.Resources.PME_ROMs;
                StreamWriter PMEROMFile = new StreamWriter(File.Open(Path.Combine(Application.StartupPath, "PME.ROMs.xml"), FileMode.Create, FileAccess.Write, FileShare.None));

                PMEROMFile.BaseStream.Position = 0;
                PMEROMFile.Write(PMEROMs);

                PMEROMFile.Close();
            }

            XmlDocument ROMDatabase = new XmlDocument();
            ROMDatabase.Load(Path.Combine(Application.StartupPath, "PME.ROMs.xml")); // Load ROM database

            XmlNode ROM = null;
            foreach (XmlElement e in ROMDatabase.FirstChild.ChildNodes.OfType<XmlElement>()) // Look for ROM entry in database
            {
                if (e.GetAttribute("code") == rom.GameCode && e.GetAttribute("version") == rom.GameVersion.ToString())
                    ROM = e;
            }

            if (ROM == null) // If can't find it exit
                return false;

            foreach(XmlElement entry in ROM.ChildNodes.OfType<XmlElement>()) // Get offsets from PME.ROMs
            {
                string attribute = entry.GetAttribute("id");
                uint offset = uint.Parse(entry.GetAttribute("value"), System.Globalization.NumberStyles.HexNumber);

                if (attribute == "TilesetHeader")
                    rom.TilesetHeader = offset;
                else if (attribute == "MapBankOrigin")
                    rom.MapBankOrigin = offset;
                else if (attribute == "MapNamesOrigin1")
                    rom.MapNamesOrigin = offset;
            }

            return true;
        }

        private void InitialisePointers()
        {
            BinaryReader ReadROM = new BinaryReader(File.Open(CurrentROM.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            ReadROM.BaseStream.Position = CurrentROM.MapBankOrigin;
            CurrentROM.MapBank = ReadROM.ReadUInt32() - 0x8000000;

            ReadROM.BaseStream.Position = CurrentROM.MapNamesOrigin;
            CurrentROM.MapNames = ReadROM.ReadUInt32() - 0x8000000;

            ReadROM.Close();

            if (CurrentROM.GameCode.Substring(0, 3) == "AXV" || CurrentROM.GameCode.Substring(0, 3) == "AXP")
                cmbSong.Items.AddRange(RSSongs);
            else if (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG")
                cmbSong.Items.AddRange(FRLGSongs);
            else
                cmbSong.Items.AddRange(EMSongs);
        }

        /* To be completed */
        private void mnuTools_DropDownOpened(object sender, EventArgs e)
        {
            //if (CurrentROM.FilePath.Equals(""))
            //    return;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void treeMaps_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Parent == null || e.Node.Text.Substring(9, 8) == "RESERVED")
                return;

            if (!pnlMap.Visible)
            {
                pnlMap.Visible = true;
                pnlEvents.Visible = true;
                pnlEventProps.Visible = true;
                pnlTileset.Visible = true;
                picAttributes.Visible = true;
                pnlProperties.Visible = true;
                pnlHeader.Visible = true;
            }

            tabEditor.SelectedIndex = 0;

            SelectedMap = e.Node.Index;
            SelectedBank = e.Node.Parent.Index;

            lblCurrentMap.Text = "Map " + SelectedMap.ToString();
            lblCurrentBank.Text = "Bank: " + SelectedBank.ToString();

            long ExecutionTime = System.DateTime.Now.Ticks;
            CurrentMap = Maps.LoadMap(CurrentROM, SelectedBank, SelectedMap); // Load map

            LoadHeader(); // Load stuff for Header View
            LoadProperties(); // Load stuff for Properties View
            MapEvents.Load(CurrentROM, CurrentMap); // Load events
            DrawMap(); // Renders the map, tileset & border

            lblStatus.Text = "Map loaded in " + ((System.DateTime.Now.Ticks - ExecutionTime) / TimeSpan.TicksPerMillisecond) + " milliseconds.";
            lblCurrentTile.Text = "Current Tile: 0x0";
            picTileset.Invalidate();
        }

        private void LoadHeader()
        {
            txtBank.Text = Convert.ToString(CurrentMap.MapBankOffset, HEX);
            txtMapHeader.Text = Convert.ToString(CurrentMap.MapHeaderOffset, HEX);

            txtMapData.Text = Convert.ToString(CurrentMap.LayoutData, HEX);
            txtEvents.Text = Convert.ToString(CurrentMap.EventData, HEX);
            txtMapScripts.Text = Convert.ToString(CurrentMap.MapScripts, HEX);
            txtConnections.Text = Convert.ToString(CurrentMap.ConnectionData, HEX);

            txtBorderData.Text = Convert.ToString(CurrentMap.Border, HEX);
            txtMapTileData.Text = Convert.ToString(CurrentMap.MapData, HEX);
            txtMajorTileset.Text = Convert.ToString(CurrentMap.MajorTileset, HEX);
            txtMinorTileset.Text = Convert.ToString(CurrentMap.MinorTileset, HEX);

            MajorTileset = Tilesets.Load(CurrentROM, CurrentMap.MajorTileset - 0x8000000, CurrentROM.TilesetHeader); // Load major tileset
            MinorTileset = Tilesets.Load(CurrentROM, CurrentMap.MinorTileset - 0x8000000, CurrentROM.TilesetHeader); // Load minor tileset
            chkLZ771.Checked = (MajorTileset.LZ77Compressed == 1);
            chkLZ772.Checked = (MinorTileset.LZ77Compressed == 1);
            chkMajorTileset1.Checked = (MajorTileset.MajorTileset == 0);
            chkMajorTileset2.Checked = (MinorTileset.MajorTileset == 0);
            txtImage1.Text = Convert.ToString(MajorTileset.Image, HEX);
            txtImage2.Text = Convert.ToString(MinorTileset.Image, HEX);
            txtPalette1.Text = Convert.ToString(MajorTileset.Palette, HEX);
            txtPalette2.Text = Convert.ToString(MinorTileset.Palette, HEX);
            txtBlocks1.Text = Convert.ToString(MajorTileset.BlockData, HEX);
            txtBlocks2.Text = Convert.ToString(MinorTileset.BlockData, HEX);
            txtBehaviours1.Text = Convert.ToString(MajorTileset.BehaviourData, HEX);
            txtBehaviours2.Text = Convert.ToString(MinorTileset.BehaviourData, HEX);
            txtAnimation1.Text = Convert.ToString(MajorTileset.Animation, HEX);
            txtAnimation2.Text = Convert.ToString(MinorTileset.Animation, HEX);

            bool BorderSupport = (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG");
            fraBorder.Visible = BorderSupport;
            if (BorderSupport)
            {
                txtBorderWidth.Text = CurrentMap.BorderWidth.ToString();
                txtBorderHeight.Text = CurrentMap.BorderHeight.ToString();
            }
        }

        private void LoadProperties()
        {
            int NameIndex = CurrentMap.MapNameIndex;
            lblFloorLevel.Visible = (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG");
            numFloorLevel.Visible = (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG");

            if (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG")
            {
                NameIndex -= 0x58;
                numFloorLevel.Value = CurrentMap.FloorLevel;
            }

            try
            {
                if (CurrentROM.GameCode.Substring(0, 3) == "AXV" || CurrentROM.GameCode.Substring(0, 3) == "AXP")
                    cmbSong.SelectedIndex = CurrentMap.MapSong - 0x15D;
                else if (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG")
                    cmbSong.SelectedIndex = CurrentMap.MapSong - 0xFF;
                else
                    cmbSong.SelectedIndex = CurrentMap.MapSong - 0x15D;
            }
            catch
            {
                cmbSong.SelectedIndex = 0;
            }
            txtSong.Text = Convert.ToString(CurrentMap.MapSong, HEX);

            cmbMapNames.SelectedIndex = NameIndex;
            txtMapName.Text = Maps.MapNameList[NameIndex];
            cmbCaveBehaviour.SelectedIndex = CurrentMap.CaveBehaviour;
            cmbWeather.SelectedIndex = CurrentMap.Weather;
            cmbType.SelectedIndex = CurrentMap.MapType;
            cmbShowName.SelectedIndex = CurrentMap.ShowName;
            cmbBattleStyle.SelectedIndex = CurrentMap.BattleStyle;

            txtWidth.Text = CurrentMap.Width.ToString();
            txtHeight.Text = CurrentMap.Height.ToString();
            txtMajor.Text = MajorTileset.Number.ToString();
            txtMinor.Text = MinorTileset.Number.ToString();
        }

        private void DrawMap()
        {
            int Width = (int)CurrentMap.Width * 16;
            int Height = (int)CurrentMap.Height * 16;

            TilesetImage = Tilesets.Render(CurrentROM, MajorTileset, MinorTileset, CurrentMap);
            picTileset.Image = TilesetImage;

            MapImage = new Bitmap(Width, Height);
            AttributeMap = new Bitmap(Width, Height);
            FinalMapImage = new Bitmap(Width, Height);

            MapGraphics = Graphics.FromImage(MapImage);
            AttributeGraphics = Graphics.FromImage(AttributeMap);
            FinalGraphics = Graphics.FromImage(FinalMapImage);

            CurrentMap.MapTileData = Maps.RenderMap(CurrentROM, MapImage, TilesetImage, AttributeMap, AttributeBlocks, CurrentMap);
            //Maps.RenderAttributes(AttributeMap, AttributeBlocks, CurrentMap);
            picMap.Image = MapImage;

            BorderImage = new Bitmap(CurrentMap.BorderWidth * 16, CurrentMap.BorderHeight * 16);
            BorderGraphics = Graphics.FromImage(BorderImage);

            CurrentMap.BorderData = Maps.RenderBorder(CurrentROM, BorderGraphics, TilesetImage, CurrentMap);
            picBorder.Image = BorderImage;
        }

        private void picTileset_Paint(object sender, PaintEventArgs e)
        {
            Pen Cursor = new Pen(Color.Blue, 2f);
            e.Graphics.DrawRectangle(Cursor, (CurrentTile % 8) * TileSize, (CurrentTile / 8) * TileSize, 16, 16);
        }

        private void picTileset_Handle(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (e.X < 0 || e.X >= picTileset.Width || e.Y < 0 || e.Y >= picTileset.Height)
                return;

            CurrentTile = ((e.Y / TileSize) * 8) + (e.X / TileSize);
            lblCurrentTile.Text = "Current Tile: 0x" + Convert.ToString(CurrentTile, HEX).ToUpper();
            picTileset.Invalidate();
        }

        private void picAttributes_Paint(object sender, PaintEventArgs e)
        {
            Pen Cursor = new Pen(Color.White, 2f);
            e.Graphics.DrawRectangle(Cursor, (CurrentAttribute % 8) * TileSize, (CurrentAttribute / 8) * TileSize, 16, 16);
        }

        private void picAttributes_MouseHandle(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            if (e.X < 0 || e.X >= (picAttributes.Width - 2) || e.Y < 0 || e.Y >= (picAttributes.Height - 2))
                return;

            CurrentAttribute = ((e.Y / TileSize) * 8) + (e.X / TileSize);
            picAttributes.Invalidate();
        }

        private void tabEditor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CurrentMap == null) // Exit if no map is loaded
                return;

            if (tabEditor.SelectedIndex == 0) // Map editing
                picMap.Image = MapImage;
            else if (tabEditor.SelectedIndex == 1) // Attribute editing
            {
                RenderFinalImage();
                picMap.Image = FinalMapImage;
                picAttributes.Invalidate();
            }
            else if (tabEditor.SelectedIndex == 2) // Event editing
            {
                RenderEvents();
                picMap.Image = FinalMapImage;
            }
        }

        private void RenderFinalImage()
        {
            ColorMatrix cm = new ColorMatrix();
            ImageAttributes ia = new ImageAttributes();

            FinalGraphics.DrawImageUnscaled(MapImage, 0, 0);

            cm.Matrix33 = 0.5f;
            ia.SetColorMatrix(cm);
            FinalGraphics.DrawImage(AttributeMap, new Rectangle(Point.Empty, FinalMapImage.Size), 0, 0, FinalMapImage.Width, FinalMapImage.Height, GraphicsUnit.Pixel, ia);
            ia.ClearColorMatrix();
        }

        private void RenderEvents()
        {
            Rectangle EventRect = new Rectangle(0, 0, 16, 16);

            FinalGraphics.DrawImageUnscaled(MapImage, 0, 0);

            if (CurrentMap.People != null)
            {
                foreach (Person p in CurrentMap.People)
                {
                    EventRect.X = p.X * 16;
                    EventRect.Y = p.Y * 16;

                    FinalGraphics.DrawImage(PokemonMapEditor.Properties.Resources.Person, EventRect, 0, 0, 16, 16, GraphicsUnit.Pixel);
                }
            }

            if (CurrentPerson != -1 && CurrentPerson < CurrentMap.PersonCount)
                FinalGraphics.DrawRectangle(Pens.Red, CurrentMap.People[CurrentPerson].X * 16, CurrentMap.People[CurrentPerson].Y * 16, 16, 16);
        }

        private void DrawTile(int x, int y, int tilenumber)
        {
            Rectangle SrcRect = new Rectangle((tilenumber % 8) * TileSize, (tilenumber / 8) * TileSize, TileSize, TileSize);
            Rectangle DestRect = new Rectangle(x * TileSize, y * TileSize, TileSize, TileSize);

            MapGraphics.DrawImage(TilesetImage, DestRect, SrcRect, GraphicsUnit.Pixel);
        }

        private void DrawAttribute(int x, int y, int attribute)
        {
            ColorMatrix cm = new ColorMatrix();
            ImageAttributes ia = new ImageAttributes();
            Rectangle DestRect = new Rectangle(x * TileSize, y * TileSize, TileSize, TileSize);
            Rectangle SrcRect = new Rectangle((attribute % 8) * TileSize, (attribute / 8) * TileSize, TileSize, TileSize);

            FinalGraphics.DrawImage(MapImage, DestRect, DestRect, GraphicsUnit.Pixel);
            AttributeGraphics.DrawImage(AttributeBlocks, DestRect, SrcRect, GraphicsUnit.Pixel);

            cm.Matrix33 = 0.5f;
            ia.SetColorMatrix(cm);
            FinalGraphics.DrawImage(AttributeMap, DestRect, x * TileSize, y * TileSize, TileSize, TileSize, GraphicsUnit.Pixel, ia);
            ia.ClearColorMatrix();
        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            int x = e.X / TileSize;
            int y = e.Y / TileSize;

            lblLocation.Text = "Location: X: " + Convert.ToString(x, HEX).ToUpper() + " Y: " + Convert.ToString(y, HEX).ToUpper();
            if (e.Button != MouseButtons.Left)
                return;

            if (tabEditor.SelectedIndex == 0) // Map editing
            {
                if (e.X < 0 || e.X >= picMap.Width || e.Y < 0 || e.Y >= picMap.Height)
                    return;

                picMap_MouseDown(sender, e);
            }
            else if (tabEditor.SelectedIndex == 1) // Attributes editing
            {
                if (e.X < 0 || e.X >= picMap.Width || e.Y < 0 || e.Y >= picMap.Height)
                    return;

                picMap_MouseDown(sender, e);
            }
            else if (tabEditor.SelectedIndex == 2) // Event editing
            {
                if (CurrentPerson != -1)
                {
                    CurrentMap.People[CurrentPerson].X = (ushort)x;
                    CurrentMap.People[CurrentPerson].Y = (ushort)y;
                    RenderEvents();
                    propEvents.Refresh();
                    picMap.Refresh();
                }
            }
        }

        private void picMap_MouseDown(object sender, MouseEventArgs e)
        {
            int x = e.X / TileSize;
            int y = e.Y / TileSize;

            if (e.Button != MouseButtons.Left)
                return;

            int OtherBit;
            if (tabEditor.SelectedIndex == 0) // Map editing
            {
                OtherBit = CurrentMap.MapTileData[x, y] & 0xFC00;
                CurrentMap.MapTileData[x, y] = (ushort)(OtherBit | CurrentTile & 0x3FF);

                DrawTile(x, y, CurrentTile);
            }
            else if (tabEditor.SelectedIndex == 1) // Attributes editing
            {
                OtherBit = CurrentMap.MapTileData[x, y] & 0x3FF;
                CurrentMap.MapTileData[x, y] = (ushort)(OtherBit | CurrentAttribute << 10);

                DrawAttribute(x, y, CurrentAttribute);
            }
            else if (tabEditor.SelectedIndex == 2) // Event editing
            {
                if (GetPersonIndex(x, y) != -1)
                {
                    SelectPerson(GetPersonIndex(x, y));
                    RenderEvents();
                    picMap.Invalidate();
                    return;          
                }
            }

            picMap.Invalidate();
        }

        private void picBorder_MouseHandle(object sender, MouseEventArgs e)
        {
            int x = e.X / TileSize;
            int y = e.Y / TileSize;

            if (e.Button != MouseButtons.Left)
                return;

            if (e.X < 0 || e.X >= (picBorder.Width - 2) || e.Y < 0 || e.Y >= (picBorder.Height - 2))
                return;

            int OtherBit = CurrentMap.BorderData[x, y] & 0xFC00;
            CurrentMap.BorderData[x, y] = (ushort)(OtherBit | CurrentTile & 0x3FF);

            Rectangle DestRect = new Rectangle(x * TileSize, y * TileSize, TileSize, TileSize);
            Rectangle SrcRect = new Rectangle((CurrentTile % 8) * TileSize, (CurrentTile / 8) * TileSize, TileSize, TileSize);

            BorderGraphics.DrawImage(TilesetImage, DestRect, SrcRect, GraphicsUnit.Pixel);
            picBorder.Invalidate();
        }

        private void PaletteSet_Changed(object sender, EventArgs e)
        {
            ToolStripMenuItem PaletteChangeMenus = (ToolStripMenuItem)sender;

            mnuNormal.Checked = false;
            mnuMorning.Checked = false;
            mnuAfternoon.Checked = false;
            mnuEvening.Checked = false;
            mnuNight.Checked = false;
            mnuAuto.Checked = false;

            for (int i = 0; i < 6; i++)
                PaletteSet[i] = 0;

            if (PaletteChangeMenus.Name == "mnuNormal")
            {
                PaletteSet[0] = 1;
                mnuNormal.Checked = true;
            }
            else if (PaletteChangeMenus.Name == "mnuMorning")
            {
                PaletteSet[1] = 1;
                mnuMorning.Checked = true;
            }
            else if (PaletteChangeMenus.Name == "mnuAfternoon")
            {
                PaletteSet[2] = 1;
                mnuAfternoon.Checked = true;
            }
            else if (PaletteChangeMenus.Name == "mnuEvening")
            {
                PaletteSet[3] = 1;
                mnuEvening.Checked = true;
            }
            else if (PaletteChangeMenus.Name == "mnuNight")
            {
                PaletteSet[4] = 1;
                mnuNight.Checked = true;
            }
            else if (PaletteChangeMenus.Name == "mnuAuto")
            {
                PaletteSet[5] = 1;
                mnuAuto.Checked = true;
            }
         
        }

        private void mnuSave_Click(object sender, EventArgs e)
        {
            CurrentMap.MapSong = Convert.ToUInt16(txtSong.Text, HEX);
            CurrentMap.CaveBehaviour = (byte)cmbCaveBehaviour.SelectedIndex;
            CurrentMap.Weather = (byte)cmbWeather.SelectedIndex;
            CurrentMap.MapType = (byte)cmbType.SelectedIndex;
            CurrentMap.BattleStyle = (byte)cmbBattleStyle.SelectedIndex;

            if (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG")
            {
                CurrentMap.MapNameIndex = (byte)(cmbMapNames.SelectedIndex + 0x58);
                CurrentMap.FloorLevel = (sbyte)numFloorLevel.Value;
            }
            else
                CurrentMap.MapNameIndex = (byte)cmbMapNames.SelectedIndex;

            Maps.SaveMap(CurrentROM, CurrentMap); // Write changes to ROM

            treeMaps.Nodes[SelectedBank].Nodes[SelectedMap].Text = "Map " + SelectedMap.ToString() + " - " + Maps.MapNameList[cmbMapNames.SelectedIndex];
        }

        private void cmdChange_Click(object sender, EventArgs e)
        {
            uint[] TilesetNumber = new uint[2];

            try
            {
                TilesetNumber[0] = Convert.ToUInt32(txtMajor.Text, DEC);
                TilesetNumber[1] = Convert.ToUInt32(txtMinor.Text, DEC);
            }
            catch (OverflowException) // Catch overflow exception
            {
                if (TaskDialogSupported)
                    TaskDialog.Show(this, "The tileset number you have entered is invalid.\nThis is because the tileset number is either too big or too small.", "Overflow error - Invalid tileset number!", Application.ProductName, TaskDialogButtons.OK, TaskDialogIcon.Warning);
                else
                    MessageBox.Show("Overflow error - Invalid tileset number!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtMajor.Text = MajorTileset.Number.ToString(); // Default values
                txtMinor.Text = MinorTileset.Number.ToString();
                return;
            }

            for (int i = 0; i < 2; i++)
            {
                TilesetNumber[i] = (TilesetNumber[i] * 0x18) + CurrentROM.TilesetHeader;

                if (TilesetNumber[i] > 0xFFFFFF && CurrentROM.EnlargedROM == false)
                {
                    if (TaskDialogSupported)
                        TaskDialog.Show(this, "The tileset number you have entered is invalid.\nThis means it is pointing at a location that is beyond the size of this ROM.", "End of file error - Invalid tileset number!", Application.ProductName, TaskDialogButtons.OK, TaskDialogIcon.Warning);
                    else
                        MessageBox.Show("End of file error - Invalid tileset number!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtMajor.Text = MajorTileset.Number.ToString(); // Default values
                    txtMinor.Text = MinorTileset.Number.ToString();
                    return;
                }

                BinaryReader ReadROM = new BinaryReader(File.Open(CurrentROM.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));
                ReadROM.BaseStream.Position = TilesetNumber[i] + 2;

                ushort Filler = ReadROM.ReadUInt16();
                uint Image = ReadROM.ReadUInt32();
                uint Palette = ReadROM.ReadUInt32();
                uint Block = ReadROM.ReadUInt32();

                ReadROM.Close();

                if (Filler != 0 || Image < 0x8000000 || Palette < 0x8000000 || Block < 0x8000000) // Check if valid tileset
                {
                    if (TaskDialogSupported)
                        TaskDialog.Show(this, "The tileset number you have entered is invalid. This means at that location there are no tileset data to read from or the structure is incorrect.", "Error - Invalid tileset number!", Application.ProductName, TaskDialogButtons.OK, TaskDialogIcon.Warning);
                    else
                        MessageBox.Show("Error - Invalid tileset number!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    txtMajor.Text = MajorTileset.Number.ToString(); // Default values
                    txtMinor.Text = MinorTileset.Number.ToString();
                    return;
                }
            }

            BinaryWriter WriteROM = new BinaryWriter(File.Open(CurrentROM.FilePath, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite));

            WriteROM.BaseStream.Position = CurrentMap.LayoutData + 16 - 0x8000000; // Write to ROM
            WriteROM.Write(TilesetNumber[0] + 0x8000000);
            WriteROM.Write(TilesetNumber[1] + 0x8000000);
            WriteROM.Close();

            CurrentMap.MajorTileset = TilesetNumber[0] + 0x8000000; // Assign new tilesets to the current map
            CurrentMap.MinorTileset = TilesetNumber[1] + 0x8000000;

            MajorTileset = Tilesets.Load(CurrentROM, TilesetNumber[0], CurrentROM.TilesetHeader); // Load new tilesets
            MinorTileset = Tilesets.Load(CurrentROM, TilesetNumber[1], CurrentROM.TilesetHeader);

            DrawMap(); // Redraw map
        }

        private void cmbSong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSong.SelectedIndex == 0)
            {
                txtSong.Text = "0";
                return;
            }

            if (CurrentROM.GameCode.Substring(0, 3) == "AXV" || CurrentROM.GameCode.Substring(0, 3) == "AXP")
                txtSong.Text = Convert.ToString(cmbSong.SelectedIndex + 0x15D, HEX);
            else if (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG")
                txtSong.Text = Convert.ToString(cmbSong.SelectedIndex + 0xFF, HEX);
            else
                txtSong.Text = Convert.ToString(cmbSong.SelectedIndex + 0x15D, HEX);
        }

        private void txtSong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (CurrentROM.GameCode.Substring(0, 3) == "AXV" || CurrentROM.GameCode.Substring(0, 3) == "AXP")
                    cmbSong.SelectedIndex = Convert.ToUInt16(txtSong.Text, HEX) - 0x15D;
                else if (CurrentROM.GameCode.Substring(0, 3) == "BPR" || CurrentROM.GameCode.Substring(0, 3) == "BPG")
                    cmbSong.SelectedIndex = Convert.ToUInt16(txtSong.Text, HEX) - 0xFF;
                else
                    cmbSong.SelectedIndex = Convert.ToUInt16(txtSong.Text, HEX) - 0x15D;
            }
            catch
            {
                cmbSong.SelectedIndex = 0;
            }
        }

        private void cmbMapNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtMapName.Text = Maps.MapNameList[cmbMapNames.SelectedIndex];
        }

        private void mnuFreeSpaceFinder_Click(object sender, EventArgs e)
        {
            using (frmFreeSpaceFinder FreeSpaceFinder = new frmFreeSpaceFinder(CurrentROM, 0, 2, false, TaskDialogSupported))
                FreeSpaceFinder.ShowDialog();
        }

        private void cmdResize_Click(object sender, EventArgs e)
        {
            uint RepointOffset = 0;
            int Width = Convert.ToUInt16(txtWidth.Text, DEC);
            int Height = Convert.ToUInt16(txtHeight.Text, DEC);

            if (Width == CurrentMap.Width && Height == CurrentMap.Height)
                return;

            if (Width > CurrentMap.Width || Height > CurrentMap.Height) // Repoint necessary
            {
                using (frmFreeSpaceFinder FreeSpaceFinder = new frmFreeSpaceFinder(CurrentROM, Width * Height * 2, 2, true, TaskDialogSupported))
                {
                    FreeSpaceFinder.ShowDialog();
                    RepointOffset = FreeSpaceFinder.ReturnOffset;
                }

                if (RepointOffset == 0)
                {
                    txtWidth.Text = CurrentMap.Width.ToString();
                    txtHeight.Text = CurrentMap.Height.ToString();
                    return;
                }
            }

            Maps.Resize(CurrentROM, RepointOffset, Width, Height, CurrentMap);
            txtMapTileData.Text = Convert.ToString(CurrentMap.MapData, HEX);

            DrawMap(); // Redraw map
        }

        private void cmdResizeBorder_Click(object sender, EventArgs e)
        {
            uint RepointOffset = 0;
            int Width = Convert.ToUInt16(txtBorderWidth.Text, DEC);
            int Height = Convert.ToUInt16(txtBorderHeight.Text, DEC);

            if (Width == CurrentMap.BorderWidth && Height == CurrentMap.BorderHeight)
                return;

            if (Width > CurrentMap.BorderWidth || Height > CurrentMap.BorderHeight) // Repoint necessary
            {
                using (frmFreeSpaceFinder FreeSpaceFinder = new frmFreeSpaceFinder(CurrentROM, Width * Height * 2, 2, true, TaskDialogSupported))
                {
                    FreeSpaceFinder.ShowDialog();
                    RepointOffset = FreeSpaceFinder.ReturnOffset;
                }

                if (RepointOffset == 0)
                {
                    txtBorderWidth.Text = CurrentMap.Width.ToString();
                    txtBorderHeight.Text = CurrentMap.Height.ToString();
                    return;
                }
            }

            Maps.ResizeBorder(CurrentROM, RepointOffset, Width, Height, CurrentMap);
            txtBorderData.Text = Convert.ToString(CurrentMap.Border, HEX);

            BorderImage = new Bitmap(CurrentMap.BorderWidth * 16, CurrentMap.BorderHeight * 16); // Redraw border
            BorderGraphics = Graphics.FromImage(BorderImage);

            CurrentMap.BorderData = Maps.RenderBorder(CurrentROM, BorderGraphics, TilesetImage, CurrentMap);
            picBorder.Image = BorderImage;
        }

        private void SaveTileset_Click(object sender, EventArgs e)
        {
            Button SaveTilesetButton = (Button)sender;

            if (SaveTilesetButton.Name == "cmdSaveMajor")
            {
                MajorTileset.LZ77Compressed = (chkLZ771.Checked == true) ? (byte) 1 : (byte) 0;
                MajorTileset.MajorTileset = (chkMajorTileset1.Checked == true) ? (byte) 0 : (byte) 1;
                MajorTileset.Image = Convert.ToUInt32(txtImage1.Text, HEX);
                MajorTileset.Palette = Convert.ToUInt32(txtPalette1.Text, HEX);
                MajorTileset.BlockData = Convert.ToUInt32(txtBlocks1.Text, HEX);
                MajorTileset.BehaviourData = Convert.ToUInt32(txtBehaviours1.Text, HEX);
                MajorTileset.Animation = Convert.ToUInt32(txtAnimation1.Text, HEX);

                Tilesets.Save(CurrentROM, CurrentMap.MajorTileset - 0x8000000, MajorTileset);
            }
            else
            {
                MinorTileset.LZ77Compressed = (chkLZ772.Checked == true) ? (byte)1 : (byte)0;
                MinorTileset.MajorTileset = (chkMajorTileset2.Checked == true) ? (byte)0 : (byte)1;
                MinorTileset.Image = Convert.ToUInt32(txtImage2.Text, HEX);
                MinorTileset.Palette = Convert.ToUInt32(txtPalette2.Text, HEX);
                MinorTileset.BlockData = Convert.ToUInt32(txtBlocks2.Text, HEX);
                MinorTileset.BehaviourData = Convert.ToUInt32(txtBehaviours2.Text, HEX);
                MinorTileset.Animation = Convert.ToUInt32(txtAnimation2.Text, HEX);

                Tilesets.Save(CurrentROM, CurrentMap.MinorTileset - 0x8000000, MinorTileset);
            }

            // Refresh tileset and map
            DrawMap();
        }

        private void cmdHeader_Click(object sender, EventArgs e)
        {
            CurrentMap.LayoutData = Convert.ToUInt32(txtMapData.Text, HEX);
            CurrentMap.EventData = Convert.ToUInt32(txtEvents.Text, HEX);
            CurrentMap.MapScripts = Convert.ToUInt32(txtMapScripts.Text, HEX);
            CurrentMap.ConnectionData = Convert.ToUInt32(txtConnections.Text, HEX);

            CurrentMap.Border = Convert.ToUInt32(txtBorderData.Text, HEX);
            CurrentMap.MapData = Convert.ToUInt32(txtMapTileData.Text, HEX);
            CurrentMap.MajorTileset = Convert.ToUInt32(txtMajorTileset.Text, HEX);
            CurrentMap.MinorTileset = Convert.ToUInt32(txtMinorTileset.Text, HEX);

            Maps.SaveHeader(CurrentROM, CurrentMap);
            DrawMap(); // Reload map
        }

        private void cmdChangeName_Click(object sender, EventArgs e)
        {
            //uint RepointOffset;
            //int OldLength = Maps.MapNameList[cmbMapNames.SelectedIndex].Length;
            //int NewLength = txtMapName.Text.Length;

            //if (NewLength > OldLength)
            //{
            //    using (frmFreeSpaceFinder FreeSpaceFinder = new frmFreeSpaceFinder(CurrentROM, 18, 2, true, TaskDialogSupported))
            //    {
            //        FreeSpaceFinder.ShowDialog();
            //        RepointOffset = FreeSpaceFinder.ReturnOffset;
            //    }

            //    if (RepointOffset == 0)
            //        return;
            //}
        }

        private int GetPersonIndex(int x, int y)
        {
            for (int i = 0; i < CurrentMap.PersonCount; i++)
            {
                if (CurrentMap.People[i].X == x && CurrentMap.People[i].Y == y)
                    return i;
            }

            return -1;
        }

        private void SelectPerson(int index)
        {
            CurrentPerson = index;
            cmbEvents.SelectedIndex = 0;
            numEvents.Value = CurrentPerson;
            propEvents.SelectedObject = CurrentMap.People[index];
        }

        private void cmbEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            // To be coded
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            foreach (string file in Directory.GetFiles(Application.StartupPath + @"\Plugins"))
            {
                FileInfo pluginFile = new FileInfo(file);

                if (pluginFile.Extension.Equals(".dll"))
                {
                    ToolStripMenuItem pluginMenu = new ToolStripMenuItem();
                    pluginMenu.Text = "";

                    mnuPlugins.DropDownItems.Add(pluginMenu);
                }
            }
        }

    }
}
