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
            Color ground = new Color(179, 230, 76, 255);
            

            GameScreens screen = GameScreens.Start;
            Raylib.InitWindow(900, 600, "November Falling"); 
            
             while(!Raylib.WindowShouldClose())
            {


                Raylib.BeginDrawing(); 
                if (screen == GameScreens.Start)
                { 
                    //Drawing 
                    Raylib.ClearBackground(ice);
                    //Texture2D bg = Raylib.LoadTexture ("Bakgrundintro.png"); 
                   
                    // Text on start screen
                    Raylib.DrawText("November Falling", 235, 50, 50, Color.BLACK);
                    Raylib.DrawText("What is your name", 300, 250, 35, Color.BLACK);
                    
                    // Game starts
                    if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                    {
                        screen = GameScreens.Game;
                    }
                }
                else if (screen == GameScreens.Game)
                {   
                    //Drawing
                    Raylib.DrawRectangle(0,0,900, 50, ground);
                    //LOGIC
                        if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                        {
                            if(!xPos > 600)
                            {
                            xPos ++; 
                            }
                        }
                         if(Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                        {
                            if(!xPos < 0)
                            {
                            xPos --; 
                            }
                        }
                         if(Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                        {
                            yPos +3; 
                        }

                    
                } 

                Raylib.EndDrawing();
            }
        }         
     }          
}

                
       
    

