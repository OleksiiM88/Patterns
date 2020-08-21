using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample.MulticookerActionClasses
{
    public class MultiCooker
    {
        private Conteiner _conteiner;
        private HotAction _hotAction;
        private Cooker _cooker;

        public MultiCooker(Conteiner conteiner, HotAction hotAction, Cooker cooker)
        {
            _conteiner = conteiner;
            _hotAction = hotAction;
            _cooker = cooker;
        }

        public void MakeBoilingWater()
        {
            _conteiner.Fill("water");
            _hotAction.MakeHot(100);
            _cooker.Cook(10);
            _conteiner.Remove();
        }
        public void MakeDishWithMeat()
        {
            _conteiner.Fill("meat");
            _conteiner.Add("potato");
            _conteiner.Add("seasoning");
            _hotAction.MakeHot(90);
            _cooker.Cook(20);
            _hotAction.MakeCold(50);
            _cooker.Cook(60);
            _conteiner.Remove();
        }
    }
}
