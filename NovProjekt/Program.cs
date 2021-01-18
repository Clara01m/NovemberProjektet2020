using System;
using Raylib_cs;

namespace NovProjekt
{
    class Program
    {
         enum GameScreens { Start,Game}
        static void Main(string[] args)
        {
            //Decided on making a raylib platform game :)
            
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
                    Raylib.ClearBackground(ice);
                    //Texture2D bg = Raylib.LoadTexture ("Bakgrundintro.png"); 
                   
                    // Text on start screen
                    Raylib.DrawText("November Falling", 235, 50, 50, Color.BLACK);
                    Raylib.DrawText("What is your name", 300, 250, 35, Color.BLACK);
                    console.readline(); 
                    
                    // Game starts
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        screen = GameScreens.Game;
                    }
                }
                //Actual Game
                else if (screen == GameScreens.Game)
                {   
                    Player hello = new Player(); 
                    Ground first = new Ground();
                    

                    //Drawing
                    Raylib.ClearBackground(ice);
                    Raylib.DrawRectangle(0,0,900, 50, ground);


                    //LOGIC
                    if (Raylib.CheckCollisionRecs(first, second))
                    {
                        Raylib.DrawText("works?", 100, 100, 64, Color.BLACK);
                    }


                    Raylib.DrawTexture(girl, (int) hello.xPos, 10, Color.WHITE);

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

                Raylib.EndDrawing();
            }
        }         
     }          
}

                
       
    

