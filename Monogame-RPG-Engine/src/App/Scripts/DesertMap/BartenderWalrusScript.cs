using System.Collections.Generic;
using Engine.Scene;
using Engine.ScriptActions;
using Engine.ScriptActions.Conditional;

namespace App.Scripts
{
    public class BartenderWalrusScript : Script
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
