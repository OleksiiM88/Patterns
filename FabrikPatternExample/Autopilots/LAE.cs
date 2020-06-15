using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    class LAE : IAutoPilot
    {
        public LAE()
        {
            Name = "Low-lifters";
            AutoPilotWeight = 1;
            AutoPilotClass = "Long";
        }

        public string AutoPilotClass { get ; set ; }
        public string Name { get ; set ; }
        public int AutoPilotWeight { get ; set; }

        public void MaxCapacity()
        {
            Console.WriteLine("LAE max capacity is 1.5 tonns");
        }

        public void Overview()
        {
            Console.WriteLine($"I'm {Name} with {AutoPilotWeight} weight and {AutoPilotClass} class");
        }

        public void Purpose()
        {
            Console.WriteLine("I have a Long pallets");
        }
    }
}
