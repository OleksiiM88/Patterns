using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using StrategyPatternExample.Animals;

namespace StrategyPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            List<AnimalBase> animals = new List<AnimalBase>();
            animals.Add(new Cat());
            animals.Add(new Owl());
            animals.Add(new Snake());
            animals.Add(new Wolf());

            foreach (AnimalBase animal in animals)
            {
                animal.DisplayName();
                animal.Fly();
                animal.Crawl();
                animal.IsPredator();

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
