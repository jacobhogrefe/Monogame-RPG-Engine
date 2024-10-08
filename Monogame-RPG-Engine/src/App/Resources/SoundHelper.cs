using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Resources
{
    // paths to necessary graphics
    public static class SoundHelper
    {
        private static readonly string pathPrefix = "Audio";
        public static readonly string ARIA_MATH = $"{pathPrefix}/ariaMath";
        public static readonly string SPOOKY = $"{pathPrefix}/BiomeSpookymusic";
        public static readonly string TEST_MAP = $"{pathPrefix}/BiomeStart";
        public static readonly string BLAKE_AUDIO = $"{pathPrefix}/BlakeAudio";
        public static readonly string BLUE_MOON = $"{pathPrefix}/BlueMoon";
        public static readonly string COLLECTIBLE = $"{pathPrefix}/Collectible";
        public static readonly string GHOST_RIDERS = $"{pathPrefix}/GhostRiders";
        public static readonly string HIPPIES_AND_COWBOYS = $"{pathPrefix}/HippiesAndCowboys";
        public static readonly string KEY_COLLECTIBLE = $"{pathPrefix}/keyCollectible";
        public static readonly string MOUNTAINS = $"{pathPrefix}/mountainsBiome";
        public static readonly string MUSHROOM = $"{pathPrefix}/mushroom";
        public static readonly string MUSHROOM_HOME = $"{pathPrefix}/mushroomHome";
        public static readonly string WALKING_SAND = $"{pathPrefix}/sandWalking";
        public static readonly string STEAM_GARDENS = $"{pathPrefix}/steamGardens";
        public static readonly string WALKING_GRASS = $"{pathPrefix}/walkingGrass";
        public static readonly string WALKING_SOUND = $"{pathPrefix}/walkingSound";
        public static readonly string WALKING_STONE = $"{pathPrefix}/walkingStone";
        public static readonly string WALKING_WOOD = $"{pathPrefix}/walkingWood";
    }
}
