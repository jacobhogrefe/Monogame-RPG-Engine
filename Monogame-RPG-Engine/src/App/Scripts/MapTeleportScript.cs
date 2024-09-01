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
    public class MapTeleportScript : Script
    {
        protected new string map;
        protected float toX;
        protected float toY;

        public MapTeleportScript(string map, float toX, float toY)
        {
            this.map = map;
            this.toX = toX;
            this.toY = toY;
        }

        public MapTeleportScript(string map) {
            this.map = map;
            toX = 0;
            toY = 0;
        }

        public override List<ScriptAction> LoadScriptActions()
        {
            return new List<ScriptAction>
            {
                new DynamicScriptAction(() =>
                {
                    PlayLevelScreen.Teleport(map, toX, toY);
                    return ScriptState.COMPLETED;
                }),
            };
        }
    }
}
