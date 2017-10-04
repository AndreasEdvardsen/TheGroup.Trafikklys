using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Program
    {
        static void Main(string[] args)
        {
            var simRunning = true;
            var LoopsToSimulate = 10;
            while (simRunning)
            {
                Crossroad crossroad = new Crossroad();
                Controller controller = new Controller(crossroad);
                controller.CreateCars();
                controller.SetLights();
                controller.SendCarToExit();

                if (LoopsToSimulate <= 0)
                {
                    break;
                }
                LoopsToSimulate--;
            }
            Console.ReadLine();
        }
    }
}
