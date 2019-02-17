using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    internal class Point
    {
        int x;
        int y;

        internal Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX()
        {
            return x;
        }
        internal int GetY()
        {
            return y;
        }
        internal void SetX(int x)
        {
            if (x < 0 || x > MyCanvas.MAXWIDTH)
            {
                Console.WriteLine("Illegal X");
            }
            else
            {
                this.x = x;
            }
        }
        internal void SetY(int y)
        {
            if (y < 0 || x > MyCanvas.MAXHEIGHT)
            {
                Console.WriteLine("Illegal Y");
            }
            else
            {
                this.y = y;
            }
        }

        public override string ToString()
        {
            return $"x = {this.x} y = {this.y}";
        }
    }
}
