using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Pixel
    {
        public int x, y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(this.x, this.y);
            Console.Write(this.sym);
        }
    }
}
