using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class CrossroadSide
    {
        public Start Start;
        public Exit Exit;

        public CrossroadSide(string side)
        {
            Start = new Start(side);
            Exit = new Exit(side);
        }
    }
}

