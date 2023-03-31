using Gba.Core;
using PokemonMapEditor.Core.Configuration;
using System;
using System.Windows.Forms;

namespace PokemonMapEditor.Forms
{
    public partial class Main : Form
    {
        private ROM currentROM;

        public Main(SupportedROMsConfiguration config)
        {
            InitializeComponent();
        }

        private void OpenROMMenuItem_Click(object sender, EventArgs e)
        {
            using var dialog = new OpenFileDialog
            {
                Title = "Open ROM...",
                Filter = "Gameboy Advance ROMs (.*.agb;*.bin;*.gba)|*.agb;*.bin;*.gba",
                DefaultExt = "gba"
            };

            var result = dialog.ShowDialog();
            if (result != DialogResult.OK) return;

            currentROM = ROM.Load(dialog.FileName);
        }

        private void SaveROMMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ExitAppMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
