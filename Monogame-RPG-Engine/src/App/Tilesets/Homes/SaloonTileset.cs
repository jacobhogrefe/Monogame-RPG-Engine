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
using Microsoft.Xna.Framework.Graphics;

namespace App.Tilesets
{
    public class SaloonTileset : Tileset
    {
        public SaloonTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.SALOON_TILESET), 16, 16, 3) { }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
            // floor 1
            Frame floorFrame = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();

            MapTileBuilder floorTile = new MapTileBuilder(floorFrame);

            mapTiles.Add(floorTile);

            // cactus stem 1
            Frame cactusStem1Frame = new FrameBuilder(GetSubImage(2, 1))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder cactusStem1Tile = new MapTileBuilder(cactusStem1Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(cactusStem1Tile);

            // cactus stem 2
            Frame cactusStem2Frame = new FrameBuilder(GetSubImage(2, 2))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder cactusStem2Tile = new MapTileBuilder(floorFrame)
                .WithTopLayer(cactusStem2Frame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(cactusStem2Tile);

            // live veGetation
            Frame liveVegatationFrame = new FrameBuilder(GetSubImage(1, 3))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder liveVegatationTile = new MapTileBuilder(
                liveVegatationFrame
            ).WithTileType(TileType.PASSABLE);

            mapTiles.Add(liveVegatationTile);

            // dead veGetation
            Frame deadVegatationFrame = new FrameBuilder(GetSubImage(2, 3))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder deadVegatationTile = new MapTileBuilder(
                deadVegatationFrame
            ).WithTileType(TileType.PASSABLE);

            mapTiles.Add(deadVegatationTile);

            // Fence horizontal

            Frame fenceHFrame = new FrameBuilder(GetSubImage(4, 2)).WithScale(TileScale).Build();

            MapTileBuilder fenceHTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(fenceHFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(fenceHTile);

            // fence upper left corner

            Frame fenceUpLFrame = new FrameBuilder(GetSubImage(4, 1)).WithScale(TileScale).Build();

            MapTileBuilder fenceUpLTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(fenceUpLFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(fenceUpLTile);

            // fence upper right corner

            Frame fenceUpRFrame = new FrameBuilder(GetSubImage(4, 1))
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .WithScale(TileScale)
                .Build();

            MapTileBuilder fenceUpRTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(fenceUpRFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(fenceUpRTile);

            // fence bottom left corner

            Frame fenceBotLFrame = new FrameBuilder(GetSubImage(4, 0)).WithScale(TileScale).Build();

            MapTileBuilder fenceBotLTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(fenceBotLFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(fenceBotLTile);

            // fence bottom right corner

            Frame fenceBotRFrame = new FrameBuilder(GetSubImage(4, 0))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .Build();

            MapTileBuilder fenceBotRTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(fenceBotRFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(fenceBotRTile);

            // fence vertical

            Frame fenceVFrame = new FrameBuilder(GetSubImage(3, 3)).WithScale(TileScale).Build();

            MapTileBuilder fenceVTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(fenceVFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(fenceVTile);

            // cactus With branch
            Frame branchFrame = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();

            MapTileBuilder branchTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(branchFrame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(branchTile);

            // cactus With branch 2
            Frame branch2Frame = new FrameBuilder(GetSubImage(0, 2)).WithScale(TileScale).Build();

            MapTileBuilder branch2Tile = new MapTileBuilder(floorFrame)
                .WithTopLayer(branch2Frame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(branch2Tile);

            // branch left
            Frame branchLeftFrame = new FrameBuilder(GetSubImage(0, 1))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder branchLeftTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(branchLeftFrame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(branchLeftTile);

            // branch right
            Frame branchRightFrame = new FrameBuilder(GetSubImage(1, 2))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder branchRightTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(branchRightFrame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(branchRightTile);

            // cactus top 1
            Frame cactusTop1Frame = new FrameBuilder(GetSubImage(1, 0))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder cactusTop1Tile = new MapTileBuilder(floorFrame)
                .WithTopLayer(cactusTop1Frame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(cactusTop1Tile);

            // cactus top 2
            Frame cactusTop2Frame = new FrameBuilder(GetSubImage(2, 0))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder cactusTop2Tile = new MapTileBuilder(floorFrame)
                .WithTopLayer(cactusTop2Frame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(cactusTop2Tile);

            // aloe
            Frame aloeFrame = new FrameBuilder(GetSubImage(0, 3)).WithScale(TileScale).Build();

            MapTileBuilder aloeTile = new MapTileBuilder(aloeFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(aloeTile);

            // hill 1
            Frame hill1Frame = new FrameBuilder(GetSubImage(3, 0)).WithScale(TileScale).Build();

            MapTileBuilder hill1Tile = new MapTileBuilder(hill1Frame);

            mapTiles.Add(hill1Tile);

            // hill 2
            Frame hill2Frame = new FrameBuilder(GetSubImage(3, 1)).WithScale(TileScale).Build();

            MapTileBuilder hill2Tile = new MapTileBuilder(hill2Frame);

            mapTiles.Add(hill2Tile);

            // Saloon Wall

            Frame saloonWallFrame = new FrameBuilder(GetSubImage(5, 1))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder saloonWallTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(saloonWallFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(saloonWallTile);

            // Saloon upper left corner

            Frame saloonUpLFrame = new FrameBuilder(GetSubImage(6, 1)).WithScale(TileScale).Build();

            MapTileBuilder saloonUpLTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(saloonUpLFrame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(saloonUpLTile);

            // Saloon upper left corner

            Frame saloonUpRFrame = new FrameBuilder(GetSubImage(6, 1))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .Build();

            MapTileBuilder saloonUpRTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(saloonUpRFrame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(saloonUpRTile);

            // Saloon door right

            Frame saloonDoorRFrame = new FrameBuilder(GetSubImage(5, 2))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .Build();

            MapTileBuilder saloonDoorRTile = new MapTileBuilder(saloonDoorRFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(saloonDoorRTile);

            // Saloon door left

            Frame saloonDoorLFrame = new FrameBuilder(GetSubImage(5, 2))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder saloonDoorLTile = new MapTileBuilder(saloonDoorLFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(saloonDoorLTile);

            // Saloon sign left

            Frame saloonSignLFrame = new FrameBuilder(GetSubImage(6, 2))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder saloonSignLTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(saloonSignLFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(saloonSignLTile);

            // Saloon sign right

            Frame saloonSignRFrame = new FrameBuilder(GetSubImage(6, 3))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder saloonSignRTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(saloonSignRFrame)
                .WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(saloonSignRTile);

            // Saloon top

            Frame saloonUpFrame = new FrameBuilder(GetSubImage(7, 1)).WithScale(TileScale).Build();
            MapTileBuilder saloonUpTile = new MapTileBuilder(floorFrame)
                .WithTopLayer(saloonUpFrame)
                .WithTileType(TileType.PASSABLE);

            mapTiles.Add(saloonUpTile);

            // Saloon side left

            Frame saloonSideLFrame = new FrameBuilder(GetSubImage(5, 0))
                .WithScale(TileScale)
                .Build();
            MapTileBuilder saloonSideLTile = new MapTileBuilder(saloonSideLFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(saloonSideLTile);

            // Saloon side right

            Frame saloonSideRFrame = new FrameBuilder(GetSubImage(5, 0))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .Build();
            MapTileBuilder saloonSideRTile = new MapTileBuilder(saloonSideRFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(saloonSideRTile);

            // Saloon bottom

            Frame saloonBotFrame = new FrameBuilder(GetSubImage(5, 3))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .Build();
            MapTileBuilder saloonBotTile = new MapTileBuilder(saloonBotFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(saloonBotTile);

            return mapTiles;
        }
    }
}
