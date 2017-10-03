using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine vLine = new VerticalLine(5, 3, 8, '*');
            HorizontalLine hLine = new HorizontalLine(3, 9, 8, '*');
            vLine.Draw();
            hLine.Draw();

            Console.ReadLine();
        }
    }
}
