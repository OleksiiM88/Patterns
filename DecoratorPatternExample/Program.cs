using DecoratorPatternExample.ElectricalGoodsStore;
using DecoratorPatternExample.GoodsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            GoodsStoreBase refrigerator = new Refrigerator();
            GoodsStoreBase tv = new TV();
            GoodsStoreBase smartphone = new Smartphone();

            ShowGoods(refrigerator);
            ShowGoods(tv);
            ShowGoods(smartphone);
            Console.WriteLine("---------------");

            GoodsStoreBase refWithDeliveryAndUnpack = new DeliveryService(new UnpackService(new Refrigerator()));
            GoodsStoreBase tvWithDelivery = new DeliveryService(new TV());
            GoodsStoreBase smartphoneWithDeliveryAndAdjustment = new DeliveryService(new AdjustmentService(new Smartphone()));
            ShowGoods(refWithDeliveryAndUnpack);
            ShowGoods(tvWithDelivery);
            ShowGoods(smartphoneWithDeliveryAndAdjustment);

            Console.ReadLine();
        }

        static void ShowGoods(GoodsStoreBase goods)
        {
            Console.WriteLine($"This is electric store and I'm a {goods.GetDescription()} with price {goods.GetPrice()}");
        }
    }
}
