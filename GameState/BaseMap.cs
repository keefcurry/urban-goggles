using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Design;
using BaseObjects;

namespace GameState
{
    public class BaseMap
    {
        public int MapId;
        public BaseGameObject[] Tiles;
        //public BaseGameObject[] MapObjects;
        //public BaseGameObject[] NPC;

        public virtual void LoadMap(/*This is going to be the import from content*/)
        {
            // this will populate each tile with their data
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach (var tile in Tiles)
            {
                
            }
        }
    }
}
