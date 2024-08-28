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
    public class MountainTileset : Tileset
    {
        public MountainTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.MOUNTAIN_TILESET), 16, 16, 3) { }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();

            // Row 0
            Frame frame00 = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile00 = new MapTileBuilder(frame00).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile00);

            Frame frame01 = new FrameBuilder(GetSubImage(0, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile01 = new MapTileBuilder(frame01);
            mapTiles.Add(tile01);

            Frame frame02 = new FrameBuilder(GetSubImage(0, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile02 = new MapTileBuilder(frame02).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile02);

            Frame frame03 = new FrameBuilder(GetSubImage(0, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile03 = new MapTileBuilder(frame03).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile03);

            Frame frame04 = new FrameBuilder(GetSubImage(0, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile04 = new MapTileBuilder(frame04).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile04);

            // Row 1
            Frame frame10 = new FrameBuilder(GetSubImage(1, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile10 = new MapTileBuilder(frame10).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile10);

            Frame frame11 = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile11 = new MapTileBuilder(frame11);
            mapTiles.Add(tile11);

            Frame frame12 = new FrameBuilder(GetSubImage(1, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile12 = new MapTileBuilder(frame12).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile12);

            Frame frame13 = new FrameBuilder(GetSubImage(1, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile13 = new MapTileBuilder(frame13).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile13);

            Frame frame14 = new FrameBuilder(GetSubImage(1, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile14 = new MapTileBuilder(frame14).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile14);

            // Row 2
            Frame frame20 = new FrameBuilder(GetSubImage(2, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile20 = new MapTileBuilder(frame20).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile20);

            Frame frame21 = new FrameBuilder(GetSubImage(2, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile21 = new MapTileBuilder(frame21).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile21);

            Frame frame22 = new FrameBuilder(GetSubImage(2, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile22 = new MapTileBuilder(frame22).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile22);

            Frame frame23 = new FrameBuilder(GetSubImage(2, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile23 = new MapTileBuilder(frame23).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile23);

            Frame frame24 = new FrameBuilder(GetSubImage(2, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile24 = new MapTileBuilder(frame24).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile24);

            // Row 3
            Frame frame30 = new FrameBuilder(GetSubImage(3, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile30 = new MapTileBuilder(frame30).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile30);

            Frame frame31 = new FrameBuilder(GetSubImage(3, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile31 = new MapTileBuilder(frame31);
            mapTiles.Add(tile31);

            Frame frame32 = new FrameBuilder(GetSubImage(3, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile32 = new MapTileBuilder(frame32).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile32);

            Frame frame33 = new FrameBuilder(GetSubImage(3, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile33 = new MapTileBuilder(frame33).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile33);

            Frame frame34 = new FrameBuilder(GetSubImage(3, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile34 = new MapTileBuilder(frame34).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile34);

            // Row 4
            Frame frame40 = new FrameBuilder(GetSubImage(4, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile40 = new MapTileBuilder(frame40).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile40);

            Frame frame41 = new FrameBuilder(GetSubImage(4, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile41 = new MapTileBuilder(frame41);
            mapTiles.Add(tile41);

            Frame frame42 = new FrameBuilder(GetSubImage(4, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile42 = new MapTileBuilder(frame42);
            mapTiles.Add(tile42);

            Frame frame43 = new FrameBuilder(GetSubImage(4, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile43 = new MapTileBuilder(frame43);
            mapTiles.Add(tile43);

            Frame frame44 = new FrameBuilder(GetSubImage(4, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile44 = new MapTileBuilder(frame44);
            mapTiles.Add(tile44);

            // Row 5
            Frame frame50 = new FrameBuilder(GetSubImage(5, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile50 = new MapTileBuilder(frame50);
            mapTiles.Add(tile50);

            Frame frame51 = new FrameBuilder(GetSubImage(5, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile51 = new MapTileBuilder(frame51);
            mapTiles.Add(tile51);

            Frame frame52 = new FrameBuilder(GetSubImage(5, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile52 = new MapTileBuilder(frame52);
            mapTiles.Add(tile52);

            Frame frame53 = new FrameBuilder(GetSubImage(5, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile53 = new MapTileBuilder(frame53);
            mapTiles.Add(tile53);

            Frame frame54 = new FrameBuilder(GetSubImage(5, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile54 = new MapTileBuilder(frame54);
            mapTiles.Add(tile54);

            // Row 6 (Double Layered Tiles)).WithScale(TileScale).Build();
            Frame tile60_f = new FrameBuilder(GetSubImage(6, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile60 = new MapTileBuilder(frame54)
                .WithTopLayer(tile60_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile60);

            Frame tile61_f = new FrameBuilder(GetSubImage(6, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile61 = new MapTileBuilder(frame54)
                .WithTopLayer(tile61_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile61);

            Frame tile62_f = new FrameBuilder(GetSubImage(6, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile62 = new MapTileBuilder(frame54)
                .WithTopLayer(tile62_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile62);

            Frame tile63_f = new FrameBuilder(GetSubImage(6, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile63 = new MapTileBuilder(frame54)
                .WithTopLayer(tile63_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile63);

            Frame tile64_f = new FrameBuilder(GetSubImage(6, 4)).WithScale(TileScale).Build();
            MapTileBuilder tile64 = new MapTileBuilder(frame54)
                .WithTopLayer(tile64_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile64);

            // Row 7 (Double Layered Tiles)).WithScale(TileScale).Build();
            Frame tile70_f = new FrameBuilder(GetSubImage(7, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile70 = new MapTileBuilder(frame54)
                .WithTopLayer(tile70_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile70);

            Frame tile71_f = new FrameBuilder(GetSubImage(7, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile71 = new MapTileBuilder(frame54)
                .WithTopLayer(tile71_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile71);

            // Lantern Tile with Animation
            Frame[] lanternAnimation = new Frame[]
            {
                new FrameBuilder(GetSubImage(7, 2), 200).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(7, 3), 200).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(7, 4), 200).WithScale(TileScale).Build(),
            };
            MapTileBuilder lanternTile = new MapTileBuilder(frame54)
                .WithTopLayer(lanternAnimation)
                .WithTileType(TileType.PASSABLE);
            mapTiles.Add(lanternTile);

            // Special Tile with NOT_PASSABLE
            MapTileBuilder specialTile = new MapTileBuilder(
                new FrameBuilder(GetSubImage(6, 3)).WithScale(TileScale).Build()
            );
            specialTile.WithTileType(TileType.NOT_PASSABLE);
            mapTiles.Add(specialTile);

            // Row 8
            Frame tile80_f = new FrameBuilder(GetSubImage(8, 0)).WithScale(TileScale).Build();
            MapTileBuilder tile80 = new MapTileBuilder(frame54)
                .WithTopLayer(tile80_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile80);

            Frame frame81 = new FrameBuilder(GetSubImage(8, 1)).WithScale(TileScale).Build();
            MapTileBuilder tile81 = new MapTileBuilder(frame81).WithTileType(TileType.NOT_PASSABLE);
            ;
            mapTiles.Add(tile81);

            Frame tile82_f = new FrameBuilder(GetSubImage(8, 2)).WithScale(TileScale).Build();
            MapTileBuilder tile82 = new MapTileBuilder(frame54)
                .WithTopLayer(tile82_f)
                .WithTileType(TileType.PASSABLE);
            ;
            mapTiles.Add(tile82);

            Frame frame83 = new FrameBuilder(GetSubImage(8, 3)).WithScale(TileScale).Build();
            MapTileBuilder tile83 = new MapTileBuilder(frame83);
            mapTiles.Add(tile83);

            // Miscellaneous Tiles (Duplicated from earlier)
            Frame miscFrame01 = new FrameBuilder(GetSubImage(0, 1)).WithScale(TileScale).Build();
            MapTileBuilder miscTile01 = new MapTileBuilder(miscFrame01).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile01);

            Frame miscFrame04 = new FrameBuilder(GetSubImage(0, 4)).WithScale(TileScale).Build();
            MapTileBuilder miscTile04 = new MapTileBuilder(miscFrame04).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile04);

            Frame miscFrame31 = new FrameBuilder(GetSubImage(3, 1)).WithScale(TileScale).Build();
            MapTileBuilder miscTile31 = new MapTileBuilder(miscFrame31).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile31);

            Frame miscFrame00 = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();
            MapTileBuilder miscTile00 = new MapTileBuilder(miscFrame00).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile00);

            Frame miscFrame02 = new FrameBuilder(GetSubImage(0, 2)).WithScale(TileScale).Build();
            MapTileBuilder miscTile02 = new MapTileBuilder(miscFrame02).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile02);

            Frame miscFrame03 = new FrameBuilder(GetSubImage(0, 3)).WithScale(TileScale).Build();
            MapTileBuilder miscTile03 = new MapTileBuilder(miscFrame03).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile03);

            Frame miscFrame30 = new FrameBuilder(GetSubImage(3, 0)).WithScale(TileScale).Build();
            MapTileBuilder miscTile30 = new MapTileBuilder(miscFrame30).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile30);

            Frame miscFrame11 = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();
            MapTileBuilder miscTile11 = new MapTileBuilder(miscFrame11).WithTileType(
                TileType.NOT_PASSABLE
            );
            ;
            mapTiles.Add(miscTile11);

            return mapTiles;
        }
    }
}
