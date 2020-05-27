using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternExample.Garage
{
    public class ParkingEventArgs : EventArgs
    {
        public int SkodaParkingId { get; private set; }
        public int VolvoParkingId { get; private set; }
        public int VwParkingId { get; private set; }
        public ParkingEventArgs(int skodaParkingId, int volvoParkingId, int vwParkingId)
        {
            SkodaParkingId = skodaParkingId;
            VolvoParkingId = volvoParkingId;
            VwParkingId = vwParkingId;
        }
    }
}
