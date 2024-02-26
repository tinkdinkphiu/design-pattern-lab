using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class AcerManufacturer : LaptopManufacturer
    {
        public override void AssembleComponents()
        {
            Console.WriteLine("Assembling components for Acer laptop");
        }

        public override void TestLaptop()
        {
            Console.WriteLine("Running diagnostics on Acer laptop");
        }
    }
}
