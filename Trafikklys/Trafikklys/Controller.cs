using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Controller
    {

        Random random = new Random();

        public void SendCarToExit(Car car)
        {
            var trafficLight = car.Exit.TrafficLight.trafficLights;
            
            if (trafficLight == true)
            {
                car.Start.carList.RemoveAt(0);

                car.Exit.CarCollection.Add(car);

                View view = new View(car.Start, car.Exit);
            }
        }

        public void CreateCars(Car car, Start start, Exit exit, Crossroad crossroad)
        {
            var startPoint = car.Start.Name;
            var exitPoint = car.Exit.Name;

            string[] sides = new string[4] {crossroad.Top.ToString(), crossroad.Right.ToString(), crossroad.Bottom.ToString(), crossroad.Left.ToString()};

            startPoint = sides[random.Next(0, 3)];
            exitPoint = sides[random.Next(0, 3)];

            //hvis de er like, lag et nytt exitPoint
            if (exitPoint == startPoint)
            {
                exitPoint = sides[random.Next(0, 3)];
            }
            
        }

        public CrossroadSide CheckBiggestQueue(Crossroad crossroad)
        {
            var topRoad = crossroad.Top.Start.carList.Count;
            var rightRoad = crossroad.Right.Start.carList.Count;
            var bottomRoad = crossroad.Bottom.Start.carList.Count;
            var leftRoad = crossroad.Left.Start.carList.Count;

            if (topRoad > rightRoad && topRoad > bottomRoad && topRoad > leftRoad) return crossroad.Top;
            if (rightRoad > bottomRoad && rightRoad > leftRoad && rightRoad > topRoad) return crossroad.Right;
            if (bottomRoad > leftRoad && bottomRoad > topRoad && bottomRoad > rightRoad) return crossroad.Bottom;
            if (leftRoad > topRoad && leftRoad > rightRoad && leftRoad > bottomRoad) return crossroad.Left;
            return null;
        }

    }
}
