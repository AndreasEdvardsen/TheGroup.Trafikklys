using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class MVP
    {
        public MVP()
        { 
            Controller controller = new Controller();
            Crossroad crossroad = new Crossroad();
            crossroad.Top.Exit.TrafficLight.trafficLights = true;
            var car = new Car(crossroad.Bottom.Start, crossroad.Top.Exit);

            controller.SendCarToExit(car);
        }
    }
}
