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
            //Ska nu lära mig hur man gör en startmeny och sedan hur man använder den i spelet
            
            Color ice = new Color(102, 204, 255, 255);
            

            GameScreens screen = GameScreens.Start;
            Raylib.InitWindow(900, 600, "November Falling"); 
            
             while(!Raylib.WindowShouldClose())
            {


                Raylib.BeginDrawing(); 
                if (screen == GameScreens.Start)
                { 
                    //Drawing 
                    Raylib.ClearBackground(ice);
                    // Text on start screen
                    Raylib.DrawText("November Falling", 235, 50, 50, Color.BLACK);
                    Raylib.DrawText("What is your name", 300, 250, 35, Color.BLACK);
                    Console.ReadLine();
                    // Game starts
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        screen = GameScreens.Game;
                    }
                }
                else if (screen == GameScreens.Game)
                {   
                    //LOGIC
                        if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                        {
                            xPos +1; 
                        }
                         if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                        {
                            
                        }
                         if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                        {
                            
                        }

                    
                } 

                Raylib.EndDrawing();
            }
        }         
     }          
}

                
       
    

