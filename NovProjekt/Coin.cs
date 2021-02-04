using System;
using Raylib_cs;

namespace NovProjekt
{
    public class Coin
    {

         public Rectangle gold = new Rectangle(350,500, 30, 30);
        public Texture2D money = Raylib.LoadTexture("coin.png");
       
        public int value = 0;

        
        
        
        
    }
}
