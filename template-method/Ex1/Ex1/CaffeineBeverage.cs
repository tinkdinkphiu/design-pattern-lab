using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal abstract class CaffeineBeverage
    {
        public abstract void brew();
        public abstract void addCondiments();
        void boilWater()
        {
            Console.WriteLine("Boiling water");
        }
        void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        bool customerWantCondiments()
        {
            String result = getUserInput();
            return result.ToLower().StartsWith("y");
        }
        private String getUserInput()
        {
            Console.WriteLine("Add condiments? (Yes/No)");
            return Console.ReadLine();
        }
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantCondiments()) addCondiments(); else Console.WriteLine();
        }
    }
}
