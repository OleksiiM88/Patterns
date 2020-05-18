using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Animals
{
    class Wolf : AnimalBase
    {
        public Wolf()
        {
            predator.IsPredator = true;
        }
        public override void DisplayName()
        {
            Console.WriteLine("I'm Wolf!");
        }
    }
}
