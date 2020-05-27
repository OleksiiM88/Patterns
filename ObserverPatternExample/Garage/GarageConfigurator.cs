using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Garage
{
    public delegate void GarageConfiguratorDelegate(object sender, ParkingEventArgs e);
    class GarageConfigurator
    {
        private Random _random;
        public event GarageConfiguratorDelegate GarageHandler;

        public GarageConfigurator()
        {
            _random = new Random();
        }

        public void ParkAutomobile()
        {
            int volvoParkingId = _random.Next(50);
            int skodaParkingId = _random.Next(50);
            int vwParkingId = _random.Next(50);

            GarageHandler?.Invoke(this, new ParkingEventArgs(
                skodaParkingId == 0 ? skodaParkingId = 1 : skodaParkingId,
                volvoParkingId == 0 ? volvoParkingId = 1 : volvoParkingId,
                vwParkingId == 0 ? vwParkingId = 1 : vwParkingId));
        }
    }
}
