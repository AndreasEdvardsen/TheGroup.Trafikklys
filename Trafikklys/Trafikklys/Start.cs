﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class Start
    {
        public List<Car> carList = new List<Car>();
        public string name;

        public Start(string side)
        {
            name = side;
        }
    }
    
}
