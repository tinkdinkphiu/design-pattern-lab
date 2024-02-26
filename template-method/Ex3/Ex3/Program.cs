namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Manufacturing Lenovo laptop:");
            LaptopManufacturer lenovoManufacturer = new LenovoManufacturer();
            lenovoManufacturer.ManufactureLaptop();

            Console.WriteLine("\nManufacturing Asus laptop:");
            LaptopManufacturer asusManufacturer = new AsusManufacturer();
            asusManufacturer.ManufactureLaptop();

            Console.WriteLine("\nManufacturing Acer laptop:");
            LaptopManufacturer acerManufacturer = new AcerManufacturer();
            acerManufacturer.ManufactureLaptop();
        }
    }
}