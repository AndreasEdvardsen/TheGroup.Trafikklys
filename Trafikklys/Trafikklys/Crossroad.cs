using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Crossroad
    {
        public CrossroadSide Top = new CrossroadSide("Top");
        public CrossroadSide Right = new CrossroadSide("Right");
        public CrossroadSide Bottom = new CrossroadSide("Bottom");
        public CrossroadSide Left = new CrossroadSide("Left");
    }
}
