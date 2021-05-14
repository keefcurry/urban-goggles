using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using BaseObjects;

namespace BaseObjects
{
    public class Player : BaseGameObject
    {
        public Player(Texture2D texture) 
            : base(texture)
        {

        }
        private void Move()
        {
            
            if (Keyboard.GetState().IsKeyDown(Input.Left))
                Velocity.X -= Speed;
            if (Keyboard.GetState().IsKeyDown(Input.Right))
                Velocity.X += Speed;
            if (Keyboard.GetState().IsKeyDown(Input.Down))
                Velocity.Y += Speed;
            if (Keyboard.GetState().IsKeyDown(Input.Up))
                Velocity.Y -= Speed;
        }

        public override void Update(GameTime gameTime, List<BaseGameObject> objects)
        {
            Move();

            foreach (var sprite in objects)
            {
                if (sprite == this)
                    continue;
                if(sprite.Collidable == true) {
                if ((Velocity.X > 0 && IsTouchingLeft(sprite)) ||
                    (Velocity.X < 0 & IsTouchingRight(sprite)))
                    Velocity.X = 0;
                if((Velocity.Y > 0 && IsTouchingTop(sprite)) || 
                    (Velocity.Y < 0 & IsTouchingBottom(sprite)))
                    Velocity.Y = 0;   
                }
            }
            Position += Velocity;
            Velocity = Vector2.Zero;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
    }
}
