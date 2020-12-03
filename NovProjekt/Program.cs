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
            
            Color ste = new Color(255, 128, 0, 255);
            
            GameScreens screen = GameScreens.Start;
            Raylib.InitWindow(900, 600, "November Falling"); 
            
             while(!Raylib.WindowShouldClose())
            {


                Raylib.BeginDrawing(); 
                if (screen == GameScreens.Start)
                { 
                    //Drawing 
                    Raylib.ClearBackground(ste);
                    
                    Raylib.DrawText("November Falling", 20, 20, 20, Color.BLUE);

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
                            
                        }


                        //DRAWING
                        // Raylib.BeginDrawing(); 
                        //Raylib.ClearBackground(Blue);
                } 

                Raylib.EndDrawing();
            }
        }         
     }          
}

                
       
    

