using System;

namespace MonoGame
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MonoGame())
                game.Run();
        }
    }
}
