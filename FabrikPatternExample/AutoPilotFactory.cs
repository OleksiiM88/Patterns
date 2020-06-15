using FactoryPatternExample.Autopilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    public class AutoPilotFactory
    {
        public IAutoPilot FactorySequencer(string type)
        {
            switch (type)
            {
                case "LAE": return new LAE();
                case "SAE": return new SAE();
                case "TAE": return new TAE();
                default: return null;
            }
        }

    }
}
