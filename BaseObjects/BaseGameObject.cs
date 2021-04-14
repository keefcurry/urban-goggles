using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BaseObjects
{
    public class BaseGameObject : IBaseGameObject
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Vector2 Origin { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public Rectangle BoundingBox { get; set; }

        public InputManager Input { get; set; }

        // FIXME !!!
        private void Move()
        {
            var key = Keyboard.GetState();
            if (key.IsKeyDown(Input.Left))
                Position = new Vector2(Position.X -1, Position.Y);
            if (key.IsKeyDown(Input.Right))
                Position = new Vector2(Position.X + 1, Position.Y);
            if (key.IsKeyDown(Input.Down))
                Position = new Vector2(Position.X, Position.Y + 1);
            if (key.IsKeyDown(Input.Up))
                Position = new Vector2(Position.X, Position.Y - 1);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            
        }

        public void Update(GameTime gameTime)
        {
            
        }

        #region Collision
        private bool CheckLeftSide(Rectangle rectangle)
        {
            return (BoundingBox.Left < rectangle.Right &&
                    BoundingBox.Right > rectangle.Left && 
                    BoundingBox.Top > rectangle.Bottom &&
                    BoundingBox.Bottom < rectangle.Top);
        }

        private bool CheckRightSide(Rectangle rectangle)
        {
            return (BoundingBox.Left < rectangle.Right &&
                    BoundingBox.Right > rectangle.Left &&
                    BoundingBox.Top > rectangle.Bottom &&
                    BoundingBox.Bottom < rectangle.Top);
        }

        private bool CheckTopSide(Rectangle rectangle)
        {
            return (BoundingBox.Top > rectangle.Bottom &&
                    BoundingBox.Bottom < rectangle.Top && 
                    BoundingBox.Left < rectangle.Right &&
                    BoundingBox.Right > rectangle.Left);
        }

        private bool CheckBotSide(Rectangle rectangle)
        {
            return (BoundingBox.Top < rectangle.Bottom &&
                    BoundingBox.Bottom > rectangle.Top &&
                    BoundingBox.Left < rectangle.Right &&
                    BoundingBox.Right > rectangle.Left);
        }


        #endregion
    }
}
