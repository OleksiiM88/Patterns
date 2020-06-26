using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.WildCats
{
    interface IWildCat
    {
        string Name { get; }
        void Ring();
        void Sсratch();
    }
}
