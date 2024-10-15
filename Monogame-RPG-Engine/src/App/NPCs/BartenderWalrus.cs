using System.Collections.Generic;
using App.Resources;
using Engine.Builders;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

// This class is for the walrus NPC
namespace App.NPCs
{
    public class BartenderWalrus : NPC
    {
        public BartenderWalrus(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.BARTENDER_WALRUS), 24, 24),
                "STAND_RIGHT"
            ) { }

        public override Dictionary<string, Frame[]> LoadAnimations(SpriteSheet spriteSheet)
        {
            int idleSpeed = 40;
            return new Dictionary<string, Frame[]>()
            {
                {
                    "STAND_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                    }
                },
                {
                    "STAND_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), idleSpeed)
                            .WithScale(3)
                            .WithBounds(7, 13, 11, 7)
                            .Build(),
                    }
                },
            };
        }
    }
}