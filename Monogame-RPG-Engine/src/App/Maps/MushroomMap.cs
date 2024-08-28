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
    public class MushroomMap : Map
    {
        public MushroomMap(ContentLoader contentLoader, FlagManager flagManager)
            : base(
                "biomes/mushroom.txt",
                new MushroomTileset(contentLoader),
                contentLoader,
                flagManager
            )
        {
            PlayerStartPosition = GetMapTile(8, 12).Location;
        }

        protected override Dictionary<string, bool> LoadFlags()
        {
            return new Dictionary<string, bool>
            {
                { "hasTalkedToShittake", false },
                { "petDoesntExist", true },
                { "dogsPresent", false },
                { "hasTalkedToDog", false },
            };
        }

        protected override List<NPC> LoadNPCs()
        {
            return new List<NPC>()
            {
                new Dog(1, GetMapTile(5, 5).Location.SubtractY(40), ContentLoader)
                {
                    InteractScript = new DogScript(),
                },
            };
        }
    }
}
