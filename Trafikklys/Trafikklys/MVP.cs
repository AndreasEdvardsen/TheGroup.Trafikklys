using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class MVP
    {
        MVP()
        { 
            Crossroad crossroad = new Crossroad();
            var car = new Car(crossroad.Bottom.Entrance, crossroad.Top.Exit);
            
        }
    }
}
