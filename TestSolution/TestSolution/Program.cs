using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Point beginPoint = new Point(0, 0);
            Point endPoint = new Point(10, 0);

            Point random = new Point(5, 0);

            // should be true
            Console.WriteLine(random.isCloserTo(beginPoint, endPoint));
            Console.ReadLine();
        }
    }
}
