using System;

namespace FlappyBird
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (FlappyBird game = new FlappyBird())
            {
                game.Run();
            }
        }
    }
#endif
}

