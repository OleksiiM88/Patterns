using DecoratorPatternExample.ElectricalGoodsStore;

namespace DecoratorPatternExample.GoodsServices
{
    class DeliveryService : GoodsServicesBase
    {
        private GoodsStoreBase _storeBase;
        public DeliveryService(GoodsStoreBase storeBase){
            _storeBase = storeBase;
            ItemDescription = storeBase.GetDescription() + " + Delivery";
        }
        public override int GetPrice()
        {
            return _storeBase.GetPrice() + 500;
        }
    }
}
