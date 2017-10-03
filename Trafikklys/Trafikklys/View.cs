using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trafikklys
{
    class View 
    {
        public View(Start start, Exit exit)
        {
        Console.WriteLine("Bilen kjørte fra " + start.name + "til " + exit.Name);
        }
    }
}
