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
    public class MountainMap : Map
    {
        public MountainMap(ContentLoader contentLoader)
            : base("biomes/mountains.txt", new MountainTileset(contentLoader), contentLoader)
        {
          PlayerStartPosition = GetMapTile(17, 29).Location;
        }
    }
}