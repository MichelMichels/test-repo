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

        // initialize random function
        public static Random rand = new Random();

        public Point nextPoint()
        {
            bool doubleZero = true;
            int z = 1000, a = 1000;

            // generate numbers between 0 and 1
            while (doubleZero)
            {
                z = RandomNumber(-1, 2);
                a = RandomNumber(-1, 2);

                if (!(z == 0 && a == 0)) doubleZero = false;
            }
            // return new point
            return new Point(this.x + z, this.y + a);
        }

        private static readonly object syncLock = new object();
        public static int RandomNumber(int min, int max)
        {
            lock (syncLock)
            { // synchronize
                return rand.Next(min, max);
            }
        }


        public void printPoint()
        {
            Console.WriteLine("x = {0}, y = {1}", this.x, this.y);
        }

        public int x { get; set; }
        public int y { get; set; }
    }
}

