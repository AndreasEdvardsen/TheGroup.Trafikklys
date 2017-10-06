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

        public void Show(Car car1, Car car2, CrossroadSide side)
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

            
            Console.WriteLine("\r\nDet er grønt lys for: " + side.Start.Name + "\r\n");
            

            Console.Write("Øverste kjørefelt: ");
            for (var indexTop = 0; indexTop < crossroad.Top.Start.carList.Count; indexTop++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Høyre kjørefelt: ");
            for (var indexRight = 0; indexRight < crossroad.Right.Start.carList.Count; indexRight++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Nederste kjørefelt: ");
            for (var indexBottom = 0; indexBottom < crossroad.Bottom.Start.carList.Count; indexBottom++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Console.Write("Venstre kjørefelt: ");
            for (var indexLeft = 0; indexLeft < crossroad.Left.Start.carList.Count; indexLeft++)
            {
                Console.Write("|");
            }
            Console.WriteLine();
            Thread.Sleep(500);
        }
    }
}