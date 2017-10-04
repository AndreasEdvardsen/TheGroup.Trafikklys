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
        private Crossroad _crossroad;

        Controller(Crossroad crossroad)
        {
            _crossroad = crossroad;
        }

        public void SendCarToExit(Car car)
        {
            var trafficLight = car.Exit.TrafficLight.GreenLight;

            if (trafficLight == true)
            {
                car.Start.carList.RemoveAt(0);
                car.Exit.CarCollection.Add(car);
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

        public CrossroadSide CheckBiggestQueue()
        {
            var topRoad = _crossroad.Top.Start.carList.Count;
            var rightRoad = _crossroad.Right.Start.carList.Count;
            var bottomRoad = _crossroad.Bottom.Start.carList.Count;
            var leftRoad = _crossroad.Left.Start.carList.Count;

            if (topRoad > rightRoad && topRoad > bottomRoad && topRoad > leftRoad) return _crossroad.Top;
            if (rightRoad > bottomRoad && rightRoad > leftRoad && rightRoad > topRoad) return _crossroad.Right;
            if (bottomRoad > leftRoad && bottomRoad > topRoad && bottomRoad > rightRoad) return _crossroad.Bottom;
            if (leftRoad > topRoad && leftRoad > rightRoad && leftRoad > bottomRoad) return _crossroad.Left;
            return null;
        }

        public void SetLights()
        {
            //Henter ut den køen med flest biler.
            var crossroadSide = CheckBiggestQueue();

            //Lager en liste med alle exits
            List<Exit> exits = new List<Exit>
            {
                _crossroad.Top.Exit,
                _crossroad.Right.Exit,
                _crossroad.Bottom.Exit,
                _crossroad.Left.Exit
            };

            foreach (var exit in exits)
            {
                exit.TrafficLight.GreenLight = true;
            }
        }
    }
}