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
    public class MushroomMap : Map
    {
        public MushroomMap(ContentLoader contentLoader)
            : base("biomes/mushroom.txt", new MushroomTileset(contentLoader), contentLoader)
        {
          PlayerStartPosition = GetMapTile(8, 12).Location;
        }
    }
}