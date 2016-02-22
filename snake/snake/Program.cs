using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Pixel p1 = new Pixel();

            p1.x = 12;
            p1.y = 6;
            p1.sym = '@';

            DrawPixel(p1);

            Pixel p2 = new Pixel();

            p2.x = 6;
            p2.y = 12;
            p2.sym = 'E';

            p2.Draw();

            Console.ReadLine();
        }

        static void DrawPixel(Pixel point)
        {
            Console.SetCursorPosition(point.x, point.y);
            Console.Write(point.sym);
        }
    }

    
}
