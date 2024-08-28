using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Resources;
using Engine.Builders;
using Engine.Core;
using Engine.Entity;
using Engine.Extensions;
using Engine.Scene;
using Engine.Utils;
using Microsoft.Xna.Framework.Graphics;

namespace App.NPCs
{
    public class Mario : NPC
    {
        public Mario(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.MARIO), 17, 28),
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
                        new FrameBuilder(spriteSheet.GetSprite(1, 0))
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
                            .Build(),
                    }
                },
                {
                    "WALK_LEFT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(1, 1), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(1, 2), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
                {
                    "WALK_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 1), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                        new FrameBuilder(spriteSheet.GetSprite(0, 2), 200)
                            .WithScale(3)
                            .WithBounds(5, 5, 7, 17)
                            .Build(),
                    }
                },
            };
        }
    }
}
