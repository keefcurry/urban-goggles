using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;
using BaseObjects;

namespace GameState
{
    public class BaseOverlay
    {
        List<OverlayButton> OverlayObjects = new List<OverlayButton>();

        public BaseOverlay()
        {
            OverlayObjects.Add(new OverlayButton(Globals.Empty)
            {
                Texure2 = Globals.Filled,
                Color = Color.White,
                Height = 32,
                Width = 32,
                Position = new Vector2(500, 400),
                Action = test
            });
        }

        public void test()
        {

        }

        public void AddNewObjectAndAction(OverlayButton gameObject, Action action)
        {
            gameObject.Action = new Action(action);
            OverlayObjects.Add(gameObject);
        }
        public void AddBaseObject(OverlayButton gameObject)
        {
            OverlayObjects.Add(gameObject);
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            foreach(var obj in OverlayObjects)
            {
                obj.Draw(spriteBatch);
            }
        }

        public virtual void Update(GameTime gameTime)
        {
           
            foreach(var obj in OverlayObjects)
            { 
                if(Mouse.GetState().LeftButton == ButtonState.Pressed 
                    && obj.BoundingBox.Contains(Mouse.GetState().Position)
                    && obj.Action != null)
                {
                    obj.CheckBox();
                }
            }
        }
    }
}
