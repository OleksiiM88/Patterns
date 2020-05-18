using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Animals
{
    class Cat : AnimalBase
    {
        public Cat()
        {
            crawlable = new CrawlOption();
        }
        public override void DisplayName()
        {
            Console.WriteLine("I'm Cat!");
        }
    }
}
