using System;
using Raylib_cs;

namespace NovProjekt
{
    class Program
    {
        enum GameScreens { Start, Game, GameOver }
        static void Main(string[] args)
        {
            //Here are colors I want to use which aren't pre-existing in raylib
            Color ice = new Color(102, 204, 255, 255);
            Color ground = new Color(179, 230, 76, 255);


            GameScreens screen = GameScreens.Start;
            Raylib.InitWindow(900, 600, "November Falling");

            Player start = new Player();
            
            while (!Raylib.WindowShouldClose())
            {

                //Intro screen
                Raylib.BeginDrawing();
                if (screen == GameScreens.Start)
                {
                    //Drawing 
                    Texture2D bg = Raylib.LoadTexture("Bakgrundintro.png");
                    Raylib.DrawTexture(bg, 0, 0, Color.WHITE);

                    // Text on start screen
                    Raylib.DrawText("November Falling", 235, 50, 50, Color.BLACK);
                    Raylib.DrawText("What is your name", 300, 250, 35, Color.BLACK);

                    // Game starts
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        // Raylib.EndDrawing();
                        screen = GameScreens.Game;
                        start = new Player();
                    }
                }
                //Actual Game
                else if (screen == GameScreens.Game)
                {
                    // Player hello = new Player();
                    Ground platform = new Ground();
                    

                    //DRAWING
                    Raylib.ClearBackground(ice);
                    Raylib.DrawRectangle(0, 550, 900, 50, ground);
                    Raylib.DrawTexture(start.girl, (int) start.first.x, (int) start.first.y, Color.WHITE);

                    //LOGIC
                    if (Raylib.CheckCollisionRecs(start.first, platform.second))
                    {
                        Raylib.DrawText("works?", 100, 100, 64, Color.BLACK);
                    }

                    //Movement

                     if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                     {
                         if (!(start.first.x > 600))
                         {
                             start.first.x++;
                         }
                     }
                     if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                     {
                         if (!(start.first.x < 0))
                         {
                             start.first.x--;
                         }
                     }
                     if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                     {
                         start.first.y += 3;
                    //     // implimentera tic funktion
                     }


                }
                else if (screen == GameScreens.GameOver)
                {
                    Raylib.BeginDrawing();
                    Raylib.ClearBackground(ice);
                    Raylib.DrawText("Game Over", 235, 50, 50, Color.BLACK);
                }

                Raylib.EndDrawing();
            }
        }
    }
}





