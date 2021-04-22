using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace BaseObjects
{
    /// <summary>
    /// The Default controls will be Keyboard supported
    /// </summary>
    public class InputManager
    {
        public Keys Left { get; set; }
        public Keys Right { get; set; }
        public Keys Up { get; set; }
        public Keys Down { get; set; }
        public Keys Interact { get; set; }
        public Keys Inventory { get; set; }
    }
}
