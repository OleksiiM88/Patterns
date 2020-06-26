using AdapterPatternExample.HomeCats;
using AdapterPatternExample.WildCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample
{
    class HomeCatAdapter : IHomeCat
    {
        public IWildCat _wildCat;

        public HomeCatAdapter(IWildCat wildCat)
        {
            _wildCat = wildCat;
        }
        public string Name { get { return _wildCat.Name; } set { } }

        public void Moou()
        {
            _wildCat.Ring();
        }

        public void Sсratch()
        {
            _wildCat.Sсratch();
        }
    }
}
