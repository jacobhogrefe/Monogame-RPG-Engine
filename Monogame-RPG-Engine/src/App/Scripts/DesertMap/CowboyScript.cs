using Engine.Scene;
using Engine.ScriptActions;
using Engine.ScriptActions.Conditional;
using System.Collections.Generic;

namespace App.Scripts
{
    public class CowboyScript : Script
    {
        public override List<ScriptAction> LoadScriptActions()
        {
            List<ScriptAction> scriptActions = new List<ScriptAction>();
            scriptActions.Add(new LockPlayerScriptAction());

            scriptActions.Add(new NPCFacePlayerScriptAction());

            scriptActions.Add(new UnlockPlayerScriptAction());
            return scriptActions;
        }
    }
}
