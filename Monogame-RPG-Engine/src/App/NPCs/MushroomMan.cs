using System.Collections.Generic;
using App.Resources;
using Engine.Builders;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

namespace App.NPCs
{
    public class MushroomMan : NPC
    {
        public MushroomMan(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.MUSHROOM_MAN), 13, 27),
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
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
                {
                    "STAND_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .Build(),
                    }
                },
                {
                    "WALK_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
                {
                    "WALK_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(1, 0), 200)
                            .WithScale(3)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), 200)
                            .WithScale(3)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                }
            };
        }
    }
}
