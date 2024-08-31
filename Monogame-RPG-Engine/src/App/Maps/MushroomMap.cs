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
        public MushroomMap(ContentLoader contentLoader)
            : base("biomes/mushroom.txt", new MushroomTileset(contentLoader), contentLoader)
        {
            PlayerStartPosition = GetMapTile(8, 12).Location;
        }

        public override Dictionary<string, bool> LoadFlags()
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

        protected override void LoadScripts()
        {
            GetMapTile(15, 7).InteractScript = new MapTeleportScript("MUSHROOM_HOUSE", 208, 144);
            GetMapTile(12, 12).InteractScript = new SimpleTextScript(
                "Shiitake's garden of dancing mushrooms."
            );
            GetMapTile(17, 8).InteractScript = new SimpleTextScript("Shiitake's house");
        }
    }
}
