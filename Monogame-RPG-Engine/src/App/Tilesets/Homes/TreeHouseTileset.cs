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
    public class TreeHouseTileset : Tileset
    {
        public TreeHouseTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.TREE_HOUSE_TILESET), 16, 16, 3) { }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
            Frame frame1 = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile1 = new MapTileBuilder(frame1);
            mapTiles.Add(tile1);

            Frame frame2 = new FrameBuilder(GetSubImage(0, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile2 = new MapTileBuilder(frame2).WithTileType(
                TileType.NOT_PASSABLE
            );
            mapTiles.Add(tile2);

            Frame frame3 = new FrameBuilder(GetSubImage(0, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile3 = new MapTileBuilder(frame3).WithTileType(
                TileType.NOT_PASSABLE
            );
            mapTiles.Add(tile3);

            Frame frame4 = new FrameBuilder(GetSubImage(0, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile4 = new MapTileBuilder(frame4).WithTileType(
                TileType.NOT_PASSABLE
            );
            mapTiles.Add(tile4);

            Frame frame5 = new FrameBuilder(GetSubImage(1, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile5 = new MapTileBuilder(frame5).WithTileType(
                TileType.NOT_PASSABLE
            );
            mapTiles.Add(tile5);

            Frame frame6 = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile6 = new MapTileBuilder(frame6);
            mapTiles.Add(tile6);

            Frame frame7 = new FrameBuilder(GetSubImage(1, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile7 = new MapTileBuilder(frame7);
            mapTiles.Add(tile7);

            Frame frame8 = new FrameBuilder(GetSubImage(1, 3)).WithScale(TileScale).Build();
            MapTileBuilder frame9 = new MapTileBuilder(frame8).WithTileType(
                TileType.NOT_PASSABLE
            );
            mapTiles.Add(frame9);
            return mapTiles;
        }
    }
}
