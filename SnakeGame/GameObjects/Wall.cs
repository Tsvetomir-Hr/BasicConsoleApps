using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char WallSymbol = '\u25A0';
        public Wall(int leftX, int topY) 
            : base(leftX, topY)
        {
            this.InitializeWall();
        }

        private void InitializeWall()
        {
            this.InitializeHorizontalParts(0);
            this.InitializeHorizontalParts(TopY);
            this.InitializeVerticalParts(0);
            this.InitializeVerticalParts(LeftX);
         
            //Console.WriteLine();
        }

        private void InitializeVerticalParts(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                this.Draw(leftX, topY, WallSymbol);
            }
        }

        private void InitializeHorizontalParts(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                this.Draw(leftX, topY, WallSymbol);
            }
        }
    }
}
