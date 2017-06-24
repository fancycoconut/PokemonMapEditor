using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PokemonMapEditor
{
    public partial class frmFreeSpaceFinder : Form
    {
        private ROM CurrentROM;

        private const int HEX = 16;

        private bool Repoint;
        public uint ReturnOffset;
        private bool TaskDialogSupported;

        public frmFreeSpaceFinder(ROM game, int size, int skip, bool repoint, bool taskdialogsupport)
        {
            InitializeComponent();

            CurrentROM = game;
            Repoint = repoint;
            numSize.Value = size;
            numSkip.Value = skip;
            TaskDialogSupported = taskdialogsupport;
        }

        private void frmFreeSpaceFinder_Load(object sender, EventArgs e)
        {
            if (Repoint == false)
                this.Height = 214;

            if (String.IsNullOrEmpty(CurrentROM.FilePath))
                cmdFind.Enabled = false;

            txtStartOffset.Text = "6B0000";
            txtFreeSpaceByte.Text = "FF";

            if (CurrentROM.EnlargedROM)
            {
                txtOffset.MaxLength = 7;
                txtStartOffset.MaxLength = 7;
            }
            else
            {
                txtOffset.MaxLength = 6;
                txtStartOffset.MaxLength = 6;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            ReturnOffset = 0;
            this.Close();
        }

        private void cmdFind_Click(object sender, EventArgs e)
        {
            int Skip = (int)numSkip.Value;
            int FreeSpaceNeeded = (int)numSize.Value;
            uint StartOffset = Convert.ToUInt32(txtStartOffset.Text, HEX);
            byte FreeSpaceValue = Convert.ToByte(txtFreeSpaceByte.Text, HEX);

            lstOffsets.Items.Clear();
            for (int j = 0; j < 5; j++)
            {
                uint Offset = CurrentROM.Search(StartOffset, FreeSpaceNeeded + Skip, FreeSpaceValue, 0x10000);
                if (Offset == 0)
                {
                    if (TaskDialogSupported)
                        TaskDialog.Show(this, "Free space cannot be found at the offset. This is due to a lack of free space in the ROM. Please try another offset.", "Error - Can't find enough free space.", Application.ProductName, TaskDialogButtons.OK, TaskDialogIcon.Stop);
                    else
                        MessageBox.Show("Error - Can't find enough free space.\nPlease try another offset.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lstOffsets.Items.Add(Convert.ToString(Offset, HEX).ToUpper());
                StartOffset = (uint)(Offset + FreeSpaceNeeded + Skip);
            }
           
        }

        private void lstOffsets_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetText(lstOffsets.SelectedItem.ToString());

            if (Repoint)
                txtOffset.Text = lstOffsets.SelectedItem.ToString();
        }

        private void cmdRepoint_Click(object sender, EventArgs e)
        {
            ReturnOffset = Convert.ToUInt32(txtOffset.Text, HEX);
            this.Close();
        }
    }
}
