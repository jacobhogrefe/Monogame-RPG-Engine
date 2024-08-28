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
    public class HouseTileset : Tileset
    {
        public HouseTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.HOUSE_TILESET), 16, 16, 3) { }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
            // floor
            Frame floorFrame = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();

            MapTileBuilder floorTile = new MapTileBuilder(floorFrame);

            mapTiles.Add(floorTile);

            // wall
            Frame wallFrame = new FrameBuilder(GetSubImage(0, 1)).WithScale(TileScale).Build();

            MapTileBuilder wallTile = new MapTileBuilder(wallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(wallTile);

            // wall w baseboard
            Frame baseBoardFrame = new FrameBuilder(GetSubImage(0, 2)).WithScale(TileScale).Build();

            MapTileBuilder baseBoardTile = new MapTileBuilder(baseBoardFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(baseBoardTile);

            //wall w baseboard dino
            Frame dinoBaseBoardFrame = new FrameBuilder(GetSubImage(0, 3))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder dinoBaseBoardTile = new MapTileBuilder(dinoBaseBoardFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(dinoBaseBoardTile);

            //bed 1
            Frame bed1Frame = new FrameBuilder(GetSubImage(0, 4)).WithScale(TileScale).Build();

            MapTileBuilder bed1Tile = new MapTileBuilder(bed1Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(bed1Tile);

            // window
            Frame windowFrame = new FrameBuilder(GetSubImage(1, 0)).WithScale(TileScale).Build();

            MapTileBuilder windowTile = new MapTileBuilder(windowFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(windowTile);

            // log wall
            Frame logWallFrame = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();

            MapTileBuilder logWallTile = new MapTileBuilder(logWallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(logWallTile);

            // outside wall
            Frame outsideWallFrame = new FrameBuilder(GetSubImage(1, 2))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder outsideWallTile = new MapTileBuilder(outsideWallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(outsideWallTile);

            //dino wall
            Frame dinoWallFrame = new FrameBuilder(GetSubImage(1, 3)).WithScale(TileScale).Build();

            MapTileBuilder dinoWallTile = new MapTileBuilder(dinoWallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(dinoWallTile);

            //bed 2
            Frame bed2Frame = new FrameBuilder(GetSubImage(1, 4)).WithScale(TileScale).Build();

            MapTileBuilder bed2Tile = new MapTileBuilder(bed2Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(bed2Tile);

            //rug
            Frame rugFrame = new FrameBuilder(GetSubImage(2, 0)).WithScale(TileScale).Build();

            MapTileBuilder rugTile = new MapTileBuilder(rugFrame);

            mapTiles.Add(rugTile);

            //door
            Frame doorFrame = new FrameBuilder(GetSubImage(2, 1)).WithScale(TileScale).Build();

            MapTileBuilder doorTile = new MapTileBuilder(doorFrame).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;

            mapTiles.Add(doorTile);

            //filler
            Frame fillerFrame = new FrameBuilder(GetSubImage(2, 2)).WithScale(TileScale).Build();

            MapTileBuilder fillerTile = new MapTileBuilder(fillerFrame).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;

            mapTiles.Add(fillerTile);

            //walrus wall w baseboard
            Frame walrusBaseBoardFrame = new FrameBuilder(GetSubImage(2, 3))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder walrusBaseBoardTile = new MapTileBuilder(
                walrusBaseBoardFrame
            ).WithTileType(TileType.NOT_PASSABLE);

            mapTiles.Add(walrusBaseBoardTile);

            //walrus wall
            Frame walrusWallFrame = new FrameBuilder(GetSubImage(3, 0))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder walrusWallTile = new MapTileBuilder(walrusWallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(walrusWallTile);

            //chair
            Frame chairFrame = new FrameBuilder(GetSubImage(3, 1)).WithScale(TileScale).Build();

            MapTileBuilder chairTile = new MapTileBuilder(chairFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(chairTile);

            //sofa 1
            Frame sofa1Frame = new FrameBuilder(GetSubImage(3, 2)).WithScale(TileScale).Build();

            MapTileBuilder sofa1Tile = new MapTileBuilder(sofa1Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(sofa1Tile);

            //sofa 2
            Frame sofa2Frame = new FrameBuilder(GetSubImage(3, 3)).WithScale(TileScale).Build();

            MapTileBuilder sofa2Tile = new MapTileBuilder(sofa2Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(sofa2Tile);

            //computer
            Frame computerFrame = new FrameBuilder(GetSubImage(2, 4)).WithScale(TileScale).Build();

            MapTileBuilder computerTile = new MapTileBuilder(computerFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(computerTile);

            //desk top
            Frame deskTopFrame = new FrameBuilder(GetSubImage(3, 4)).WithScale(TileScale).Build();

            MapTileBuilder deskTopTile = new MapTileBuilder(floorFrame).WithTopLayer(deskTopFrame);

            mapTiles.Add(deskTopTile);

            //desk bottom
            Frame deskBottomFrame = new FrameBuilder(GetSubImage(4, 4))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder deskBottomTile = new MapTileBuilder(floorFrame).WithTopLayer(
                deskBottomFrame
            );

            mapTiles.Add(deskBottomTile);

            //desk bottom w foot
            Frame deskBottomFootFrame = new FrameBuilder(GetSubImage(4, 3))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder deskBottomFootTile = new MapTileBuilder(floorFrame)
                .WithTileType(TileType.NOT_PASSABLE)
                .WithTopLayer(deskBottomFootFrame);

            mapTiles.Add(deskBottomFootTile);

            //^ flipped
            Frame deskBottomFoot2Frame = new FrameBuilder(GetSubImage(4, 3))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipHorizontally)
                .Build();

            MapTileBuilder deskBottomFoot2Tile = new MapTileBuilder(floorFrame)
                .WithTileType(TileType.NOT_PASSABLE)
                .WithTopLayer(deskBottomFoot2Frame);

            mapTiles.Add(deskBottomFoot2Tile);

            //swirly
            Frame swirlyFrame = new FrameBuilder(GetSubImage(4, 1)).WithScale(TileScale).Build();

            MapTileBuilder swirlyTile = new MapTileBuilder(swirlyFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(swirlyTile);

            //swirly 2
            Frame swirly2Frame = new FrameBuilder(GetSubImage(5, 1)).WithScale(TileScale).Build();

            MapTileBuilder swirly2Tile = new MapTileBuilder(swirly2Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(swirly2Tile);

            //swirly lol
            Frame swirly3Frame = new FrameBuilder(GetSubImage(4, 2)).WithScale(TileScale).Build();

            MapTileBuilder swirly3Tile = new MapTileBuilder(floorFrame).WithTopLayer(swirly3Frame);

            mapTiles.Add(swirly3Tile);

            //HAHAHAHHA
            Frame HAHAFrame = new FrameBuilder(GetSubImage(4, 0)).WithScale(TileScale).Build();

            MapTileBuilder HAHATile = new MapTileBuilder(HAHAFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(HAHATile);

            return mapTiles;
        }
    }
}
