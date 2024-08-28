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
    public class SpookyMap : Map
    {
        public SpookyMap(ContentLoader contentLoader, FlagManager flagManager)
            : base(
                "biomes/spooky.txt",
                new SpookyTileset(contentLoader),
                contentLoader,
                flagManager
            )
        {
            PlayerStartPosition = GetMapTile(8, 12).Location;
        }

        protected override Dictionary<string, bool> LoadFlags()
        {
            return new Dictionary<string, bool>()
            {
                { "FoundtheLostEyes", false },
                { "Searchlosteyes", false },
                { "firstTalktoCoraline", false },
                { "removeitem", false },
            };
        }

        protected override List<NPC> LoadNPCs()
        {
            return new List<NPC>()
            {
                new Coraline(1, GetMapTile(10, 8).Location, ContentLoader)
                {
                    InteractScript = new CoralineScript(),
                },
            };
        }

        protected override void LoadScripts()
        {
            // enter castle
            // GetMapTile(6, 5).InteractScript
        }
    }
}
