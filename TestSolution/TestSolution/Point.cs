using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Point
    {
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Point randomPoint()
        {
            // initialize random function
            Random rand = new Random();

            // generate coordinates between 0 and 1
            int x = rand.Next(0, 1);
            int y = rand.Next(0, 1);

            return new Point(x, y);
        }

        public bool isCloserTo(Point p, Point end)
        {
            double lengthPoint1ToEnd = Math.Sqrt(Math.Pow(end.y - y, 2) + Math.Pow(end.x - x, 2));
            double lengthPoint2ToEnd = Math.Sqrt(Math.Pow(end.y - p.y, 2) + Math.Pow(end.x - p.x, 2));

            // returns true if l1 smaller than or equal to l2
            return (lengthPoint1ToEnd <= lengthPoint2ToEnd);
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}

