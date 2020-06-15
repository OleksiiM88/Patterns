using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    class SAE : IAutoPilot
    {
        public SAE()
        {
            Name = "Stackers";
            AutoPilotClass = "Small";
            AutoPilotWeight = 3;
        }

        public string AutoPilotClass { get; set; }
        public string Name { get; set; }
        public int AutoPilotWeight { get; set; }
        public void MaxCapacity()
        {
            Console.WriteLine("SAE max capacity is 1 tonn");
        }
        public void Overview()
        {
            Console.WriteLine($"I'm {Name} with {AutoPilotWeight} weight and {AutoPilotClass} class");
        }

        public void Purpose()
        {
            Console.WriteLine("I have a Small pallets");
        }
    }
}
