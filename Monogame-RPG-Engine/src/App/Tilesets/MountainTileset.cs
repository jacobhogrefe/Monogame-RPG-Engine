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
  public class MountainTileset : Tileset
  {
    public MountainTileset(ContentLoader contentLoader)
        : base(contentLoader.LoadTexture(GraphicsHelper.MOUNTAIN_TILESET), 16, 16, 3)
    {
    }

    public override List<MapTileBuilder> DefineTiles()
    {
      List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
      mapTiles.Add(impassableTile(buildFrame(0, 0)));
      mapTiles.Add(buildTile(buildFrame(0, 1)));
      mapTiles.Add(impassableTile(buildFrame(0, 2)));
      mapTiles.Add(impassableTile(buildFrame(0, 3)));
      mapTiles.Add(impassableTile(buildFrame(0, 4)));
      mapTiles.Add(impassableTile(buildFrame(1, 0)));
      mapTiles.Add(buildTile(buildFrame(1, 1)));
      mapTiles.Add(impassableTile(buildFrame(1, 2)));
      mapTiles.Add(impassableTile(buildFrame(1, 3)));
      mapTiles.Add(impassableTile(buildFrame(1, 4)));
      mapTiles.Add(impassableTile(buildFrame(2, 0)));
      mapTiles.Add(impassableTile(buildFrame(2, 1)));
      mapTiles.Add(impassableTile(buildFrame(2, 2)));
      mapTiles.Add(impassableTile(buildFrame(2, 3)));
      mapTiles.Add(impassableTile(buildFrame(2, 4)));
      mapTiles.Add(impassableTile(buildFrame(3, 0)));
      mapTiles.Add(buildTile(buildFrame(3, 1)));
      mapTiles.Add(impassableTile(buildFrame(3, 2)));
      mapTiles.Add(impassableTile(buildFrame(3, 3)));
      mapTiles.Add(impassableTile(buildFrame(3, 4)));
      mapTiles.Add(impassableTile(buildFrame(4, 0)));
      mapTiles.Add(buildTile(buildFrame(4, 1)));
      mapTiles.Add(buildTile(buildFrame(4, 2)));
      mapTiles.Add(buildTile(buildFrame(4, 3)));
      mapTiles.Add(buildTile(buildFrame(4, 4)));
      mapTiles.Add(buildTile(buildFrame(5, 0)));
      mapTiles.Add(buildTile(buildFrame(5, 1)));
      mapTiles.Add(buildTile(buildFrame(5, 2)));
      mapTiles.Add(buildTile(buildFrame(5, 3)));
      mapTiles.Add(buildTile(buildFrame(5, 4)));

      mapTiles.Add(doubleLayeredTile(6, 0, buildFrame(5, 4)));
      mapTiles.Add(doubleLayeredTile(6, 1, buildFrame(5, 4)));
      mapTiles.Add(doubleLayeredTile(6, 2, buildFrame(5, 4)));
      mapTiles.Add(doubleLayeredTile(6, 3, buildFrame(5, 4)));
      mapTiles.Add(doubleLayeredTile(6, 4, buildFrame(5, 4)));
      mapTiles.Add(doubleLayeredTile(7, 0, buildFrame(5, 4)));
      mapTiles.Add(doubleLayeredTile(7, 1, buildFrame(5, 4)));
      Frame[] lanternAnimation = new Frame[] {
            new FrameBuilder(GetSubImage(7, 2), 200)
                .WithScale(TileScale)
                .Build(),
            new FrameBuilder(GetSubImage(7, 3), 200)
                .WithScale(TileScale)
                .Build(),
            new FrameBuilder(GetSubImage(7, 4), 200)
                .WithScale(TileScale)
                .Build()
        };
      MapTileBuilder lantern = new MapTileBuilder(buildFrame(5, 4))
          .WithTopLayer(lanternAnimation)
          .WithTileType(TileType.PASSABLE);
      mapTiles.Add(lantern);
      MapTileBuilder tile = buildTile(buildFrame(6, 3));
      tile.WithTileType(TileType.NOT_PASSABLE);
      mapTiles.Add(tile);

      mapTiles.Add(doubleLayeredTile(8, 0, buildFrame(5, 4)));
      mapTiles.Add(impassableTile(buildFrame(8, 1)));
      mapTiles.Add(doubleLayeredTile(8, 2, buildFrame(5, 4)));
      mapTiles.Add(buildTile(buildFrame(8, 3)));

      mapTiles.Add(impassableTile(buildFrame(0, 1)));
      mapTiles.Add(impassableTile(buildFrame(0, 4)));
      mapTiles.Add(impassableTile(buildFrame(3, 1)));
      mapTiles.Add(impassableTile(buildFrame(0, 0)));
      mapTiles.Add(impassableTile(buildFrame(0, 2)));
      mapTiles.Add(impassableTile(buildFrame(0, 3)));
      mapTiles.Add(impassableTile(buildFrame(3, 0)));
      mapTiles.Add(impassableTile(buildFrame(1, 1)));
      return mapTiles;
    }

    protected Frame buildFrame(int row, int col)
    {
      return new FrameBuilder(GetSubImage(row, col))
              .WithScale(TileScale)
              .Build();
    }

    protected MapTileBuilder buildTile(Frame frame)
    {
      return new MapTileBuilder(frame);
    }

    protected MapTileBuilder impassableTile(Frame frame)
    {
      return new MapTileBuilder(frame)
          .WithTileType(TileType.NOT_PASSABLE);
    }

    protected MapTileBuilder passableTile(Frame frame)
    {
      return new MapTileBuilder(frame)
          .WithTileType(TileType.PASSABLE);
    }

    protected MapTileBuilder doubleLayeredTile(int i, int j, Frame bottomLayer)
    {
      Frame topLayer = new FrameBuilder(GetSubImage(i, j))
              .WithScale(TileScale)
              .Build();
      return new MapTileBuilder(bottomLayer)
          .WithTopLayer(topLayer)
          .WithTileType(TileType.PASSABLE);
    }
  }
}
