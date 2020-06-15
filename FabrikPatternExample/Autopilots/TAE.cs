using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    class TAE : IAutoPilot
    {
        public TAE()
        {
            Name = "Towing";
            AutoPilotClass = "Tall";
            AutoPilotWeight = 2;
        }

        public string AutoPilotClass { get; set; }
        public string Name { get; set; }
        public int AutoPilotWeight { get; set; }

        public void MaxCapacity()
        {
            Console.WriteLine("TAE max capacity is 2.5 tonns");
        }

        public void Overview()
        {
            Console.WriteLine($"I'm {Name} with {AutoPilotWeight} weight and {AutoPilotClass} class");
        }

        public void Purpose()
        {
            Console.WriteLine("I have a Tall pallets");
        }
    }
}
