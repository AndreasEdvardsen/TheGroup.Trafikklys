using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Car
    {
        public Start Start;
        public Exit Exit;
        
        public Car(Start start, Exit exit)
        {
            Start = start;
            Exit = exit;

            start.carList.Add(this);
        }
    }
}
