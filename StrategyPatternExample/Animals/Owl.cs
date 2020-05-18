using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Animals
{
    class Owl : AnimalBase
    {
        public Owl()
        {
            flyable = new FlyOption();
            predator.IsPredator = true;
        }
        public override void DisplayName()
        {
            Console.WriteLine("I'm Owl!");
        }

    }
}
