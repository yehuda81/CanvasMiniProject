using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCanvas.CreateNewButton(0, 8, 8, 0);
            MyCanvas.CreateNewButton(1, 16, 10, 6);
            MyCanvas.CreateNewButton(22, 45, 40, 20);
            MyCanvas.MoveButton(2, 3, 5);
            Console.WriteLine(MyCanvas.GetCurrentNumberOfButtons());
            Console.WriteLine(MyCanvas.GetMaxNumberOfButtons());            
            Console.WriteLine(MyCanvas.GetTheMaxWidthOfAButton());
            Console.WriteLine(MyCanvas.GetTheMaxHeightOfAButton());
            MyCanvas.PrintButtons();
            Console.WriteLine(MyCanvas.IsPointInsideAButton(30,25));
        }
    }
}
