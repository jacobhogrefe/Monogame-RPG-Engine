using Engine.Scene;
using Engine.ScriptActions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Scripts
{
    public class LostBallScript : Script
    {
        public override List<ScriptAction> LoadScriptActions()
        {
            return new List<ScriptAction>
            {
                new LockPlayerScriptAction(),
                new TextboxScriptAction(new string [] {
                    "Where did my ball go!?",
                    "I left it right here before I took my 22 hour cat nap.",
                    "Maybe Walrus has seen it."}),
                new ChangeFlagScriptAction("hasLostBall", true),
                new UnlockPlayerScriptAction()
            };
        }
    }
}
