using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class RanchOwner : NPC
    {
        public RanchOwner(int id, Point location, ContentLoader contentLoader)
            : base(
                id,
                location.X,
                location.Y,
                new SpriteSheet(contentLoader.LoadTexture(GraphicsHelper.RANCH_OWNER), 33, 41),
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
                            .WithScale(2)
                            .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                            .WithBounds(8, 10, 8, 25)
                            .Build(),
                    }
                },
                {
                    "STAND_RIGHT",
                    new Frame[]
                    {
                        new FrameBuilder(spriteSheet.GetSprite(0, 0))
                            .WithScale(2)
                            .WithBounds(8, 10, 8, 25)
                            .Build(),
                    }
                },
            };
        }
    }
}
