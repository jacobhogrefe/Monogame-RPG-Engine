using App.Screens;
using Engine.Scene;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ScriptActions
{
    public class TeleportPlayerScriptAction : ScriptAction
    {
        protected new string map;
        protected float toX;
        protected float toY;

        public TeleportPlayerScriptAction(string map, float toX, float toY) {
          this.map = map;
          this.toX = toX;
          this.toY = toY;
        }
        public override ScriptState Execute()
        {
            PlayLevelScreen.Teleport(map, toX, toY);
            return ScriptState.COMPLETED;
        }
    }
}