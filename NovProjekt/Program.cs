using System;
using Raylib_cs;

namespace NovProjekt
{
    class Program
    {
        enum GameScreens { Start, Game, GameOver }
        static void Main(string[] args)
        {
            Raylib.InitWindow(900, 600, "November Falling");
            //Here are colors I want to use which aren't pre-existing in raylib
            Color ice = new Color(102, 204, 255, 255);
            Color ground = new Color(179, 230, 76, 255);

            Raylib.SetTargetFPS(60);  
            
            // spawning all characters I will use
            Player start = new Player();
            Enemy beanie = new Enemy(); 
            Coin para = new Coin();
            Ground platform = new Ground();
            
            // starting console
            GameScreens screen = GameScreens.Start;
            
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
                        screen = GameScreens.Game;
                    }
                }
                //Actual Game
                else if (screen == GameScreens.Game)
                {     
                    //DRAWING
                    Raylib.ClearBackground(ice);
                    Raylib.DrawRectangle(0, 550, 900, 50, ground);
                        Raylib.DrawTexture(start.girl, (int) start.first.x, (int) start.first.y, Color.WHITE);
                        Raylib.DrawTexture(beanie.bean, (int) beanie.beanMan.x, (int) beanie.beanMan.y, Color.WHITE);
                        Raylib.DrawTexture(para.money, (int) para.gold.x, (int) para.gold.y, Color.WHITE);
                            Raylib.DrawText("money= " + para.value, 50, 50, 50, Color.BLACK);



                    //LOGIC
                    if (Raylib.CheckCollisionRecs(start.first, beanie.beanMan))
                    { 
                        start.hp -=1; 
                    }
                    if (start.hp < 0)
                    {
                         screen = GameScreens.GameOver; 
                    }

                     if (Raylib.CheckCollisionRecs(start.first,para.gold))
                    { 
                        para.value +=1;                   
                    }
            

                    //Movement

                     if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                     {
                         if (!(start.first.x > 800))
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
                    if (Raylib.CheckCollisionRecs(start.first, platform.second))
                    {                              
                        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                        {
                            start.first.y -=3;
                        }
                   
                      else
                      {
                           start.first.y +=1; 
                      } 
                    }


                }
                else if (screen == GameScreens.GameOver)
                {
                    Raylib.BeginDrawing();
                    Texture2D bg = Raylib.LoadTexture("Bakgrundintro.png");
                    Raylib.DrawTexture(bg, 0, 0, Color.WHITE);
                    Raylib.DrawText("Game Over", 235, 100, 90, Color.BLACK);
                }

                Raylib.EndDrawing();
            }
        }
    }
}





