using AdapterPatternExample.HomeCats;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    public class CatPreview
    {
        public static void ShowCat(IHomeCat homeCat)
        {
            Console.WriteLine("Cat Preview:");
            Console.WriteLine($"My name is: {homeCat.Name}");
            homeCat.Moou();
            homeCat.Sсratch();
        }
    }
}
