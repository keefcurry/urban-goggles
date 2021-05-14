using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Design;

namespace BaseObjects
{
    public class Camera
    {
        public Camera(GraphicsDeviceManager graphicsDevice)
        {
            CameraWidth = graphicsDevice.PreferredBackBufferWidth;
            CameraHeight = graphicsDevice.PreferredBackBufferHeight;
            Center = new Vector2(graphicsDevice.GraphicsDevice.Viewport.Width/2, graphicsDevice.GraphicsDevice.Viewport.Height/2);
        }

        // width & height
        public int CameraWidth = 0;
        public int CameraHeight = 0;

        //centor Position
        public Vector2 Center;

        //corner Positions
        public Vector2 TopLeft;
        public Vector2 TopRight;
        public Vector2 BottomLeft;
        public Vector2 BottomRight;

        public float CameraTrackingSpeed;
        public Vector2 CameraTrackingVelocity;

        public void FollowTarget(BaseGameObject target)
        {
            //make tracking algorithm
        }
    }
}
