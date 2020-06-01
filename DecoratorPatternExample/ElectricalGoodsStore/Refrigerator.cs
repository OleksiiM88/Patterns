using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.ElectricalGoodsStore
{
    class Refrigerator : GoodsStoreBase
    {
        public Refrigerator()
        {
            ItemDescription = "Refrigerator";
        }
        public override int GetPrice()
        {
            return 8000;
        }
    }
}
