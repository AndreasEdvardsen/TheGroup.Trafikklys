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
            SimLoop();
            Console.ReadLine();
        }

        public static async void SimLoop()
        {
            var simRunning = true;
            var LoopsToSimulate = 10;
            while (simRunning)
            {
                Crossroad crossroad = new Crossroad();
                Controller controller = new Controller(crossroad);
                controller.CreateCars();

                Task.Factory.StartNew(controller.SetLights);
                await Task.Factory.StartNew(controller.SendCarToExit);
                
                if (LoopsToSimulate <= 0)
                {
                    break;
                }
                LoopsToSimulate--;
            }
        }
    }
    
}
