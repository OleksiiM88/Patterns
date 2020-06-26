using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.WildCats
{
    class Tiger : IWildCat
    {
        public string Name => "Tiger";

        public void Ring()
        {
            Console.WriteLine("I'm not moou at all.");
        }

        public void Sсratch()
        {
            Console.WriteLine("I am scratch.");
        }
    }
}
