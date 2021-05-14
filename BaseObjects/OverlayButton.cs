using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseObjects
{
    public class OverlayButton : BaseGameObject
    {
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
            SwapTexture();
            Action.Invoke();
        }

        public Action Action;
    }
}
