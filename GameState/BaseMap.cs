using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Design;
using BaseObjects;
using System.Collections.Generic;

namespace GameState
{
    public class BaseMap
    {
        public int MapId;
        public int[,] Tiles;
        public List<BaseGameObject> MapObjects;
        //public BaseGameObject[] NPC;

        public virtual void LoadMap(/*This is going to be the import from content*/)
        {
            Tiles = new int[,] 
            { 
                { 1,1,1,1,1,1,1,1,1 }, 
                { 1,0,0,0,0,0,0,0,1 }, 
                { 1,0,1,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,1,0,1 },
                { 1,0,0,0,0,0,0,0,1 },
                { 1,0,0,0,0,0,0,0,1 },
                { 1,1,1,1,1,1,1,1,1 },
            };

            MapObjects = new List<BaseGameObject>();
            for(int i = 0; i < Tiles.GetLength(0); i++)
            {
                for(int j = 0; j < Tiles.GetLength(1); j++)
                {
                    if (Tiles[i, j] == 1)
                        MapObjects.Add(new BaseGameObject(Globals.Red)
                        {
                            Position = new Vector2(j * 32, i * 32),
                            Color = Color.White,
                            Height = 32,
                            Width = 32
                        });
                    if (Tiles[i, j] == 0)
                        MapObjects.Add(new BaseGameObject(Globals.Purple)
                        {
                            Position = new Vector2(j * 32, i * 32),
                            Color = Color.White,
                            Height = 32,
                            Width = 32,
                            Collidable = false
                        });
                }
            }
        }

        public virtual List<BaseGameObject> GetGameObjects()
        {
            return MapObjects;
        }
        

        //public virtual void Draw(SpriteBatch spriteBatch)
        //{
        //    for (int i = 0; i < MapObjects.Count; i++)
        //    {
        //       MapObjects[i].Draw(spriteBatch);
        //    }
        //}
    }
}
