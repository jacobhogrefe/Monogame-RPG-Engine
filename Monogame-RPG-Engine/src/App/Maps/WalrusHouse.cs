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
    public class WalrusHouse : Map
    {

        public WalrusHouse(ContentLoader contentLoader)
            : base("homes/walrus.txt", new HouseTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(10, 8).Location;
            }

        protected override void LoadScripts()
        {
            GetMapTile(8, 11).InteractScript = new MapTeleportScript("TEST_MAP", 200, 1300);
        }
    }
}
