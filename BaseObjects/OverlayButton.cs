using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseObjects
{
    public class OverlayButton : BaseGameObject
    {
        public Boolean active = false;
        public Action Action;
        public OverlayButton(Texture2D texture) 
            : base(texture)
        {
            Texture = texture;
        }

        private void SwapTexture()
        {
            var texture = Texture;
            Texture = Texure2;
            Texure2 = texture;
        }

        public void CheckBox()
        {
            if (active)
            {
                active = false;
                SwapTexture();
                Action.Invoke();
            }
            else if (!active)
            {
                active = true;
                SwapTexture();
            }
        }
    }
}
