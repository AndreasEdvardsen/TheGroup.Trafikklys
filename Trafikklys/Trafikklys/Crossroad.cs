using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Crossroad
    {
        public CrossroadSide Top = new CrossroadSide();
        public CrossroadSide Right = new CrossroadSide();
        public CrossroadSide Bottom = new CrossroadSide();
        public CrossroadSide Left = new CrossroadSide();
    }
}
