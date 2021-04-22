using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using BaseObjects;
using GameState;
using System.Collections.Generic;

namespace MonoGame
{
    public class MonoGame : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        Player player;
        List<BaseGameObject> objects;
        BaseMap map = new BaseMap();


        public MonoGame()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            var texture = Content.Load<Texture2D>("wizardD");
            Globals.Red = Content.Load<Texture2D>("Red");
            Globals.Purple = Content.Load<Texture2D>("Purple");
            map.LoadMap();

            player = new Player(texture)
            {
                Input = new InputManager()
                {
                    Down = Keys.S,
                    Interact = Keys.F,
                    Inventory = Keys.Tab,
                    Left = Keys.A,
                    Right = Keys.D,
                    Up = Keys.W
                },
                Position = new Vector2(0, 0),
                Color = Color.White,
                Speed = 2
            };
            

            var player2 = new Player(texture)
            {
                Input = new InputManager()
                {
                    Down = Keys.Down,
                    Interact = Keys.F,
                    Inventory = Keys.Tab,
                    Left = Keys.Left,
                    Right = Keys.Right,
                    Up = Keys.Up
                },
                Position = new Vector2(100, 0),
                Color = Color.White
            };

            objects = new List<BaseGameObject>();
            objects.Add(player2);
            foreach (var i in map.GetGameObjects())
                objects.Add(i);
            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            player.Update(gameTime, objects);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            

            // TODO: Add your drawing code here
            _spriteBatch.Begin();

            foreach (var x in objects)
                x.Draw(_spriteBatch);
            player.Draw(_spriteBatch);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
