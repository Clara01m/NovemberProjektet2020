using System;
using Raylib_cs;

namespace NovProjekt
{
    public class Player
    {

        public Rectangle first = new Rectangle(10,500, 50, 50);
        public Texture2D girl = Raylib.LoadTexture("gorlie.png");

        public string playerName; 
        public int hp = 5;
        // public int xPos = 0;
        // public int yPos = 50; 

        public Player()
        {
            first.width = girl.width;
            first.height = girl.height;
        }

        
    }
}
