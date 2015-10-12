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

        public int x { get; set; }
        public int y { get; set; }
    }
}

