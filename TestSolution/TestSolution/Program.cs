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

            Logica l = new Logica(beginPoint, endPoint);

            int succesCounter = 0;
            List<int> steps = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if (l.start())
                {
                    succesCounter++;
                    
                } 
            }

            Console.WriteLine("{0} wins!", succesCounter);
            foreach (var step in l.Steps)
            {
                Console.WriteLine("Steps: {0}", step);
            }

            Console.ReadLine();
        }
    }
}
