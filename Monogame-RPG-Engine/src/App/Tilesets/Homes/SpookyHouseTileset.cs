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
    public class SpookyHouseTileset : Tileset
    {
        public SpookyHouseTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.SPOOKY_HOUSE_TILESET), 16, 16, 3) { }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
            //back wall 1
            Frame backwall1Frame = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();

            MapTileBuilder backwall1Tile = new MapTileBuilder(backwall1Frame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(backwall1Tile);

            // back wall With window
            Frame backwindowFrame = new FrameBuilder(GetSubImage(0, 1))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder backwindowTile = new MapTileBuilder(backwindowFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(backwindowTile);

            //Front carpet
            Frame frontcarpetFrame = new FrameBuilder(GetSubImage(0, 2))
                .WithScale(TileScale)
                .Build();

            MapTileBuilder frontcarpetTile = new MapTileBuilder(frontcarpetFrame);

            mapTiles.Add(frontcarpetTile);

            //ground 1
            Frame ground1Frame = new FrameBuilder(GetSubImage(1, 0)).WithScale(TileScale).Build();

            MapTileBuilder ground1Tile = new MapTileBuilder(ground1Frame).WithTileType(
                TileType.PASSABLE
            );

            mapTiles.Add(ground1Tile);

            //ground 2
            Frame ground2Frame = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();

            MapTileBuilder ground2Tile = new MapTileBuilder(ground2Frame).WithTileType(
                TileType.PASSABLE
            );

            mapTiles.Add(ground2Tile);

            //side wall
            Frame sidewallFrame = new FrameBuilder(GetSubImage(1, 2)).WithScale(TileScale).Build();

            MapTileBuilder sidewallTile = new MapTileBuilder(sidewallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(sidewallTile);

            //door
            Frame doorFrame = new FrameBuilder(GetSubImage(2, 0)).WithScale(TileScale).Build();

            MapTileBuilder doorTile = new MapTileBuilder(doorFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(doorTile);

            //front wall
            Frame frontwallFrame = new FrameBuilder(GetSubImage(2, 1)).WithScale(TileScale).Build();

            MapTileBuilder frontwallTile = new MapTileBuilder(frontwallFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(frontwallTile);

            //candy dish
            Frame candydishFrame = new FrameBuilder(GetSubImage(2, 2)).WithScale(TileScale).Build();

            MapTileBuilder candydishTile = new MapTileBuilder(candydishFrame).WithTileType(
                TileType.NOT_PASSABLE
            );

            mapTiles.Add(candydishTile);
            return mapTiles;
        }
    }
}
