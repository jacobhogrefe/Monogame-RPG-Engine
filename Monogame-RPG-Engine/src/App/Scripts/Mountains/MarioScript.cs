using Engine.Scene;
using Engine.ScriptActions;
using Engine.ScriptActions.Conditional;
using System.Collections.Generic;

namespace App.Scripts
{
    public class MarioScript : Script
    {
        public override List<ScriptAction> LoadScriptActions()
        {
            return new List<ScriptAction>()
            {
                new LockPlayerScriptAction(),
                new NPCFacePlayerScriptAction(),
                new UnlockPlayerScriptAction(),
            };
        }
    }
}
