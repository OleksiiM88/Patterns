using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    class SAE : Autopilot
    {
        public SAE()
        {
            Name = "SAE";
            AutoPilotClass = "Small";
            AutoPilotWeight = 3;
        }
        public override void MaxCapacity()
        {
            Console.WriteLine("SAE max capacity is 1 tonn");
        }

        public override void Purpose()
        {
            Console.WriteLine("I have a Small pallets");
        }
    }
}
