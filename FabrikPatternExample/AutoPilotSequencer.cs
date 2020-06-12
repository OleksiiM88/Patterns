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
        protected Autopilot _autopilot;

        public AutoPilotSequencer()
        {

        }

        public void AutoPilotSequence()
        {
            Autopilot autopilot = new LAE();
            autopilot.Overview();
            autopilot.Purpose();
            autopilot.MaxCapacity();
            
        }
    }
}
