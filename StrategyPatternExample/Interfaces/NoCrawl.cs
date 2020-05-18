using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Interfaces
{
    class NoCrawl : IСrawlable
    {
        public void Crawl()
        {
            Console.WriteLine("...");
        }
    }
}
