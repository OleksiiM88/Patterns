using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample.MulticookerActionClasses
{
    public class Cooker
    {
        public void Cook(int minutes)
        {
            Console.WriteLine($"Cooking started on {minutes} minutes");
        }
    }
}
