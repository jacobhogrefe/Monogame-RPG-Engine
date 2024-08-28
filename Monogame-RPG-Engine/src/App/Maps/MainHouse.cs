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
    public class MainHouse : Map
    {

        public MainHouse(ContentLoader contentLoader)
            : base("homes/house.txt", new HouseTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(10, 10).Location;
            }
    }
}
