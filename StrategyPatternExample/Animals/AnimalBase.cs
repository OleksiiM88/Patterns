using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternExample.Interfaces;

namespace StrategyPatternExample.Animals
{
    public abstract class AnimalBase
    {
        protected IFlyable flyable;
        protected IСrawlable crawlable;
        protected IPredator predator;
        protected AnimalBase()
        {
            flyable = new NoFly();
            crawlable = new NoCrawl();
            predator = new PredatorOption();
        }
        public abstract void DisplayName();


        public void Fly()
        {
            flyable.Fly();
        }

        public void Crawl()
        {
            crawlable.Crawl();
        }

        public void IsPredator()
        {
            predator.PredatorMessage();
        }
    }
}
