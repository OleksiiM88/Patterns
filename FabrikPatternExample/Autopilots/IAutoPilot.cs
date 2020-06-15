using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample.Autopilots
{
    public interface IAutoPilot
    {
        string AutoPilotClass { get; set; }
        string Name { get; set; }
        int AutoPilotWeight { get; set; }

        void Purpose();

        void MaxCapacity();

        void Overview();
    }
}
