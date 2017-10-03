using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class CarToExit
    {
        public static void SendCarToExit(Car car)
        {
            Start.carList.RemoveAt(0);
            
        }
        
    }
}
