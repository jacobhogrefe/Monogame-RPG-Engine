using Engine.Scene;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ScriptActions
{
    public class TeleportPlayerScriptAction : ScriptAction
    {
        protected new Map map;
        protected float toX;
        protected float toY;

        public TeleportPlayerScriptAction(Map map, float toX, float toY) {
          this.map = map;
          this.toX = toX;
          this.toY = toY;
        }
        public override ScriptState Execute()
        {
            player.SetMap(map);
            player.SetLocation(toX, toY);
            return ScriptState.COMPLETED;
        }
    }
}