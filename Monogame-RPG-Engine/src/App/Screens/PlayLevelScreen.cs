using App.Main;
using App.Maps;
using App.Players;
using App.Resources;
using Engine.Core;
using Engine.FontGraphics;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// This class is for the win level screen
namespace App.Screens
{
    public class PlayLevelScreen : Screen
    {
        protected ScreenCoordinator screenCoordinator;
        protected static Map map;
        protected static Player player;
        protected FlagManager flagManager;
        protected PlayLevelScreenStates PlayLevelScreenState { get; private set; }
        protected WinScreen winScreen;
        protected static MapHelper mapHelper = new MapHelper(GlobalContentLoader);

        public PlayLevelScreen(ScreenCoordinator screenCoordinator)
        {
            this.screenCoordinator = screenCoordinator;
        }

        public override void Initialize()
        {
            // global flags go here
            flagManager = new FlagManager();

            // load all flags into flagManager
            foreach (Map map in mapHelper.GetMaps()) {
                flagManager.AddFlags(map.LoadFlags());
            }

            // define/setup map
            map = mapHelper.GetMap("TEST_MAP");
            map.FlagManager = flagManager;
            Console.WriteLine(map.FlagManager.ToString());

            // setup player
            player = new Cat(map.PlayerStartPosition.X, map.PlayerStartPosition.Y, ContentLoader);
            player.SetMap(map);
            PlayLevelScreenState = PlayLevelScreenStates.RUNNING;
            player.FacingDirection = Direction.LEFT;

            map.Player = player;

            // let pieces of map know which button to listen for as the "interact" button
            map.Textbox.InteractKey = player.INTERACT_KEY;

            // preloads all scripts ahead of time rather than loading them dynamically
            // both are supported, however preloading is recommended
            map.PreloadScripts();

            winScreen = new WinScreen(this);
            winScreen.Initialize();
        }

        public override void Update(GameTime gameTime, KeyboardState keyboardState)
        {
            // based on screen state, perform specific actions
            switch (PlayLevelScreenState)
            {
                // if level is "running" update player and map to keep game logic for the platformer level going
                case PlayLevelScreenStates.RUNNING:
                    player.Update(keyboardState);
                    map.Update(keyboardState);
                    break;
                // if level has been completed, bring up level cleared screen
                case PlayLevelScreenStates.LEVEL_COMPLETED:
                    winScreen.Update(gameTime, keyboardState);
                    break;
            }

            // if flag is set at any point during gameplay, game is "won"
            // if (map.FlagManager.IsFlagSet("hasFoundBall"))
            // {
            //     PlayLevelScreenState = PlayLevelScreenStates.LEVEL_COMPLETED;
            // }
        }

        public override void Draw(GraphicsHandler graphicsHandler)
        {
            // based on screen state, draw appropriate graphics
            switch (PlayLevelScreenState)
            {
                case PlayLevelScreenStates.RUNNING:
                    map.Draw(player, graphicsHandler);
                    break;
                case PlayLevelScreenStates.LEVEL_COMPLETED:
                    winScreen.Draw(graphicsHandler);
                    break;
            }
        }

        public void ResetLevel()
        {
            Initialize();
            LoadContent();
        }

        public void GoBackToMenu()
        {
            screenCoordinator.GameState = GameState.MENU;

        }

        // This enum represents the different states this screen can be in
        public enum PlayLevelScreenStates
        {
            RUNNING, LEVEL_COMPLETED
        }

        public static void Teleport(string map, float toX, float toY) {
            Map destMap = mapHelper.GetMap(map);
            destMap.FlagManager = PlayLevelScreen.map.FlagManager;
            destMap.Textbox.InteractKey = player.INTERACT_KEY;
            destMap.Player = player;
            player.SetMap(destMap);
            player.SetLocation(toX, toY);
            destMap.PreloadScripts();
            PlayLevelScreen.map = destMap;
        }
    }
}
