using System;

namespace Laptop
{
    class Program
    {
        static void Main(string[] args)
        {
            LaptopRepo rep = new LaptopRepo();


          /*  Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Product Size: ");
            int productSize = int.Parse(Console.ReadLine());

            Console.Write("Product Colour: ");
            string producColour = Console.ReadLine();

            Console.Write("Product Year: ");
            int productYear = int.Parse(Console.ReadLine());

            Console.Write("Product Price: ");
            int productPrice = int.Parse(Console.ReadLine());


            rep.AddLaptop( productName, productSize,producColour, productYear, productPrice );*/

            rep.AddLaptop("lenovo", 15, "black", 2020, 250000);

            rep.AddLaptop("hp", 15, "black", 2020, 250000);

            rep.AddLaptop("dell", 15, "black", 2020, 250000);

            rep.AddLaptop("hp", 15, "black", 2020, 250000);






            //rep.Show("lenovo");

            //rep.DeleteProduct("hp");

            //rep.EditProduct("dell", 17, "grey", 2021, 92200);

            rep.GetNewLaptop();

            Console.ReadKey();

        }
    }
}
