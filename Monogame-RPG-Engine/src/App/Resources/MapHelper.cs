using System;
using System.Collections.Generic;
using System.Linq;
using App.Maps;
using Engine.Core;
using Engine.Scene;

namespace App.Resources
{
    public class MapHelper
    {
        protected Dictionary<string, Map> maps;

        public MapHelper(ContentLoader contentLoader)
        {
            maps = new Dictionary<string, Map>()
            {
                { "TEST_MAP", new TestMap(contentLoader) },
                { "MAIN_HOUSE", new MainHouse(contentLoader) },
                { "WALRUS_HOUSE", new WalrusHouse(contentLoader) },
                { "DINO_HOUSE", new DinoHouse(contentLoader) },
                { "DESERT", new DesertMap(contentLoader) },
                { "SALOON", new Saloon(contentLoader) },
                { "MOUNTAINS", new MountainMap(contentLoader) },
                { "TREE_HOUSE", new TreeHouse(contentLoader) },
                { "SPOOKY", new SpookyMap(contentLoader) },
                { "SPOOKY_HOUSE", new SpookyHouse(contentLoader) },
                { "MUSHROOM", new MushroomMap(contentLoader) },
                { "MUSHROOM_HOUSE", new MushroomHouse(contentLoader) },
            };
        }

        public Map GetMap(string mapName)
        {
            return maps[mapName];
        }

        public List<Map> GetMaps() {
            return maps.Values.ToList<Map>();
        }
    }
}
