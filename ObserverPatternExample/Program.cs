using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Automobiles;
using ObserverPatternExample.Garage;

namespace ObserverPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GarageConfigurator configurator = new GarageConfigurator();
            var skoda = new Skoda();
            var volvo = new Volvo();
            var vw = new VW();
            configurator.GarageHandler += skoda.Parking;
            configurator.GarageHandler += vw.Parking;
            configurator.GarageHandler += volvo.Parking;

            configurator.ParkAutomobile();
            Console.WriteLine();

            configurator.GarageHandler -= volvo.Parking;
            configurator.ParkAutomobile();

            Console.ReadLine();
            

        }
    }
}
