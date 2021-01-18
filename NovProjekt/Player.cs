using System;
using Raylib_cs;

namespace NovProjekt
{
    public class Player
    {

        public Rectangle first = new Rectangle(10, 10, 50, 50);
        first = Texture2D girl = Raylib.LoadTexture("borrowedGirl.png");

        public string playerName; 
        public int hp = 5;
        public int xPos = 0;
        public int yPos = 50; 

        
    }
}
