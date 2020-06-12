using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    class LAE : Autopilot
    {
        public LAE()
        {
            Name = "LAE";
            AutoPilotWeight = 1;
            AutoPilotClass = "Long";
        }
        public override void MaxCapacity()
        {
            Console.WriteLine("LAE max capacity is 1.5 tonns");
        }

        public override void Purpose()
        {
            Console.WriteLine("I have a Long pallets");
        }
    }
}
