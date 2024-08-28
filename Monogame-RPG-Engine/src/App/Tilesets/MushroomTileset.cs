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
  public class MushroomTileset : Tileset
  {
    public MushroomTileset(ContentLoader contentLoader)
        : base(contentLoader.LoadTexture(GraphicsHelper.MUSHROOM_TILESET), 16, 16, 3)
    {
    }

    public override List<MapTileBuilder> DefineTiles()
    {
      List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
      // floor 1
      Frame floorFrame = new FrameBuilder(GetSubImage(0, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder floorTile = new MapTileBuilder(floorFrame);

      mapTiles.Add(floorTile);

      //floor 2
      Frame floorFrame2 = new FrameBuilder(GetSubImage(0, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder floorTile2 = new MapTileBuilder(floorFrame2);

      mapTiles.Add(floorTile2);

      //floor 3
      Frame floorFrame3 = new FrameBuilder(GetSubImage(1, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder floorTile3 = new MapTileBuilder(floorFrame3);

      mapTiles.Add(floorTile3);

      //floor mushroom
      Frame mushroomFrame = new FrameBuilder(GetSubImage(1, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTile = new MapTileBuilder(mushroomFrame);

      mapTiles.Add(mushroomTile);

      // big mushroom base
      Frame mushroomBaseFrame = new FrameBuilder(GetSubImage(3, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomBaseTile = new MapTileBuilder(floorFrame)
              .WithTopLayer(mushroomBaseFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(mushroomBaseTile);

      //mushroom stem 1
      Frame mushroomStem1Frame = new FrameBuilder(GetSubImage(2, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomStem1Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomStem1Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomStem1Tile);

      //mushroom stem 2
      Frame mushroomStem2Frame = new FrameBuilder(GetSubImage(2, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomStem2Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomStem2Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomStem2Tile);

      //mushroom stem 3
      Frame mushroomStem3Frame = new FrameBuilder(GetSubImage(3, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomStem3Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomStem3Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomStem3Tile);

      //branch 1
      Frame branch1Frame = new FrameBuilder(GetSubImage(2, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder branch1Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(branch1Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(branch1Tile);

      //branch 2
      Frame branch2Frame = new FrameBuilder(GetSubImage(3, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder branch2Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(branch2Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(branch2Tile);

      //mushroom top 1
      Frame mushroomTop1Frame = new FrameBuilder(GetSubImage(0, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTop1Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomTop1Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomTop1Tile);

      //mushroom top 2
      Frame mushroomTop2Frame = new FrameBuilder(GetSubImage(0, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTop2Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomTop2Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomTop2Tile);

      //mushroom top 3
      Frame mushroomTop3Frame = new FrameBuilder(GetSubImage(0, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTop3Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomTop3Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomTop3Tile);

      //mushroom top 4
      Frame mushroomTop4Frame = new FrameBuilder(GetSubImage(1, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTop4Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomTop4Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomTop4Tile);

      //mushroom top 5
      Frame mushroomTop5Frame = new FrameBuilder(GetSubImage(1, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTop5Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomTop5Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomTop5Tile);

      //mushroom top 6
      Frame mushroomTop6Frame = new FrameBuilder(GetSubImage(1, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomTop6Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomTop6Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomTop6Tile);

      //mushroom roof 1
      Frame mushroomRoof1Frame = new FrameBuilder(GetSubImage(4, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof1Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof1Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof1Tile);

      //mushroom roof 2
      Frame mushroomRoof2Frame = new FrameBuilder(GetSubImage(5, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof2Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof2Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof2Tile);

      //mushroom roof 3
      Frame mushroomRoof3Frame = new FrameBuilder(GetSubImage(6, 0))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof3Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof3Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof3Tile);

      //mushroom roof 4
      Frame mushroomRoof4Frame = new FrameBuilder(GetSubImage(4, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof4Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof4Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof4Tile);

      //mushroom roof 5
      Frame mushroomRoof5Frame = new FrameBuilder(GetSubImage(5, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof5Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof5Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof5Tile);

      //mushroom roof 6
      Frame mushroomRoof6Frame = new FrameBuilder(GetSubImage(6, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof6Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof6Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof6Tile);

      //mushroom roof 7
      Frame mushroomRoof7Frame = new FrameBuilder(GetSubImage(4, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof7Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof7Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof7Tile);

      //mushroom roof 8
      Frame mushroomRoof8Frame = new FrameBuilder(GetSubImage(5, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof8Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof8Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof8Tile);

      //mushroom roof 9
      Frame mushroomRoof9Frame = new FrameBuilder(GetSubImage(6, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof9Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof9Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof9Tile);

      //mushroom roof 10
      Frame mushroomRoof10Frame = new FrameBuilder(GetSubImage(4, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof10Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof10Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof10Tile);

      //mushroom roof 11
      Frame mushroomRoof11Frame = new FrameBuilder(GetSubImage(5, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof11Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof11Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof11Tile);

      //mushroom roof 12
      Frame mushroomRoof12Frame = new FrameBuilder(GetSubImage(6, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof12Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof12Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof12Tile);

      //mushroom roof 13
      Frame mushroomRoof13Frame = new FrameBuilder(GetSubImage(4, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof13Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof13Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof13Tile);

      //mushroom roof 14
      Frame mushroomRoof14Frame = new FrameBuilder(GetSubImage(5, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof14Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof14Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof14Tile);

      //mushroom roof 15
      Frame mushroomRoof15Frame = new FrameBuilder(GetSubImage(6, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomRoof15Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(mushroomRoof15Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(mushroomRoof15Tile);

      //mushroom house stem
      Frame mushroomHouseFrame = new FrameBuilder(GetSubImage(2, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomHouseTile = new MapTileBuilder(mushroomHouseFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(mushroomHouseTile);

      //mushroom house door
      Frame mushroomDoorFrame = new FrameBuilder(GetSubImage(3, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder mushroomDoorTile = new MapTileBuilder(mushroomDoorFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(mushroomDoorTile);

      //window
      Frame windowFrame = new FrameBuilder(GetSubImage(3, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder windowTile = new MapTileBuilder(windowFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(windowTile);

      //house side 1
      Frame houseSide1Frame = new FrameBuilder(GetSubImage(2, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder houseSide1Tile = new MapTileBuilder(houseSide1Frame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(houseSide1Tile);

      //house side 2
      Frame houseSide2Frame = new FrameBuilder(GetSubImage(2, 4))
              .WithScale(TileScale)
              .WithSpriteEffect(SpriteEffects.FlipHorizontally)
              .Build();

      MapTileBuilder houseSide2Tile = new MapTileBuilder(houseSide2Frame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(houseSide2Tile);

      //rock wall
      Frame rockWallFrame = new FrameBuilder(GetSubImage(0, 5))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder rockWallTile = new MapTileBuilder(rockWallFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(rockWallTile);

      //rock wall top
      Frame rockTopFrame = new FrameBuilder(GetSubImage(1, 5))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder rockTopTile = new MapTileBuilder(rockTopFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(rockTopTile);

      //rock wall bottom
      Frame rockBottomFrame = new FrameBuilder(GetSubImage(2, 5))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder rockBottomTile = new MapTileBuilder(floorFrame)
          .WithTopLayer(rockBottomFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(rockBottomTile);

      //top
      Frame topFrame = new FrameBuilder(GetSubImage(3, 5))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder topTile = new MapTileBuilder(topFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(topTile);

      //side rock wall
      Frame sideRockFrame = new FrameBuilder(GetSubImage(4, 5))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder sideRockTile = new MapTileBuilder(floorFrame)
          .WithTopLayer(sideRockFrame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(sideRockTile);

      //flipped side rock wall
      Frame sideRock2Frame = new FrameBuilder(GetSubImage(4, 5))
              .WithScale(TileScale)
              .WithSpriteEffect(SpriteEffects.FlipHorizontally)
              .Build();

      MapTileBuilder sideRock2Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(sideRock2Frame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(sideRock2Tile);

      //flipped upside down rock wall
      Frame sideRock3Frame = new FrameBuilder(GetSubImage(4, 5))
              .WithScale(TileScale)
              .WithSpriteEffect(SpriteEffects.FlipVertically)
              .Build();

      MapTileBuilder sideRock3Tile = new MapTileBuilder(floorFrame)
          .WithTopLayer(sideRock3Frame)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(sideRock3Tile);

      //transition to fallout
      Frame floorFrame4 = new FrameBuilder(GetSubImage(0, 6))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder floorTile4 = new MapTileBuilder(floorFrame4);

      mapTiles.Add(floorTile4);

      //rocks
      Frame rockFrame = new FrameBuilder(GetSubImage(1, 6))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder rockTile = new MapTileBuilder(rockFrame);

      mapTiles.Add(rockTile);

      //lighting bugs
      Frame[] bugJarFrames = new Frame[] {
                new FrameBuilder(GetSubImage(5, 5), 30)
                    .WithScale(TileScale)
                    .Build(),
                new FrameBuilder(GetSubImage(6, 5), 30)
                        .WithScale(TileScale)
                        .Build()
        };

      MapTileBuilder bugJarTile = new MapTileBuilder(floorFrame)
          .WithTopLayer(bugJarFrames)
              .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(bugJarTile);

      //soil 
      Frame soilFrame = new FrameBuilder(GetSubImage(1, 6))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder soilTile = new MapTileBuilder(soilFrame);

      mapTiles.Add(soilTile);

      //purple soil 
      Frame soil1Frame = new FrameBuilder(GetSubImage(2, 7))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder soil1Tile = new MapTileBuilder(soil1Frame);

      mapTiles.Add(soil1Tile);

      //spinny soil 1
      Frame spinnySoil1Frame = new FrameBuilder(GetSubImage(2, 6))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder spinnySoil1Tile = new MapTileBuilder(spinnySoil1Frame);

      mapTiles.Add(spinnySoil1Tile);

      //spinny soil 2
      Frame spinnySoil2Frame = new FrameBuilder(GetSubImage(2, 6))
              .WithScale(TileScale)
              .WithSpriteEffect(SpriteEffects.FlipHorizontally)
              .WithSpriteEffect(SpriteEffects.FlipVertically)
              .Build();

      MapTileBuilder spinnySoil2Tile = new MapTileBuilder(spinnySoil2Frame);

      mapTiles.Add(spinnySoil2Tile);

      //spinny soil 3
      Frame spinnySoil3Frame = new FrameBuilder(GetSubImage(2, 6))
              .WithScale(TileScale)
              .WithSpriteEffect(SpriteEffects.FlipVertically)
              .Build();

      MapTileBuilder spinnySoil3Tile = new MapTileBuilder(spinnySoil3Frame);

      mapTiles.Add(spinnySoil3Tile);

      //spinny soil 4
      Frame spinnySoil4Frame = new FrameBuilder(GetSubImage(2, 6))
              .WithScale(TileScale)
              .WithSpriteEffect(SpriteEffects.FlipHorizontally)
              .Build();

      MapTileBuilder spinnySoil4Tile = new MapTileBuilder(spinnySoil4Frame);

      mapTiles.Add(spinnySoil4Tile);

      //dancing mushrooms
      Frame[] danceFrame = new Frame[] {
                new FrameBuilder(GetSubImage(3, 6), 35)
                    .WithScale(TileScale)
                    .Build(),
                new FrameBuilder(GetSubImage(4, 6), 35)
                        .WithScale(TileScale)
                        .Build(),
                new FrameBuilder(GetSubImage(0, 7), 35)
                        .WithScale(TileScale)
                        .Build()
        };

      MapTileBuilder danceTile = new MapTileBuilder(danceFrame);

      mapTiles.Add(danceTile);

      //sign
      Frame signFrame = new FrameBuilder(GetSubImage(3, 7))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder signTile = new MapTileBuilder(signFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(signTile);

      //fence
      Frame fenceFrame = new FrameBuilder(GetSubImage(4, 7))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder fenceTile = new MapTileBuilder(fenceFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(fenceTile);
      return mapTiles;
    }
  }
}
