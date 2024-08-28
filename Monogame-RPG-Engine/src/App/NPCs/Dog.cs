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
    public class Dog : NPC
    {
        public Dog(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.DOG), 40, 40),
                "STAND_LEFT"
            ) { }

        public override Dictionary<string, Frame[]> LoadAnimations(SpriteSheet spriteSheet)
        {
            return new Dictionary<string, Frame[]>()
            {
                {
                    "STAND_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(1)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
                {
                    "STAND_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(1)
                            .WithBounds(5, 5, 7, 17)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                    }
                },
                {
                    "WALK_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0), 200)
                            .WithScale(1)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(0, 0), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
                {
                    "WALK_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0), 200)
                            .WithScale(1)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(0, 0), 200)
                            .WithScale(1)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
            };
        }
    }
}
