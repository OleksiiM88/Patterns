using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Animals
{
    class Snake: AnimalBase
    {
        public Snake()
        {
            crawlable = new CrawlOption();
            predator.IsPredator = true;
        }
        public override void DisplayName()
        {
            Console.WriteLine("I'm Snake!");
        }
    }
}
