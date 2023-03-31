using Gba.Core;
using PokemonMapEditor.Core.Models;

namespace PokemonMapEditor.Core.Services
{
    public interface IMapService
    {
        Map Load(ROM rom);
    }
}
