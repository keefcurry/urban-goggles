using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BaseObjects
{
    public interface IBaseGameObject
    {
        void Draw(SpriteBatch spriteBatch);
        void Update(GameTime gameTime, List<BaseGameObject> objects);
    }
}
