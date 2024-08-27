using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Resources
{
    // paths to necessary graphics
    public static class GraphicsHelper
    {
        private static readonly string pathPrefix = "Graphics";
        
        // npcs, player, etc.
        public static readonly string BUG = $"{pathPrefix}/Bug";
        public static readonly string CAT = $"{pathPrefix}/Cat";
        public static readonly string DINOSAUR = $"{pathPrefix}/Dinosaur";
        public static readonly string ROCK = $"{pathPrefix}/Rock";
        public static readonly string WALRUS = $"{pathPrefix}/Walrus";

        // tilesets
        public static readonly string COMMON_TILESET = $"{pathPrefix}/CommonTileset";
        public static readonly string DESERT_TILESET = $"{pathPrefix}/DesertTileset";
        public static readonly string MUSHROOM_TILESET = $"{pathPrefix}/MushroomTileset";
        public static readonly string MOUNTAIN_TILESET = $"{pathPrefix}/mountainsTextures";
        public static readonly string SPOOKY_TILESET = $"{pathPrefix}/SpookyTileset";
    }
}
