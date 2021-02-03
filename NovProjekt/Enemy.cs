using System;
using Raylib_cs;

namespace NovProjekt
{
    public class Enemy
    {
        public Rectangle first = new Rectangle(10, 10, 50, 50);
        public Texture2D girl = Raylib.LoadTexture("gorlie.png");
        
        public int x; 
        public int y; 
        int attack; 
        int enemyHp;
        public int enemySpeed;
        
    }
}

