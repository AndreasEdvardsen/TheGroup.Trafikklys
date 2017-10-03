using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Controller
    {
        public static void SendCarToExit(Car car)
        {
            var trafficLight = car.Exit.TrafficLight.trafficLights;
            
            if (trafficLight == true)
            {
                car.Start.carList.RemoveAt(0);

                car.Exit.CarCollection.Add(car);

                View view = new View(car.Start, car.Exit);
            }
        }
    }
}
