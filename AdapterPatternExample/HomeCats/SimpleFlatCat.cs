using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.HomeCats
{
    class SimpleFlatCat : IHomeCat
    {
        public string Name { get ; set; }

        public void Moou()
        {
            Console.WriteLine("My Moou is so simple as I am!");
        }

        public void Sсratch()
        {
            Console.WriteLine("I'am not scratch.");
        }
    }
}
