namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gallery gallery = new Gallery();

            Car bmw = new Car();
            bmw.Name = "BMW";
            bmw.ProductYear = 10;
            bmw.Color = "ag";
            gallery.cars[1] = bmw;

            Car mers = new Car();
            mers.Name = "MERSEDES";
            mers.ProductYear = 13;
            mers.Color = "qara";
            gallery.cars[0] = mers;

            Car qwe = new Car();
            qwe.Name = "MERSEDES";
            qwe.ProductYear = 13;
            qwe.Color = "qara";
            gallery.cars[2] = qwe;

            //indekse gore car verir
            //Console.WriteLine("Index daxil edin...");
            //int index = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i < gallery.cars.Length; i++)
            //{
            //    if (i == index)
            //    {
            //        Console.WriteLine(gallery.cars[index]);
            //    }
            //}

            //masin adina gore tapir...
            //Console.WriteLine("Ad daxil edin: ");
            //string name = Console.ReadLine();
            //for (int i = 0; i < gallery.cars.Length; i++)
            //{
            //    if (name.ToUpper() == gallery.cars[i].Name)
            //    {
            //        Console.WriteLine(true);
            //    }
            //}
        }
    }
}