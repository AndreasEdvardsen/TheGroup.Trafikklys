﻿using System;
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

            //Om programmet skal kjøre
            while (simRunning)
            {
                Crossroad crossroad = new Crossroad();
                Controller controller = new Controller(crossroad);

                //Create cars
                controller.CreateCars();
                //Set lights
                Task.Factory.StartNew(controller.SetLights);
                //Sends cars
                await Task.Factory.StartNew(controller.SendCarToExit);
                
                if (LoopsToSimulate == 0)
                {
                    break;
                }
                LoopsToSimulate--;
            }
        }
    }
    
}
