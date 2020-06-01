using DecoratorPatternExample.ElectricalGoodsStore;

namespace DecoratorPatternExample.GoodsServices
{
    class AdjustmentService : GoodsServicesBase
    {
        private GoodsStoreBase _storeBase;
        public AdjustmentService(GoodsStoreBase storeBase)
        {
            _storeBase = storeBase;
            ItemDescription = storeBase.GetDescription() + " + Adjustment";
        }
        public override int GetPrice()
        {
            return _storeBase.GetPrice() + 300;
        }
    }
}
