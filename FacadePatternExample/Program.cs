using FacadePatternExample.MulticookerActionClasses;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Conteiner conteiner = new Conteiner();
            Cooker cooker = new Cooker();
            HotAction hotAction = new HotAction();

            //Make multicooker as facade class on actions above!
            MultiCooker multiCooker = new MultiCooker(conteiner, hotAction, cooker);

            //Make a boiling water
            multiCooker.MakeBoilingWater();

            //Make a meat dish
            multiCooker.MakeDishWithMeat();

            Console.ReadLine();
        }
    }
}
