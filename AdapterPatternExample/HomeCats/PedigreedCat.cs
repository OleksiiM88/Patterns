using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.HomeCats
{
    class PedigreedCat : IHomeCat
    {
        public string Name { get; set; }

        public void Moou()
        {
            Console.WriteLine("I don't know my moou))");
        }

        public void Sсratch()
        {
            Console.WriteLine("I am scratch.");
        }
    }
}
