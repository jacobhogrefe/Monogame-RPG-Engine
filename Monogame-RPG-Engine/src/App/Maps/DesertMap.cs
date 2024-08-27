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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Maps
{
    public class DesertMap : Map
    {
        public DesertMap(ContentLoader contentLoader)
            : base("biomes/desert.txt", new DesertTileset(contentLoader), contentLoader)
        {
          PlayerStartPosition = GetMapTile(17, 20).Location;
        }
    }
}
