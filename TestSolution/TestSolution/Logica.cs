using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution
{
    class Logica
    {
        public Logica(Point beginPoint, Point endPoint)
        {
            this.beginPoint = beginPoint;
            this.endPoint = endPoint;
            this.Steps = new List<int>();
        }

        public bool start()
        {
            Point nextP = beginPoint.nextPoint();
            bool success = false;

            int stepCounter = 0;
            while (!success && stepCounter < 5000)
            {
                if (nextP.x == endPoint.x && nextP.y == endPoint.y)
                {
                    success = true;
                }
                Console.Write(stepCounter + ": ");
                nextP.printPoint();
                nextP = nextP.nextPoint();
                stepCounter++;
            }

            if(stepCounter != 5000) Steps.Add(stepCounter);

            return success;
        }

        public List<int> Steps { get; set; }
        public Point beginPoint { get; set; }
        public Point endPoint { get; set; }
    }
}
