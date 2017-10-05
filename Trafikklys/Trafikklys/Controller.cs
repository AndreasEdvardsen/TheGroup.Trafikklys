using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Controller
    {
        Random random = new Random();
        private Crossroad _crossroad;

        public Controller(Crossroad crossroad)
        {
            _crossroad = crossroad;
        }

        //Flytter biler fra start til slutt
        public void SendCarToExit()
        {
            var view = new View(_crossroad);
            var side = CheckBiggestQueue();
            CrossroadSide otherSide = null;

            if (side == _crossroad.Top) otherSide = _crossroad.Right;
            if (side == _crossroad.Right) otherSide = _crossroad.Bottom;
            if (side == _crossroad.Bottom) otherSide = _crossroad.Left;
            if (side == _crossroad.Left) otherSide = _crossroad.Top;

            while (side.Exit.TrafficLight.GreenLight)
            {
                Car car1 = null;
                Car car2 = null;
                if (side.Start.carList.Count > 0)
                {
                    var car = side.Start.carList[0];
                    car1 = car;
                    car.Start.carList.RemoveAt(0);
                    car.Exit.CarCollection.Add(car);
                }
                if (otherSide.Start.carList.Count > 0)
                {
                    var car = otherSide.Start.carList[0];
                    if (car.Exit == side.Exit)
                    {
                        car2 = car;
                        car.Start.carList.RemoveAt(0);
                        car.Exit.CarCollection.Add(car);
                    }
                }
                view.Show(car1, car2, side);
            }
        }

        //Lager tilfeldig mengde biler, med tilfeldig start/slutt.
        public void CreateCars()
        {
            int carAmount = random.Next(1, 10);
            List<Start> startList = new List<Start>()
            {
                _crossroad.Top.Start,
                _crossroad.Right.Start,
                _crossroad.Bottom.Start,
                _crossroad.Left.Start
            };

            List<Exit> exitList = new List<Exit>()
            {
                _crossroad.Top.Exit,
                _crossroad.Right.Exit,
                _crossroad.Bottom.Exit,
                _crossroad.Left.Exit
            };

            for (int i = carAmount; i > 0; i--)
            {
                var startPoint = startList[random.Next(0, 4)];
                var exitPoint = exitList[random.Next(0, 4)];

                //hvis de er like, lag et nytt exitPoint
                while (exitPoint.Name == startPoint.Name)
                {
                    exitPoint = exitList[random.Next(0, 4)];
                }

                var car = new Car(startPoint, exitPoint);

                startPoint.carList.Add(car);
            }
        }

        //Returnerer størst kø.
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
            return _crossroad.Top;
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

            //Setter Lys til grønt så etter en delay til rødt
            foreach (var exit in exits)
            {
                exit.TrafficLight.GreenLight = true;
            }

            Thread.Sleep(4000);

            foreach (var exit in exits)
            {
                exit.TrafficLight.GreenLight = false;
            }
        }
    }
}