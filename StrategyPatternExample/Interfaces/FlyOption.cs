using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Interfaces
{
    class FlyOption: IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("I'm the animal with Fly possibility!");
        }
    }
}
