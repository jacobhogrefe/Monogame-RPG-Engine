using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.EnhancedMapTiles;
using App.NPCs;
using App.Scripts;
using App.Tilesets;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Collections;

namespace App.Maps
{
    public class MountainMap : Map
    {
        public MountainMap(ContentLoader contentLoader, FlagManager flagManager)
            : base(
                "biomes/mountains.txt",
                new MountainTileset(contentLoader),
                contentLoader,
                flagManager
            )
        {
            PlayerStartPosition = GetMapTile(17, 29).Location;
        }

        protected override Dictionary<string, bool> LoadFlags()
        {
            return new Dictionary<string, bool>
            {
                { "removeItem", false },
                { "firstTalkToMario", false },
                { "searchForSwitch", true },
                { "foundSwitch", false },
                { "searchForRamen", true },
                { "foundRamen", false },
                { "searchForTerminal", true },
                { "foundTerminal", false },
                { "searchForYoshiCoin", true },
                { "foundYoshiCoin", false },
            };
        }

        protected override List<NPC> LoadNPCs()
        {
            List<NPC> npcs = new List<NPC>();
            Mario mario = new Mario(42, GetMapTile(19, 18).Location, ContentLoader)
            {
                InteractScript = new MarioScript(),
            };
            npcs.Add(mario);
            return npcs;
        }
    }
}
