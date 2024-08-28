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
        
        // player(s)
        public static readonly string CAT = $"{pathPrefix}/Cat";

        // npcs
        public static readonly string DINOSAUR = $"{pathPrefix}/Dinosaur";
        public static readonly string WALRUS = $"{pathPrefix}/Walrus";
        public static readonly string BUG = $"{pathPrefix}/Bug";
        public static readonly string BARTENDER_WALRUS = $"{pathPrefix}/BartenderWalrus";
        public static readonly string CATTLE = $"{pathPrefix}/Cattle";
        public static readonly string CORALINE = $"{pathPrefix}/Coraline";
        public static readonly string COWBOY = $"{pathPrefix}/Cowboy";
        public static readonly string DOG = $"{pathPrefix}/Dog";
        public static readonly string MARIO = $"{pathPrefix}/Mario";
        public static readonly string MUSHROOM_MAN = $"{pathPrefix}/MushroomMan";
        public static readonly string RANCH_OWNER = $"{pathPrefix}/RanchOwner";

        //enhanced map tiles
        public static readonly string ROCK = $"{pathPrefix}/Rock";

        // tilesets
        public static readonly string COMMON_TILESET = $"{pathPrefix}/CommonTileset";
        public static readonly string DESERT_TILESET = $"{pathPrefix}/DesertTileset";
        public static readonly string MUSHROOM_TILESET = $"{pathPrefix}/MushroomTileset";
        public static readonly string MOUNTAIN_TILESET = $"{pathPrefix}/MountainsTileset";
        public static readonly string SPOOKY_TILESET = $"{pathPrefix}/SpookyTileset";
        public static readonly string HOUSE_TILESET = $"{pathPrefix}/HouseTileset";
        public static readonly string SALOON_TILESET = $"{pathPrefix}/SaloonTileset";
        public static readonly string TITLE_TILESET = $"{pathPrefix}/TitleTileset";
        public static readonly string TREE_HOUSE_TILESET = $"{pathPrefix}/TreeHouseTileset";
        public static readonly string MUSHROOM_HOUSE_TILESET = $"{pathPrefix}/MushroomHouseTileset";
        public static readonly string SPOOKY_HOUSE_TILESET = $"{pathPrefix}/SpookyHouseTileset";
    }
}
