using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        protected SoundEffect soundEffect;
        protected string filePath;
        protected ContentLoader contentLoader;

        public PlaySoundScriptAction(string filePath, ContentLoader contentLoader)
        {
            this.contentLoader = contentLoader;
            this.filePath = filePath;
        }

        public override void Setup()
        {
            try
            {
                soundEffect = contentLoader.Load<SoundEffect>(filePath);
            }
            catch (Exception e)
            {
                Console.WriteLine($"ERROR LOADING SOUND EFFECT: {e.Message}");
             }

        }

        public override ScriptState Execute()
        {
            soundEffect.Play();
            return ScriptState.COMPLETED;
        }
    }
}
