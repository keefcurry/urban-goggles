using BaseObjects;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameState
{
    class GameState : BaseState
    {
        Player[] players;
        BaseMap currentMap;
        public GameState()
        {
            players = new Player[1];
            currentMap = new BaseMap();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public override void Initialize()
        {
            throw new NotImplementedException();
        }

        public override void LoadContent()
        {
            throw new NotImplementedException();
        }

        public override void Update(GameTime gameTime)
        {
            
        }
    }
}
