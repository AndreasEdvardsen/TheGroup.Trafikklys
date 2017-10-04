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
            Console.WriteLine("Bilen kjørte fra " + start.Name + " til " + exit.Name);

            Console.WriteLine("Top: ");
            for (var indexTop = 0; indexTop < crossroad.Top.Start.carList.Count; indexTop++)
            {
                Console.Write("|");
            }
            Console.WriteLine("Right: ");
            for (var indexTop = 0; indexTop < crossroad.Right.Start.carList.Count; indexTop++)
            {
                Console.Write("|");
            }
            Console.WriteLine("Bottom: ");
            for (var indexTop = 0; indexTop < crossroad.Bottom.Start.carList.Count; indexTop++)
            {
                Console.Write("|");
            }
            Console.WriteLine("Left: ");
            for (var indexTop = 0; indexTop < crossroad.Left.Start.carList.Count; indexTop++)
            {
                Console.Write("|");
            }
            Thread.Sleep(500);
        }
    }
}