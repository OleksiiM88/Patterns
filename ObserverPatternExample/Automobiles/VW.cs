using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPatternExample.Garage;

namespace ObserverPatternExample.Automobiles
{
    class VW : IAutomobile
    {
        public int ParkingId { get; set; }
        public void Display()
        {
            Console.WriteLine($"VW: Your ParkingId is {ParkingId}");
        }

        public void Parking(object sender, ParkingEventArgs e)
        {
            ParkingId = e.VwParkingId;
            Display();
        }
    }
}
