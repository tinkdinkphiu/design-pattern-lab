namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CaffeineBeverage tea = new Tea();
            Console.WriteLine("Making tea");
            tea.prepareRecipe();

            CaffeineBeverage coffee = new Coffee();
            Console.WriteLine("Making coffee");
            coffee.prepareRecipe();
        }
    }
}