using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Controller
    {
        public void SendCarToExit(Car car)
        {
            var trafficLight = car.Exit.TrafficLight.GreenLight;

            if (trafficLight == true)
            {
                car.Start.carList.RemoveAt(0);

                car.Exit.CarCollection.Add(car);

                View view = new View(car.Start, car.Exit);
            }
        }

        public void SetLights(CrossroadSide crossroadSide, Crossroad crossroad)
        {
            List<Exit> exits = new List<Exit>
            {
                crossroad.Top.Exit,
                crossroad.Right.Exit,
                crossroad.Bottom.Exit,
                crossroad.Left.Exit
            };

            foreach (var exit in exits)
            {
                exit.TrafficLight.GreenLight = false;
            }
            crossroadSide.Exit.TrafficLight.GreenLight = true;
        }
    }
}