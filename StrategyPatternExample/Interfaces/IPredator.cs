using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternExample.Interfaces
{
    public interface IPredator
    {
        void PredatorMessage();
        bool IsPredator { get; set; }
    }
}
