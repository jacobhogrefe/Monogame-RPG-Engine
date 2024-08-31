using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class DinoHouse : Map
    {

        public DinoHouse(ContentLoader contentLoader)
            : base("homes/dino.txt", new HouseTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(11, 9).Location;
            }

        protected override void LoadScripts()
        {
            // leave house
            GetMapTile(8, 11).InteractScript = new MapTeleportScript("TEST_MAP", 800, 220);
        }
    }
}
