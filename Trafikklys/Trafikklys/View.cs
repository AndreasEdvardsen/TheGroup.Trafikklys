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

        public void Show(Car car1, Car car2)
        {
            Console.Clear();
            if (car1 != null)
            {
                Console.WriteLine("Bilen kjørte fra " + car1.Start.Name + " til " + car1.Exit.Name);
            }
            if (car2 != null)
            {
                Console.WriteLine("Bilen kjørte fra " + car2.Start.Name + " til " + car2.Exit.Name);
            }


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