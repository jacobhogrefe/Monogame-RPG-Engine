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
    public class Cowboy : NPC
    {
        public Cowboy(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.COWBOY), 42, 42),
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
                            .WithBounds(10, 17, 11, 7)
                            .WithSpriteEffect(SpriteEffects.FlipVertically)
                            .Build(),
                    }
                },
                {
                    "STAND_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(3)
                            .WithBounds(10, 17, 11, 7)
                            .WithSpriteEffect(SpriteEffects.FlipVertically)
                            .Build(),
                    }
                },
            };
        }
    }
}
