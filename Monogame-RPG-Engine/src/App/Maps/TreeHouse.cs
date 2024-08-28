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
    public class TreeHouse : Map
    {

        public TreeHouse(ContentLoader contentLoader)
            : base("homes/mountains.txt", new TreeHouseTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(10, 9).Location;
            }
    }
}
