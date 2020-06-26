using AdapterPatternExample.HomeCats;
using AdapterPatternExample.WildCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CatPreview.ShowCat(new PedigreedCat());
            CatPreview.ShowCat(new SimpleFlatCat());

            IWildCat tiger = new Tiger();
            HomeCatAdapter adapter = new HomeCatAdapter(tiger);
            CatPreview.ShowCat(adapter);
            Console.ReadLine();
        }
    }
}
