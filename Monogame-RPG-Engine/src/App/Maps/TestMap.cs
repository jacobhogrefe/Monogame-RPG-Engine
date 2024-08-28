using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.EnhancedMapTiles;
using App.NPCs;
using App.Scripts;
using App.Tilesets;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;
using MonoGame.Extended.Collections;

namespace App.Maps
{
    public class TestMap : Map
    {
        public TestMap(ContentLoader contentLoader, FlagManager flagManager)
            : base("test_map.txt", new CommonTileset(contentLoader), contentLoader, flagManager)
        {
            PlayerStartPosition = GetMapTile(17, 20).Location;
        }

        protected override List<EnhancedMapTile> LoadEnhancedMapTiles()
        {
            return new List<EnhancedMapTile>()
            {
                new PushableRock(GetMapTile(2, 7).Location, ContentLoader),
            };
        }

        protected override Dictionary<string, bool> LoadFlags()
        {
            return new Dictionary<string, bool>()
            {
                { "hasLostBall", false },
                { "hasTalkedToWalrus", false },
                { "hasTalkedToDinosaur", false },
                { "hasFoundBall", false },
            };
        }

        protected override List<NPC> LoadNPCs()
        {
            List<NPC> npcs = new List<NPC>();

            Walrus walrus = new Walrus(1, GetMapTile(4, 28).Location.SubtractY(40), ContentLoader);
            walrus.InteractScript = new WalrusScript();
            npcs.Add(walrus);

            Dinosaur dinosaur = new Dinosaur(2, GetMapTile(13, 4).Location, ContentLoader);
            dinosaur.ExistenceFlag = "hasTalkedToDinosaur";
            dinosaur.InteractScript = new DinoScript();
            npcs.Add(dinosaur);

            Bug bug = new Bug(3, GetMapTile(7, 12).Location.SubtractX(20), ContentLoader);
            bug.InteractScript = new BugScript();
            npcs.Add(bug);

            return npcs;
        }

        protected override List<Trigger> LoadTriggers()
        {
            return new List<Trigger>()
            {
                new Trigger(790, 1030, 100, 10, new LostBallScript(), "hasLostBall"),
                new Trigger(790, 960, 10, 80, new LostBallScript(), "hasLostBall"),
                new Trigger(890, 960, 10, 80, new LostBallScript(), "hasLostBall"),
            };
        }

        protected override void LoadScripts()
        {
            GetMapTile(21, 19).InteractScript = new SimpleTextScript("Cat's house");

            GetMapTile(7, 26).InteractScript = new SimpleTextScript("Walrus's house");

            GetMapTile(20, 4).InteractScript = new SimpleTextScript("Dino's house");

            GetMapTile(2, 6).InteractScript = new TreeScript();
        }
    }
}
