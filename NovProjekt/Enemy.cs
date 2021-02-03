using System;
using Raylib_cs;

namespace NovProjekt
{
    public class Enemy
    {
        public Rectangle beanMan = new Rectangle(800, 500, 50, 50);
        public Texture2D bean = Raylib.LoadTexture("mrBean.png");

         
        public int attack = 1; 
        public int enemySpeed = 1;
        
    }
}

