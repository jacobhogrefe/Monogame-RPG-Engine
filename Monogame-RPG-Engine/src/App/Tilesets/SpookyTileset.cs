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
  public class SpookyTileset : Tileset
  {
    public SpookyTileset(ContentLoader contentLoader)
        : base(contentLoader.LoadTexture(GraphicsHelper.SPOOKY_TILESET), 16, 16, 3)
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

      //grass floor Tile 1
      Frame grassfloorTile1Frame = new FrameBuilder(GetSubImage(0, 1))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder grassfloorTile1 = new MapTileBuilder(grassfloorTile1Frame);

      mapTiles.Add(grassfloorTile1);

      //grass floor Tile 2
      Frame grassfloorTile2Frame = new FrameBuilder(GetSubImage(0, 2))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder grassfloorTile2 = new MapTileBuilder(grassfloorTile2Frame)
          .WithTileType(TileType.NOT_PASSABLE);


      mapTiles.Add(grassfloorTile2);

      // Tree stem base 1 
      Frame treestem1Frame = new FrameBuilder(GetSubImage(0, 3))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder treestem1Tile = new MapTileBuilder(treestem1Frame)
              .WithTopLayer(treestem1Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(treestem1Tile);

      // Castle plain
      Frame CastleplainFrame = new FrameBuilder(GetSubImage(0, 4))
              .WithScale(TileScale)
              .Build();

      MapTileBuilder CastleplainTile = new MapTileBuilder(CastleplainFrame)
              .WithTopLayer(CastleplainFrame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(CastleplainTile);

      //Pumpkin left top corner 

      Frame PumpkinlefttopFrame = new FrameBuilder(GetSubImage(1, 0))
            .WithScale(TileScale)
            .Build();

      MapTileBuilder PumpkinlefttopTile = new MapTileBuilder(PumpkinlefttopFrame)
          .WithTopLayer(PumpkinlefttopFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinlefttopTile);

      //Pumpkin stem1 top  

      Frame Pumpkinstem1Frame = new FrameBuilder(GetSubImage(1, 1))
            .WithScale(TileScale)
            .Build();

      MapTileBuilder Pumpkinstem1Tile = new MapTileBuilder(Pumpkinstem1Frame)
          .WithTopLayer(Pumpkinstem1Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Pumpkinstem1Tile);

      //Pumpkin stem2 top  

      Frame Pumpkinstem2Frame = new FrameBuilder(GetSubImage(1, 2))
            .WithScale(TileScale)
            .Build();

      MapTileBuilder Pumpkinstem2Tile = new MapTileBuilder(Pumpkinstem2Frame)
          .WithTopLayer(Pumpkinstem2Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Pumpkinstem2Tile);

      //Pumpkin right top corner 

      Frame PumpkinrighttopFrame = new FrameBuilder(GetSubImage(1, 3))
            .WithScale(TileScale)
            .Build();

      MapTileBuilder PumpkinrighttopTile = new MapTileBuilder(PumpkinrighttopFrame)
          .WithTopLayer(PumpkinrighttopFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinrighttopTile);


      //Pumpkin left side  

      Frame PumpkinrleftsideFrame = new FrameBuilder(GetSubImage(2, 0))
            .WithScale(TileScale)
            .Build();

      MapTileBuilder PumpkinleftsideTile = new MapTileBuilder(PumpkinrleftsideFrame)
          .WithTopLayer(PumpkinrleftsideFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinleftsideTile);


      //Pumpkin left center  

      Frame PumpkinrleftcenterFrame = new FrameBuilder(GetSubImage(2, 1))
          .WithScale(TileScale)
          .Build();

      MapTileBuilder PumpkinleftcenterTile = new MapTileBuilder(PumpkinrleftcenterFrame)
          .WithTopLayer(PumpkinrleftcenterFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinleftcenterTile);

      //Pumpkin right center  

      Frame PumpkinrrightcenterFrame = new FrameBuilder(GetSubImage(2, 2))
        .WithScale(TileScale)
        .Build();

      MapTileBuilder PumpkinrightcenterTile = new MapTileBuilder(PumpkinrrightcenterFrame)
          .WithTopLayer(PumpkinrrightcenterFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinrightcenterTile);

      //Pumpkin right side  

      Frame PumpkinrightsideFrame = new FrameBuilder(GetSubImage(2, 3))
          .WithScale(TileScale)
          .Build();

      MapTileBuilder PumpkinrightsideTile = new MapTileBuilder(PumpkinrightsideFrame)
          .WithTopLayer(PumpkinrightsideFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinrightsideTile);

      //Pumpkin bottom left  

      Frame PumpkinbottomleftFrame = new FrameBuilder(GetSubImage(3, 0))
        .WithScale(TileScale)
        .Build();

      MapTileBuilder PumpkinbottomleftTile = new MapTileBuilder(PumpkinbottomleftFrame)
          .WithTopLayer(PumpkinbottomleftFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinbottomleftTile);

      //Pumpkin bottom left2  

      Frame Pumpkinbottomleft2Frame = new FrameBuilder(GetSubImage(3, 1))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Pumpkinbottomleft2Tile = new MapTileBuilder(Pumpkinbottomleft2Frame)
          .WithTopLayer(Pumpkinbottomleft2Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Pumpkinbottomleft2Tile);

      //Pumpkin bottom right  

      Frame PumpkinbottomrightFrame = new FrameBuilder(GetSubImage(3, 2))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder PumpkinbottomrightTile = new MapTileBuilder(PumpkinbottomrightFrame)
          .WithTopLayer(PumpkinbottomrightFrame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(PumpkinbottomrightTile);

      //Pumpkin bottom right2  

      Frame Pumpkinbottomright2Frame = new FrameBuilder(GetSubImage(3, 3))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Pumpkinbottomright2Tile = new MapTileBuilder(Pumpkinbottomright2Frame)
          .WithTopLayer(Pumpkinbottomright2Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Pumpkinbottomright2Tile);

      //Castle1 

      Frame Castle1Frame = new FrameBuilder(GetSubImage(4, 0))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle1Tile = new MapTileBuilder(Castle1Frame)
          .WithTopLayer(Castle1Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle1Tile);


      //Castle2 

      Frame Castle2Frame = new FrameBuilder(GetSubImage(4, 1))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle2Tile = new MapTileBuilder(Castle2Frame)
          .WithTopLayer(Castle2Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle2Tile);

      //Castle3 

      Frame Castle3Frame = new FrameBuilder(GetSubImage(4, 2))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle3Tile = new MapTileBuilder(Castle3Frame)
          .WithTopLayer(Castle3Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle3Tile);


      //Castle4 

      Frame Castle4Frame = new FrameBuilder(GetSubImage(4, 3))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle4Tile = new MapTileBuilder(Castle4Frame)
          .WithTopLayer(Castle4Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle4Tile);

      //Castle5

      Frame Castle5Frame = new FrameBuilder(GetSubImage(4, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle5Tile = new MapTileBuilder(Castle5Frame)
          .WithTopLayer(Castle5Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle5Tile);


      //Castle6 

      Frame Castle6Frame = new FrameBuilder(GetSubImage(0, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle6Tile = new MapTileBuilder(Castle6Frame)
          .WithTopLayer(Castle6Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle6Tile);

      //Castle7

      Frame Castle7Frame = new FrameBuilder(GetSubImage(1, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle7Tile = new MapTileBuilder(Castle7Frame)
          .WithTopLayer(Castle7Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(Castle7Tile);

      //Castle8

      Frame Castle8Frame = new FrameBuilder(GetSubImage(2, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle8Tile = new MapTileBuilder(Castle8Frame)
          //.WithBottomLayer(Castle8Frame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(Castle8Tile);

      //Castle9

      Frame Castle9Frame = new FrameBuilder(GetSubImage(3, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle9Tile = new MapTileBuilder(Castle9Frame)
          //.WithBottomLayer(Castle9Frame)
          .WithTileType(TileType.PASSABLE);
      mapTiles.Add(Castle9Tile);

      //Castle10

      Frame Castle10Frame = new FrameBuilder(GetSubImage(4, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder Castle10Tile = new MapTileBuilder(Castle10Frame)
          //.WithBottomLayer(Castle10Frame)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(Castle10Tile);
      //0,5
      Frame gravelFrame = new FrameBuilder(GetSubImage(0, 5))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder gravelTile = new MapTileBuilder(gravelFrame)
      //.WithBottomLayer(gravelFrame)
      .WithTileType(TileType.PASSABLE);
      mapTiles.Add(gravelTile);


      Frame treeleafFrame = new FrameBuilder(GetSubImage(1, 5))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder treeleafTile = new MapTileBuilder(treeleafFrame)
          .WithTopLayer(treeleafFrame)
          .WithTileType(TileType.PASSABLE);

      mapTiles.Add(treeleafTile);


      Frame treeJawn = new FrameBuilder(GetSubImage(1, 4))
      .WithScale(TileScale)
      .Build();

      MapTileBuilder treeJawn2 = new MapTileBuilder(treeJawn)
          .WithTopLayer(treeJawn)
          .WithTileType(TileType.NOT_PASSABLE);

      mapTiles.Add(treeJawn2);

      return mapTiles;
    }
  }
}
