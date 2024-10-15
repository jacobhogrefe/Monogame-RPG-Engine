using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.EnhancedMapTiles;
using App.NPCs;
using App.Resources;
using App.Scripts;
using App.Tilesets;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using MonoGame.Extended.Collections;

namespace App.Maps
{
    public class MountainMap : Map
    {
        public MountainMap(ContentLoader contentLoader)
            : base("biomes/mountains.txt", new MountainTileset(contentLoader), contentLoader)
        {
            PlayerStartPosition = GetMapTile(17, 29).Location;
            Song = contentLoader.Load<Song>(SoundHelper.Songs.MOUNTAINS);
        }

        public override Dictionary<string, bool> LoadFlags()
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
            return new List<NPC>()
            {
                new Mario(42, GetMapTile(19, 18).Location, ContentLoader)
                {
                    InteractScript = new MarioScript(),
                },
            };
        }

        protected override void LoadScripts()
        {
            // enter house
            GetMapTile(5,23).InteractScript = new MapTeleportScript("TREE_HOUSE", 144, 432);
        }

        protected override List<Trigger> LoadTriggers()
        {
            return new List<Trigger>()
            {
                new Trigger(0, 0, 10, HeightPixels, new SmartMapTeleportScript(Direction.LEFT, "SPOOKY")),
                new Trigger(0, HeightPixels - 10, WidthPixels, 10, new SmartMapTeleportScript(Direction.DOWN, "DESERT"))
            };
        }
    }
}
