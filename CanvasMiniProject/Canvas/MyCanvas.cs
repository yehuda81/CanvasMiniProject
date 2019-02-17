using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    public class MyCanvas
    {
        public const int MAXWIDTH = 800;
        public const int MAXHEIGHT = 600;
        static int buttonIndex = 0;
        static int maxButtons = 3;
        static MyButton[] buttons = new MyButton[maxButtons];       
        public static bool CreateNewButton(int x1, int y1, int x2, int y2)
        {
            if (buttonIndex == 3)
            {
                return false;
            }
            else
            {
                Point pnt1 = new Point(x1, y1);
                Point pnt2 = new Point(x2, y2);
                MyButton btn = new MyButton(pnt1, pnt2);                
                buttons[buttonIndex] = btn;                
                buttonIndex++;
                return true;
            }
        }
        public static bool MoveButton(int buttonNumber, int x, int y)
        {
            MyButton btn = buttons[buttonNumber];
            if (btn.GetBottomRight().GetX() + x < MAXWIDTH && btn.GetBottomRight().GetY() + y < MAXHEIGHT)
            {
                int x1 = btn.GetTopLeft().GetX() + x;
                int x2 = btn.GetBottomRight().GetX() + x;
                int y1 = btn.GetTopLeft().GetY() + y;
                int y2 = btn.GetBottomRight().GetY() + y;
                Point pnt1 = new Point(x1, y1);
                Point pnt2 = new Point(x2, y2);
                buttons[buttonNumber - 1].SetTopLeft(pnt1);
                buttons[buttonNumber - 1].SetBottomRight(pnt2);
                return true;
            }
            return false;
        }
        public static bool DelateLastButton()
        {
            if (buttonIndex > 0)
            {
                buttonIndex--;
                return true;
            }
            return false;
        }
        public static void ClearAllButtons()
        {
            if (buttonIndex > 0)
            {
                buttonIndex = 0;
            }
        }
        public static int GetCurrentNumberOfButtons()
        {
            return buttonIndex;
        }
        public static int GetMaxNumberOfButtons()
        {
            return maxButtons;
        }
        public static int GetTheMaxWidthOfAButton()
        {
            int maxWidthBtn = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].GetWidth() > maxWidthBtn)
                {
                    maxWidthBtn = buttons[i].GetWidth();
                }
            }
            return maxWidthBtn;
        }
        public static int GetTheMaxHeightOfAButton()
        {
            int maxHeightBtn = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (buttons[i].GetHeight() > maxHeightBtn)
                {
                    maxHeightBtn = buttons[i].GetHeight();
                }
            }
                return maxHeightBtn;            
        }
        public static void PrintButtons()
        {
            for (int i = 0; i < buttons.Length; i++)
            {
                Console.WriteLine($"Button {i + 1}: {buttons[i]}");
            }
        }
        public static bool IsPointInsideAButton(int x, int y)
        {
           // int pointInside = 0;
            for (int i = 0; i < buttons.Length; i++)
            {
                if (x > buttons[i].GetTopLeft().GetX() && x < buttons[i].GetBottomRight().GetX() && y < buttons[i].GetTopLeft().GetY() && y > buttons[i].GetBottomRight().GetY())
                {                    
                    return true;
                }                    
            }
            return false;
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
