using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Coffee : CaffeineBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
            Console.WriteLine();
        }
    }
}
