using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Core;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Audio;

namespace Engine.ScriptActions
{
    public class PlaySoundScriptAction : ScriptAction
    {
        protected SoundEffectInstance soundEffect;

        public PlaySoundScriptAction(string filePath, ContentLoader contentLoader)
        {
            try
            {
                soundEffect = contentLoader.Load<SoundEffectInstance>(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public override ScriptState Execute()
        {
            soundEffect.Play();
            return ScriptState.COMPLETED;
        }
    }
}
