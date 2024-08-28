using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.NPCs;
using App.Resources;
using App.Scripts;
using App.Tilesets;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

namespace App.Maps
{
    public class Saloon : Map
    {

        public Saloon(ContentLoader contentLoader)
            : base("homes/saloon.txt", new SaloonTileset(contentLoader), contentLoader) {
                PlayerStartPosition = GetMapTile(10, 11).Location;
            }

        protected override List<NPC> LoadNPCs()
        {
            return new List<NPC>() {
                new BartenderWalrus(7, GetMapTile(4, 3).Location, ContentLoader)
                {
                    InteractScript = new BartenderWalrusScript()
                },
                new Cowboy(6, GetMapTile(4, 7).Location, ContentLoader)
                {
                    InteractScript = new CowboyScript()
                }
            };
        }

        protected override void LoadScripts()
        {
            // leave saloon
            // GetMapTile(7, 11).InteractScript
    	    // GetMapTile(8, 11).InteractScript
        }
    }
}
