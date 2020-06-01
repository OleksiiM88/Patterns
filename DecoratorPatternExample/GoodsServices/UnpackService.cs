using DecoratorPatternExample.ElectricalGoodsStore;

namespace DecoratorPatternExample.GoodsServices
{
    class UnpackService : GoodsServicesBase
    {
        private GoodsStoreBase _storeBase;
        public UnpackService(GoodsStoreBase storeBase)
        {
            _storeBase = storeBase;
            ItemDescription = storeBase.GetDescription() + " + Unpack";
        }
        public override int GetPrice()
        {
            return _storeBase.GetPrice() + 150;
        }
    }
}

