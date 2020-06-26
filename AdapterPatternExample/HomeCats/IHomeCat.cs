using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPatternExample.HomeCats
{
    public interface IHomeCat
    {
        string Name{ get; set; }
        void Moou();
        void Sсratch();
    }
}
