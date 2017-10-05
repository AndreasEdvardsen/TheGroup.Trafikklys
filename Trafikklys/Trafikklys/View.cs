using System;
using System.Threading;

namespace Trafikklys
{
    class View
    {
        private Crossroad crossroad;

        public View(Crossroad crossroad)
        {
            this.crossroad = crossroad;
        }

        public void Show(Start start, Exit exit)
        {
            Console.Clear();
            Console.WriteLine("The car in the biggest queue came from " + start.Name + " to " + exit.Name);


            Console.Write("Top lane: ");
            for (var indexTop = 0; indexTop < crossroad.Top.Start.carList.Count; indexTop++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Right lane: ");
            for (var indexRight = 0; indexRight < crossroad.Right.Start.carList.Count; indexRight++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Bottom lane: ");
            for (var indexBottom = 0; indexBottom < crossroad.Bottom.Start.carList.Count; indexBottom++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Left lane: ");
            for (var indexLeft = 0; indexLeft < crossroad.Left.Start.carList.Count; indexLeft++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Thread.Sleep(500);
        }
    }
}