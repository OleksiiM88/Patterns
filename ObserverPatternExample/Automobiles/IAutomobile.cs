using ObserverPatternExample.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Automobiles
{
    public interface IAutomobile
    {
        void Display();

        void Parking(object sender, ParkingEventArgs e);
    }
}
