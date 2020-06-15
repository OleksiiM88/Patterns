using FactoryPatternExample.Autopilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class AutoPilotSequencer
    {
        protected AutoPilotFactory _autoPilotFactory;

        public AutoPilotSequencer(AutoPilotFactory autoPilotFactory)
        {
            _autoPilotFactory = autoPilotFactory;
        }

        public void AutoPilotSequence(string type)
        {
            IAutoPilot autopilot = _autoPilotFactory.FactorySequencer(type);
            autopilot.Overview();
            autopilot.Purpose();
            autopilot.MaxCapacity();
            
        }
    }
}
