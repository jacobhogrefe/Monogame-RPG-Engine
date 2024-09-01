using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using App.Screens;
using Engine.Builders;
using Engine.Entity;
using Engine.Scene;
using Engine.ScriptActions;
using Engine.ScriptActions.Conditional;
using Engine.Utils;

namespace App.Scripts
{
    public class SmartMapTeleportScript : Script
    {
        protected new string map;
        protected Map mapRef;
        protected Direction direction;

        public SmartMapTeleportScript(Direction direction, string map)
        {
            this.map = map;
            this.direction = direction;
        }

        protected float GetToX()
        {
            if (direction.ParallelToXAxis())
            {
                // How far along the X axis has the player traveled?
                double traveledFraction = player.Location.X / mapRef.WidthPixels;

                // Where does this fraction land on the new map?
                return (float)(mapRef.WidthPixels * traveledFraction);
            }
            else
            {
                // either left or right border
                if (direction == Direction.LEFT)
                {
                    // we'll pop out on the right on the other map
                    return mapRef.WidthPixels - player.Width;
                }
                else
                { // right side
                    return 0.0f;
                }
            }
        }

        protected float GetToY()
        {
            if (direction.ParallelToYAxis())
            {
                // How far along the Y axis has the player traveled?
                double traveledFraction = player.Location.Y / mapRef.HeightPixels;

                // Where does this fraction land on the new map?
                return (float)(mapRef.HeightPixels * traveledFraction);
            }
            else
            {
                // either top or bottom border
                if (direction == Direction.UP)
                {
                    // we'll pop out on the bottom on the other map
                    return mapRef.HeightPixels - player.Height;
                }
                else
                { // bottom side
                    return 0.0f;
                }
            }
        }

        public override List<ScriptAction> LoadScriptActions()
        {
            return new List<ScriptAction>()
            {
                new DynamicScriptAction(() =>
                {
                    mapRef = PlayLevelScreen.mapHelper.GetMap(map);
                    PlayLevelScreen.Teleport(map, GetToX(), GetToY());
                    return ScriptState.COMPLETED;
                }),
            };
        }
    }
}
