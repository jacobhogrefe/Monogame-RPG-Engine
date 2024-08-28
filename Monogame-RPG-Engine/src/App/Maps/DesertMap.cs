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
    public class DesertMap : Map
    {
        public DesertMap(ContentLoader contentLoader, FlagManager flagManager)
            : base(
                "biomes/desert.txt",
                new DesertTileset(contentLoader),
                contentLoader,
                flagManager
            )
        {
            PlayerStartPosition = GetMapTile(17, 20).Location;
        }

        protected override Dictionary<string, bool> LoadFlags()
        {
            return new Dictionary<string, bool>
            {
                { "needsFindBucket", false },
                { "firstBartenderTalk", false },
                { "bucketFound", false },
                { "lassoFound", false },
                { "desertReward", false },
                { "desertDone", false },
            };
        }

        protected override List<NPC> LoadNPCs()
        {
            return new List<NPC>()
            {
                new Cattle(3, GetMapTile(10, 10).Location, ContentLoader),
                new RanchOwner(7, GetMapTile(5, 20).Location, ContentLoader)
                {
                    InteractScript = new OwnerScript(),
                },
            };
        }

        protected override void LoadScripts()
        {
            // enter house and saloon
            // GetMapTile(17, 25).InteractScript
            // GetMapTile(18, 25).InteractScript
        }
    }
}
