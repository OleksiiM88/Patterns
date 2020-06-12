using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    public abstract class Autopilot
    {
        protected string AutoPilotClass;
        protected string Name;
        protected int AutoPilotWeight;

        public void Overview()
        {
            Console.WriteLine($"I'm {Name} with {AutoPilotWeight} weight and {AutoPilotClass} class");
        }

        public abstract void Purpose();
        public abstract void MaxCapacity();
    }
}
