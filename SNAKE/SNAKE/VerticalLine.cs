using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKE
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int yBottom, int yTop, int x, char sym)
        {
        
            pList = new List<Point>();

            for (int y = yBottom; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);                
                pList.Add(p);

            }
        
        }

        public void Draw()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        
        }

    }
}
