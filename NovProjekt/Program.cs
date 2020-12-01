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
       
         GameScreens screen = GameScreens.Start;
            if (screen == GameScreens.Start)
            {
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER))
                {
                    screen = GameScreens.Game;
                }
                }
            else if (screen == GameScreens.Game)
            {
                 while(!Raylib.WindowShouldClose())
                {   //LOGIC
                    if(Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                    {
                        
                    }

                    
                    //DRAWING
                    Raylib.BeginDrawing(); 
                    //Raylib.ClearBackground(Blue);
               } 
            }

               
           
        }         
     }          
}

                
       
    

