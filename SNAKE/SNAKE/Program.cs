using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            p1.Draw(p1.x, p1.y, p1.sym);

            Point p2 = new Point(4, 5, '#');
            p2.Draw(p2.x, p2.y, p2.sym);

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            foreach (int i in numList)
            {
                Console.WriteLine(i);
            }

            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();

            pList.Add(p1);
            pList.Add(p2);

            Point p1_my = new Point(10, 10, '!');
            p1_my.Draw(p1_my.x, p1_my.y, p1_my.sym);

            Point p2_my = new Point(10, 12, '@');
            p2_my.Draw(p2_my.x, p2_my.y, p2_my.sym);

            Point p3_my = new Point(10, 14, '#');
            p3_my.Draw(p3_my.x, p3_my.y, p3_my.sym);

            Point p4_my = new Point(10, 16, '$');
            p4_my.Draw(p4_my.x, p4_my.y, p4_my.sym);

            List<Point> pList_my = new List<Point>();

            pList_my.Add(p1_my);
            pList_my.Add(p2_my);
            pList_my.Add(p3_my);
            pList_my.Add(p4_my);

            Console.ReadLine();
        }

    }
}
