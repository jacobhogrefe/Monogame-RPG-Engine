using App.Tilesets;
using Engine.Core;
using Engine.Scene;

namespace App.Maps
{
    public class TitleScreenMap : Map
    {

        public TitleScreenMap(ContentLoader contentLoader)
            : base("moon_screen_map.txt", new TitleTileset(contentLoader), contentLoader) { }
    }
}
