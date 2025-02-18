// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

using Raylib_cs;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        private Texture2D backgroundimage;

        public void Setup()
        {
            Window.SetTitle("Chilly Beans");
            Window.SetSize(400, 400);
            Window.TargetFPS = 150;    // Set the target FPS to 150 to combat flickering of image on screen

            // Load background image
            Image img = Raylib.LoadImage("C:\\Users\\Blair\\OneDrive\\Desktop\\Visual Studio-Blair's Projects\\Background Images\\image001.png");
            backgroundimage = Raylib.LoadTextureFromImage(img);
            Raylib.UnloadImage(img);
        }

        public void Update()
        {
            Raylib.BeginDrawing();
            Window.ClearBackground(Color.Black);

            // Draw the image to background
            Raylib.DrawTexture(backgroundimage, 0, 0, Raylib_cs.Color.White);

            Raylib.EndDrawing();
        }
    }

}
