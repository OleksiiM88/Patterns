using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Interfaces
{
    class PredatorOption : IPredator
    {
        public void PredatorMessage()
        {
            Console.WriteLine(IsPredator ? "I'm a predator" : "I'm not a predator");
        }

        public bool IsPredator { get; set; }
    }
}
