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
    public class TitleTileset : Tileset
    {
        public TitleTileset(ContentLoader contentLoader)
            : base(contentLoader.LoadTexture(GraphicsHelper.TITLE_TILESET), 16, 16, 3) { }

        public override List<MapTileBuilder> DefineTiles()
        {
            List<MapTileBuilder> mapTiles = new List<MapTileBuilder>();
            // Letter M
            Frame letterMFrame = new FrameBuilder(GetSubImage(0, 0)).WithScale(TileScale).Build();

            MapTileBuilder letterM = new MapTileBuilder(letterMFrame);

            mapTiles.Add(letterM);

            // moon part 8 (I started doing these in this confusing order because its the
            // order the coordinates were done in the common file
            // that was my reference. maybe Ill put these in a more logical order when I'm
            // done, but it is much more likely that I will not.
            // Furthermore, if Star Wars can start on episode 4, I can start coding my moon
            // Tiles at 8.
            Frame moon8Frame = new FrameBuilder(GetSubImage(3, 0)).WithScale(TileScale).Build();

            MapTileBuilder moon8Tile = new MapTileBuilder(moon8Frame);

            mapTiles.Add(moon8Tile);

            // moon part 1

            Frame moon1Frame = new FrameBuilder(GetSubImage(1, 3)).WithScale(TileScale).Build();

            MapTileBuilder moon1Tile = new MapTileBuilder(moon1Frame);

            mapTiles.Add(moon1Tile);

            //moon part 2

            Frame moon2Frame = new FrameBuilder(GetSubImage(1, 4)).WithScale(TileScale).Build();

            MapTileBuilder moon2Tile = new MapTileBuilder(moon2Frame);

            mapTiles.Add(moon2Tile);

            //moon part 3

            Frame moon3Frame = new FrameBuilder(GetSubImage(2, 0)).WithScale(TileScale).Build();

            MapTileBuilder moon3Tile = new MapTileBuilder(moon3Frame);

            mapTiles.Add(moon3Tile);

            //moon part 4

            Frame moon4Frame = new FrameBuilder(GetSubImage(2, 1)).WithScale(TileScale).Build();

            MapTileBuilder moon4Tile = new MapTileBuilder(moon4Frame);

            mapTiles.Add(moon4Tile);

            //moon part 5

            Frame moon5Frame = new FrameBuilder(GetSubImage(2, 2)).WithScale(TileScale).Build();

            MapTileBuilder moon5Tile = new MapTileBuilder(moon5Frame);

            mapTiles.Add(moon5Tile);

            //moon part 6

            Frame moon6Frame = new FrameBuilder(GetSubImage(2, 3)).WithScale(TileScale).Build();

            MapTileBuilder moon6Tile = new MapTileBuilder(moon6Frame);

            mapTiles.Add(moon6Tile);

            //moon part 7

            Frame moon7Frame = new FrameBuilder(GetSubImage(2, 4)).WithScale(TileScale).Build();

            MapTileBuilder moon7Tile = new MapTileBuilder(moon7Frame);

            mapTiles.Add(moon7Tile);

            // Letter O
            Frame letterOFrame = new FrameBuilder(GetSubImage(0, 1)).WithScale(TileScale).Build();

            MapTileBuilder letterO = new MapTileBuilder(letterOFrame);

            mapTiles.Add(letterO);

            // Letter N

            Frame letterNFrame = new FrameBuilder(GetSubImage(0, 2)).WithScale(TileScale).Build();

            MapTileBuilder letterN = new MapTileBuilder(letterNFrame);

            mapTiles.Add(letterN);

            // Letter V

            Frame letterVFrame = new FrameBuilder(GetSubImage(0, 3)).WithScale(TileScale).Build();

            MapTileBuilder letterV = new MapTileBuilder(letterVFrame);

            mapTiles.Add(letterV);

            // Letter A

            Frame letterAFrame = new FrameBuilder(GetSubImage(0, 4)).WithScale(TileScale).Build();

            MapTileBuilder letterA = new MapTileBuilder(letterAFrame);

            mapTiles.Add(letterA);

            // Letter L

            Frame letterLFrame = new FrameBuilder(GetSubImage(1, 0)).WithScale(TileScale).Build();

            MapTileBuilder letterL = new MapTileBuilder(letterLFrame);

            mapTiles.Add(letterL);

            // Letter E

            Frame letterEFrame = new FrameBuilder(GetSubImage(1, 1)).WithScale(TileScale).Build();

            MapTileBuilder letterE = new MapTileBuilder(letterEFrame);

            mapTiles.Add(letterE);

            // Letter Y

            Frame letterYFrame = new FrameBuilder(GetSubImage(1, 2)).WithScale(TileScale).Build();

            MapTileBuilder letterY = new MapTileBuilder(letterYFrame);

            mapTiles.Add(letterY);

            // New Grass

            Frame newGrassFrame = new FrameBuilder(GetSubImage(3, 1)).WithScale(TileScale).Build();

            MapTileBuilder newGrass = new MapTileBuilder(newGrassFrame);

            mapTiles.Add(newGrass);

            // Pine Tree

            Frame pineTreeFrame = new FrameBuilder(GetSubImage(3, 2)).WithScale(TileScale).Build();

            MapTileBuilder pineTree = new MapTileBuilder(pineTreeFrame);

            mapTiles.Add(pineTree);

            // Pine Tree

            Frame jackOFrame = new FrameBuilder(GetSubImage(3, 3)).WithScale(TileScale).Build();

            MapTileBuilder jackO = new MapTileBuilder(jackOFrame);

            mapTiles.Add(jackO);

            // big ole red mushroom

            Frame bigShroomFrame = new FrameBuilder(GetSubImage(3, 4)).WithScale(TileScale).Build();

            MapTileBuilder bigShroom = new MapTileBuilder(bigShroomFrame);

            mapTiles.Add(bigShroom);

            // Night sky 1 (different star placement than night sky 2 to give sky more
            // realistic look when use din combination)

            Frame nightSky1Frame = new FrameBuilder(GetSubImage(4, 0)).WithScale(TileScale).Build();

            MapTileBuilder nightSky1 = new MapTileBuilder(nightSky1Frame);

            mapTiles.Add(nightSky1);

            // Night sky 2 (different star placement than night sky 1 to give sky more
            // realistic look when use din combination)

            Frame nightSky2Frame = new FrameBuilder(GetSubImage(4, 1)).WithScale(TileScale).Build();

            MapTileBuilder nightSky2 = new MapTileBuilder(nightSky2Frame);

            mapTiles.Add(nightSky2);

            // Twinkling star/planet?

            // I wanted to make it so these don't all blink at the same time. I'm sure there
            // is a better way to do it than creating a new frame for every star I place,
            // but I couldn't figure it out so I went With this lazy solution.

            Frame[] twinkleStarFrame = new Frame[]
            {
                new FrameBuilder(GetSubImage(4, 2), 300).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(4, 3), 200).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(4, 4), 200).WithScale(TileScale).Build(),
            };

            MapTileBuilder twinkleStarTile = new MapTileBuilder(twinkleStarFrame);

            mapTiles.Add(twinkleStarTile);

            // Twinkling star/planet?

            // I wanted to make it so these don't all blink at the same time. I'm sure there
            // is a better way to do it than creating a new frame for every star I place,
            // but I couldn't figure it out so I went With this lazy solution.

            Frame[] twinkleStarFrame2 = new Frame[]
            {
                new FrameBuilder(GetSubImage(4, 2), 200).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(4, 3), 200).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(4, 4), 200).WithScale(TileScale).Build(),
            };

            MapTileBuilder twinkleStarTile2 = new MapTileBuilder(twinkleStarFrame2);

            mapTiles.Add(twinkleStarTile2);

            // Twinkling star/planet?

            // I wanted to make it so these don't all blink at the same time. I'm sure there
            // is a better way to do it than creating a new frame for every star I place,
            // but I couldn't figure it out so I went With this lazy solution.

            Frame[] twinkleStarFrame3 = new Frame[]
            {
                new FrameBuilder(GetSubImage(4, 2), 400).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(4, 3), 200).WithScale(TileScale).Build(),
                new FrameBuilder(GetSubImage(4, 4), 200).WithScale(TileScale).Build(),
            };

            MapTileBuilder twinkleStarTile3 = new MapTileBuilder(twinkleStarFrame3);

            mapTiles.Add(twinkleStarTile3);
            return mapTiles;
        }
    }
}
