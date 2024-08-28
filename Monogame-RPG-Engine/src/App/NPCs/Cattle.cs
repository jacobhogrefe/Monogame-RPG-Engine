using System.Collections.Generic;
using App.Resources;
using Engine.Builders;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

// This class is for the dinosaur NPC
namespace App.NPCs
{
    public class Cattle : NPC
    {
        public Cattle(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.CATTLE), 29, 29),
                "STAND_RIGHT"
            ) { }

        public override Dictionary<string, Frame[]> LoadAnimations(SpriteSheet spriteSheet)
        {
            return new Dictionary<string, Frame[]>()
            {
                {
                    "STAND_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                    }
                },
                {
                    "STAND_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                    }
                },
                {
                    "WALK_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), 200)
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), 200)
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), 200)
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 2), 200)
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                    }
                },
                {
                    "WALK_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), 200)
                            .WithScale(4)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), 200)
                            .WithScale(4)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), 200)
                            .WithScale(4)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 2), 200)
                            .WithScale(4)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                    }
                },
                {
                    "EAT_GRASS",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 1), 200)
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(0, 2), 200)
                            .WithScale(4)
                            .WithBounds(4, 5, 25, 25)
                            .Build(),
                    }
                },
            };
        }
    }
}
