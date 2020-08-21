using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample.MulticookerActionClasses
{
    public class HotAction
    {
        public void MakeHot(int degree)
        {
            Console.WriteLine($"Temperature is up to {degree} degrees");
        }

        public void MakeCold(int degree)
        {
            Console.WriteLine($"Temperature is down to {degree} degrees");
        }
    }
}
