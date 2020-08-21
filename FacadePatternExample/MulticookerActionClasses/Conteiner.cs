using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePatternExample.MulticookerActionClasses
{
    public class Conteiner
    {
        public void Fill(string foodExample)
        {
            Console.WriteLine($"Conteiner was filled with {foodExample}");
        }

        public void Remove()
        {
            Console.WriteLine("Conteiner is empty now!");
        }

        public void Add(string additionalStaff)
        {
            Console.WriteLine($"Into conteiner was added {additionalStaff}");
        }
    }
}
