using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Interfaces
{
    class CrawlOption : IСrawlable
    {
        public void Crawl()
        {
            Console.WriteLine("I can crawl!");
        }
    }
}
