using Engine.Scene;
using Engine.ScriptActions;
using Engine.ScriptActions.Conditional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Scripts
{
    public class DogScript : Script
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
