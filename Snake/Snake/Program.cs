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
            /*
            List <Point> pList = new List<Point>();

            for(int i = 0; i < 4; i++)
            {
                Point p = new Point(i, i+3, '*');
                pList.Add(p);
            }
            
            for(int j = 0; j < 4; j++)
            {
                pList[j].Draw();
            }
            */

            VerticalLine vLine = new VerticalLine(5, 3, 8, '*');
            vLine.Draw();

            Console.ReadLine();
        }
    }
}
