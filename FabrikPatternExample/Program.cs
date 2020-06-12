using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            AutoPilotSequencer autoPilotSequencer = new AutoPilotSequencer(new AutoPilotFactory());
            autoPilotSequencer.AutoPilotSequence("LAE");
            Console.WriteLine("--------");
            autoPilotSequencer.AutoPilotSequence("SAE");
            Console.WriteLine("--------");
            autoPilotSequencer.AutoPilotSequence("TAE");
            Console.WriteLine("--------");

            Console.ReadLine();
        }
    }
}
