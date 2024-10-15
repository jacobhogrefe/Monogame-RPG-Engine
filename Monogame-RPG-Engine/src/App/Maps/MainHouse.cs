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
using Microsoft.Xna.Framework.Media;

namespace App.Maps
{
    public class MainHouse : Map
    {
        public MainHouse(ContentLoader contentLoader)
            : base("homes/house.txt", new HouseTileset(contentLoader), contentLoader)
        {
            PlayerStartPosition = GetMapTile(10, 10).Location;
            Song = contentLoader.Load<Song>(SoundHelper.Songs.ARIA_MATH);
        }

        protected override void LoadScripts()
        {
            GetMapTile(8, 11).InteractScript = new MapTeleportScript("TEST_MAP", 825, 950);
        }
    }
}
