using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal abstract class LaptopManufacturer
    {
        public abstract void AssembleComponents();

        string GetInput()
        {
            Console.WriteLine("Enter the operating system to install (10/11/linux):");
            return Console.ReadLine();
        }
        bool IsValidInput(string input)
        {
            return input.ToLower() == "10" || input.ToLower() == "11" || input.ToLower() == "linux";
        }
        void InstallOperatingSystem()
        {
            Console.WriteLine("Installing Operating System");

            string input = GetInput();

            while (!IsValidInput(input))
            {
                Console.WriteLine("Invalid input. Please enter again (10/11/linux):");
                input = GetInput();
            }

            switch (input)
            {
                case "10":
                    Console.WriteLine("Installing Windows 10");
                    break;
                case "11":
                    Console.WriteLine("Installing Windows 11");
                    break;
                case "linux":
                    Console.WriteLine("Installing Linux");
                    break;
                default:
                    break;
            }
        }
        public abstract void TestLaptop();
        void DistributeLaptops()
        {
            Console.WriteLine("Distributing laptop to dealer");
        }
        void PackLaptop()
        {
            Console.WriteLine("Packaging laptop");
        }
        public void ManufactureLaptop()
        {
            Console.WriteLine("Manufacturing laptop:");
            AssembleComponents();
            InstallOperatingSystem();
            TestLaptop();
            PackLaptop();
            Console.WriteLine("Laptop manufacturing completed\n");
        }
    }
}
