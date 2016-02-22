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
            int x = 16, y = 8;
            char player = '@';

            DrawPixel(x, y, player);

            Console.ReadLine();
        }

        static void DrawPixel(int x, int y, char pixel)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(pixel);
        }
    }
}
