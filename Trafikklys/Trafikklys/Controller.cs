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
            var trafficLight = car.Exit.TrafficLight.GreenLight;

            if (trafficLight == true)
            {
                car.Start.carList.RemoveAt(0);

                car.Exit.CarCollection.Add(car);

                View view = new View(car.Start, car.Exit);
            }
        }

        public void CreateCars(Car car)
        {
            var startPoint = car.Start;
            var exitPoint = car.Exit;

            int carAmount = random.Next(0, 10);

            List<Start> startList = new List<Start>()
            {
                -crossroad.Top.Start,
                -crossroad.Right.Start,
                -crossroad.Bottom.Start,
                -crossroad.Left.Start
            };

            List<Exit> exitList = new List<Exit>()
            {
                -crossroad.Top.Exit,
                -crossroad.Right.Exit,
                -crossroad.Bottom.Exit,
                -crossroad.Left.Exit
            };

            for (int i = carAmount; i <= 0; i--)
            {
                startPoint = startList[random.Next(0, 3)];
                exitPoint = exitList[random.Next(0, 3)];

                //hvis de er like, lag et nytt exitPoint
                if (exitPoint.Name == startPoint.Name)
                {
                    exitPoint = exitList[random.Next(0, 3)];
                }
                
                car = new Car(startPoint, exitPoint);
                
                startPoint.carList.Add(car);
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