using System;

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
            Console.WriteLine("Bilen kjørte fra " + start.Name + " til " + exit.Name);

            Console.WriteLine("Det er " + crossroad.Top.Start.carList.Count + " biler i øverste felt");
            Console.WriteLine("Det er " + crossroad.Right.Start.carList.Count + " biler i høyre felt");
            Console.WriteLine("Det er " + crossroad.Bottom.Start.carList.Count + " biler i nederste felt");
            Console.WriteLine("Det er " + crossroad.Left.Start.carList.Count + " biler i venstre felt");
        }
    }
}