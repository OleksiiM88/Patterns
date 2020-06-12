using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    class TAE : Autopilot
    {
        public TAE()
        {
            Name = "TAE";
            AutoPilotClass = "Tall";
            AutoPilotWeight = 2;
        }
        public override void MaxCapacity()
        {
            Console.WriteLine("TAE max capacity is 2.5 tonns");
        }

        public override void Purpose()
        {
            Console.WriteLine("I have a Tall pallets");
        }
    }
}
