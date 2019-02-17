using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    internal class MyButton
    {
        protected Point topleft;
        protected Point bottomRight;
        int width;
        int height;

        internal MyButton(Point topleft, Point bottomRight)
        {
            this.topleft = topleft;
            this.bottomRight = bottomRight;
        }
        internal int GetWidth()
        {
            width = GetBottomRight().GetX() - GetTopLeft().GetX();
            return width;
        }
        internal int GetHeight()
        {
            height = GetTopLeft().GetY() - GetBottomRight().GetY();
            return height;
        }
        internal bool SetTopLeft(Point pnt)
        {
            if (topleft.GetX() < bottomRight.GetX() && topleft.GetY() > bottomRight.GetY())
            {
                this.topleft = pnt;
                this.width = bottomRight.GetX() - topleft.GetX();
                this.height = topleft.GetY() - bottomRight.GetY();
                return true;
            }
            else
            {
                Console.WriteLine("Illegal TopLeft Point");
                return false;
            }
        }
        internal bool SetBottomRight(Point pnt)
        {
            if (topleft.GetX() < bottomRight.GetX() && topleft.GetY() > bottomRight.GetY())
            {
                this.bottomRight = pnt;
                this.width = bottomRight.GetX() - topleft.GetX();
                this.height = topleft.GetY() - bottomRight.GetY();
                return true;
            }
            else
            {
                Console.WriteLine("Illegal BottomRight Point");
                return false;
            }
        }
        internal Point GetTopLeft()
        {
            return topleft;
        }
        internal Point GetBottomRight()
        {
            return bottomRight;
        }

        public override string ToString()
        {
            return $"Button TopLeft : {this.topleft}, bottomRight : {this.bottomRight}, Width : { this.width }, Height : { this.height }";
        }
    }
}
