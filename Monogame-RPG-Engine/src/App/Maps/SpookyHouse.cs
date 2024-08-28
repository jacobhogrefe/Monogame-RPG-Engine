using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Resources;
using App.Tilesets;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

namespace App.Maps
{
    public class SpookyHouse : Map
    {

        public SpookyHouse(ContentLoader contentLoader)
            : base("homes/spooky.txt", new SpookyHouseTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(9, 10).Location;
            }
    }
}
