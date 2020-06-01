using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample.ElectricalGoodsStore
{
    abstract class GoodsStoreBase
    {
        public string ItemDescription;

        public string GetDescription()
        {
            return ItemDescription;
        }

        public abstract int GetPrice();
    }
}
