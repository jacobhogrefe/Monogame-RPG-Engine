using System.Collections.Generic;
using System.Security.Cryptography;
using App.Scripts;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;

namespace App.Main
{
    public class MapEdgeTrigger : Trigger
    {
        protected Dictionary<Direction, Dictionary<string, int>> mapEdgeCalculations;

        public MapEdgeTrigger(Direction side, string destMapName)
            : base(0, 0, 0, 0, new SmartMapTeleportScript(side, destMapName))
        {
            mapEdgeCalculations = new Dictionary<Direction, Dictionary<string, int>>()
            {
                {
                    Direction.UP,
                    new Dictionary<string, int>()
                    {
                        { "x", 0 },
                        { "y", 0 },
                        { "width", map.WidthPixels },
                        { "height", 10 },
                    }
                },
                {
                    Direction.DOWN,
                    new Dictionary<string, int>()
                    {
                        { "x", 0 },
                        { "y", map.HeightPixels - 10 },
                        { "width", map.WidthPixels},
                        { "height", 10 },
                    }
                },
                {
                    Direction.LEFT,
                    new Dictionary<string, int>()
                    {
                        { "x", 0 },
                        { "y", 0 },
                        { "width", 10 },
                        { "height", map.HeightPixels },
                    }
                },
                {
                    Direction.RIGHT,
                    new Dictionary<string, int>()
                    {
                        { "x", map.WidthPixels - 10 },
                        { "y", 0 },
                        { "width", 10},
                        { "height", map.HeightPixels },
                    }
                },
            };
            Dictionary<string, int> rect = mapEdgeCalculations[side];
            Width = rect["width"];
            Height = rect["height"];
            Bounds = new Rectangle(rect["x"], rect["y"], Width, Height);
        }
    }
}
