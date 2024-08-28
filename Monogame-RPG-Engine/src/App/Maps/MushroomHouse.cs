using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.NPCs;
using App.Resources;
using App.Scripts;
using App.Tilesets;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

namespace App.Maps
{
    public class MushroomHouse : Map
    {

        public MushroomHouse(ContentLoader contentLoader)
            : base("homes/mushroom.txt", new MushroomHouseTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(8, 10).Location;
            }

        protected override List<NPC> LoadNPCs()
        {
            return new List<NPC>() {
                new MushroomMan(1, GetMapTile(8, 7).Location.SubtractY(40), ContentLoader)
                {
                    InteractScript = new MushroomManScript()
                },
            };
        }
    }
}
