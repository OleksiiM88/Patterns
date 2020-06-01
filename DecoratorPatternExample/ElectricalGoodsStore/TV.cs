using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.ElectricalGoodsStore
{
    class TV : GoodsStoreBase
    {
        public TV()
        {
            ItemDescription = "TV";
        }
        public override int GetPrice()
        {
            return 3500; ;
        }
    }
}
