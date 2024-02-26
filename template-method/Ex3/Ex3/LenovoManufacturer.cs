using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class LenovoManufacturer : LaptopManufacturer
    {
        public override void AssembleComponents()
        {
            Console.WriteLine("Assembling components for Lenovo laptop");
        }

        public override void TestLaptop()
        {
            Console.WriteLine("Running diagnostics on Lenovo laptop");
        }
    }
}
