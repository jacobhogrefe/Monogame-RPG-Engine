using App.Resources;
using Engine.Builders;
using Engine.Core;
using Engine.Entity;
using Engine.Scene;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Tilesets
{
    public class MushroomHouseTileset : Tileset
    {
        public MushroomHouseTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.MUSHROOM_HOUSE_TILESET), 16, 16, 3)
        {
        }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
            // floor
        Frame floorFrame = new FrameBuilder(GetSubImage(1, 0))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder floorTile = new MapTileBuilder(floorFrame);

        mapTiles.Add(floorTile);

        
        // wall
        Frame wallFrame = new FrameBuilder(GetSubImage(0, 0))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder wallTile = new MapTileBuilder(wallFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(wallTile);
        
        // window
        Frame windowFrame = new FrameBuilder(GetSubImage(0, 1))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder windowTile = new MapTileBuilder(windowFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(windowTile);
        
        // door
        Frame doorFrame = new FrameBuilder(GetSubImage(1, 1))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder doorTile = new MapTileBuilder(doorFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(doorTile);
        
        // barrier
        Frame barrierFrame = new FrameBuilder(GetSubImage(0, 2))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder barrierTile = new MapTileBuilder(barrierFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(barrierTile);
        
        //outside wall
        Frame outsideFrame = new FrameBuilder(GetSubImage(0, 3))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder outsideTile = new MapTileBuilder(outsideFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(outsideTile);
        
        //outside wall2
        Frame outside2Frame = new FrameBuilder(GetSubImage(1, 4))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder outside2Tile = new MapTileBuilder(outside2Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(outside2Tile);
        
        //outside wall 2 flipped
        Frame outside2flippedFrame = new FrameBuilder(GetSubImage(1, 4))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipVertically)
                .Build();

        MapTileBuilder outside2flippedTile = new MapTileBuilder(outside2flippedFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(outside2flippedTile);
        
        //outside wall3
        Frame outside3Frame = new FrameBuilder(GetSubImage(2, 4))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder outside3Tile = new MapTileBuilder(outside3Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(outside3Tile);
        
        //outside wall 3 flipped
        Frame outside3flippedFrame = new FrameBuilder(GetSubImage(2, 4))
                .WithScale(TileScale)
                .WithSpriteEffect(SpriteEffects.FlipVertically)
                .Build();

        MapTileBuilder outside3flippedTile = new MapTileBuilder(outside3flippedFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(outside3flippedTile);
        
        //side wall
        Frame sideWallFrame = new FrameBuilder(GetSubImage(0, 4))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder sideWallTile = new MapTileBuilder(sideWallFrame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(sideWallTile);

        //dresser 1
        Frame dresser1Frame = new FrameBuilder(GetSubImage(2, 0))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder dresser1Tile = new MapTileBuilder(dresser1Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(dresser1Tile);
        
        //dresser 2
        Frame dresser2Frame = new FrameBuilder(GetSubImage(3, 0))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder dresser2Tile = new MapTileBuilder(dresser2Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(dresser2Tile);
        
        //dresser 3
        Frame dresser3Frame = new FrameBuilder(GetSubImage(2, 1))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder dresser3Tile = new MapTileBuilder(dresser3Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(dresser3Tile);
        
        //dresser 4
        Frame dresser4Frame = new FrameBuilder(GetSubImage(3, 1))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder dresser4Tile = new MapTileBuilder(dresser4Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(dresser4Tile);
        
        //bed 1
        Frame bed1Frame = new FrameBuilder(GetSubImage(1, 2))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder bed1Tile = new MapTileBuilder(bed1Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(bed1Tile);
        
        //bed 2
        Frame bed2Frame = new FrameBuilder(GetSubImage(1, 3))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder bed2Tile = new MapTileBuilder(bed2Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(bed2Tile);
        
        //bed 3
        Frame bed3Frame = new FrameBuilder(GetSubImage(2, 2))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder bed3Tile = new MapTileBuilder(bed3Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(bed3Tile);
        
        //bed 4
        Frame bed4Frame = new FrameBuilder(GetSubImage(2, 3))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder bed4Tile = new MapTileBuilder(bed4Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(bed4Tile);
        
        //bed 5
        Frame bed5Frame = new FrameBuilder(GetSubImage(3, 2))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder bed5Tile = new MapTileBuilder(bed5Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(bed5Tile);
        
        //bed 6
        Frame bed6Frame = new FrameBuilder(GetSubImage(3, 3))
                .WithScale(TileScale)
                .Build();

        MapTileBuilder bed6Tile = new MapTileBuilder(bed6Frame)
                .WithTileType(TileType.NOT_PASSABLE);

        mapTiles.Add(bed6Tile);
            return mapTiles;
        }
    }
}
