using System;
using Raylib_cs;

namespace NovProjekt
{
    class Program
    {
         enum GameScreens { Start,Game,GameOver}
        static void Main(string[] args)
        {
           //Here are colors I want to use which aren't pre-existing in raylib
            Color ice = new Color(102, 204, 255, 255);
            Color ground = new Color(179, 230, 76, 255);


            GameScreens screen = GameScreens.Start;
            Raylib.InitWindow(900, 600, "November Falling"); 
            
             while(!Raylib.WindowShouldClose())
            {
                Player start = new Player();

                //Intro screen
                Raylib.BeginDrawing(); 
                if (screen == GameScreens.Start)
                { 
                    //Drawing 
                    Texture2D bg = Raylib.LoadTexture ("Bakgrundintro.png"); 
                    Raylib.DrawTexture(bg, 0,0 , Color.WHITE);

                    // Text on start screen
                    Raylib.DrawText("November Falling", 235, 50, 50, Color.BLACK);
                    Raylib.DrawText("What is your name", 300, 250, 35, Color.BLACK);
                    
                    // Game starts
                    if (Raylib.IsKeyDown(KeyboardKey.KEY_ENTER))
                    {
                        Raylib.EndDrawing(); 
                        screen = GameScreens.Game;
                    }
                }
                //Actual Game
                else if (screen == GameScreens.Game)
                {   
                    Player hello = new Player(); 
                    Ground first = new Ground();
                    Raylib.BeginDrawing();

                    //DRAWING
                    Raylib.ClearBackground(ice);
                    Raylib.DrawRectangle(0,600,900, 50, ground);


                    //LOGIC
                    if (Raylib.CheckCollisionRecs(first,  ))
                    {
                        Raylib.DrawText("works?", 100, 100, 64, Color.BLACK);
                    }

                        //Movement
                    Raylib.DrawRectangle (hello.xPos, hello.yPos, 20, 40, Color.WHITE);

                        if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                        {
                            if(!(hello.xPos > 600))
                            {
                            hello.xPos ++; 
                            }
                        }
                         if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                        {
                            if(!(hello.xPos < 0))
                            {
                            hello.xPos --; 
                            }
                        }
                         if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                        {
                            hello.yPos +=3; 
                        }

                    
                } 
                else (screen == GameScreens.GameOver)
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

                
       
    

