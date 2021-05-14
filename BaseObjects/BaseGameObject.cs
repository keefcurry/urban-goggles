using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace BaseObjects
{
    public class BaseGameObject : IBaseGameObject
    {
        public BaseGameObject(Texture2D texture)
        {
            Texture = texture;
        }

        public bool Collidable = true;
        public Texture2D Texture;
        public Texture2D Texure2;
        public Vector2 Position;
        public int Width;
        public int Height;
        public float Speed;
        public Color Color;
        public InputManager Input;
        public Vector2 Origin { get { return new Vector2(Position.X + 16, Position.Y + 16); } }
        public Vector2 Velocity = Vector2.Zero;
        public Rectangle BoundingBox { get { return new Rectangle(x: (int)Position.X, y: (int)Position.Y, width: Texture.Width, height: Texture.Height); } }


        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture, BoundingBox, Color);
        }

        public virtual void Update(GameTime gameTime, List<BaseGameObject> objects)
        {

        }

        #region Collision
        protected bool IsTouchingLeft(BaseGameObject sprite)
        {
            return (BoundingBox.Right + Velocity.X > sprite.BoundingBox.Left &&
                    BoundingBox.Left < sprite.BoundingBox.Left &&                     
                    BoundingBox.Top < sprite.BoundingBox.Bottom &&
                    BoundingBox.Bottom > sprite.BoundingBox.Top);
        }

        protected bool IsTouchingRight(BaseGameObject sprite)
        {
            return (BoundingBox.Left + Velocity.X < sprite.BoundingBox.Right &&
                    BoundingBox.Right > sprite.BoundingBox.Right &&
                    BoundingBox.Top < sprite.BoundingBox.Bottom &&
                    BoundingBox.Bottom > sprite.BoundingBox.Top);
        }

        protected bool IsTouchingTop(BaseGameObject sprite)
        {
            return (BoundingBox.Top < sprite.BoundingBox.Top &&
                    BoundingBox.Bottom + Velocity.Y > sprite.BoundingBox.Top && 
                    BoundingBox.Left < sprite.BoundingBox.Right &&
                    BoundingBox.Right > sprite.BoundingBox.Left);
        }

        protected bool IsTouchingBottom(BaseGameObject sprite)
        {
            return (BoundingBox.Top + Velocity.Y < sprite.BoundingBox.Bottom &&
                    BoundingBox.Bottom > sprite.BoundingBox.Bottom &&
                    BoundingBox.Left < sprite.BoundingBox.Right &&
                    BoundingBox.Right > sprite.BoundingBox.Left);
        }


        #endregion
    }
}
