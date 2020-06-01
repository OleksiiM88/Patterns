using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.ElectricalGoodsStore
{
    class Smartphone : GoodsStoreBase
    {
        public Smartphone()
        {
            ItemDescription = "Smartphone";
        }
        public override int GetPrice()
        {
            return 5000;
        }
    }
}
