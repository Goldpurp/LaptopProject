using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
    public class LaptopRepo
    {
        public List<Laptop> Lappy = new List<Laptop>();

        public void AddLaptop(string product, int size, string colour, int year, double price)
        {
            var laptop = FindLaptop(product);

            if(laptop == null)
            {
                var newLaptop = new Laptop(product, size, colour, year, price);

                Lappy.Add(newLaptop);
            }
            else
            {
                Console.WriteLine($"{product} already exist");
            }
        }

        public void GetNewLaptop()
        {
            foreach(var Laptop in Lappy)
            {
                Console.WriteLine($" {Laptop.GetProduct()} {Laptop.GetSize()} {Laptop.GetColour()} {Laptop.GetYear()} {Laptop.GetPrice()} ");
            }
        }
        public Laptop FindLaptop( string product)
        {

            return Lappy.Find(lapT => lapT.GetProduct() == product);

        }
        public void Show(string product)
        {
            var uniqueChar = FindLaptop(product);
            if (uniqueChar != null)
            {
                Console.WriteLine($" { uniqueChar.GetProduct()} { uniqueChar.GetSize()} { uniqueChar.GetColour()} { uniqueChar.GetYear()} { uniqueChar.GetPrice()} ");
            }
            else
            {
                Console.WriteLine($"{product} is not found ");
            }
            
        }

        public void DeleteProduct(string product)
        {
            var laptop = FindLaptop(product);
            Lappy.Remove(laptop);
            
        }

        public void EditProduct(string product, int Size, string Colour, int Year, int Price)
        {
            var laptop = FindLaptop(product);

            if (laptop != null)
            {
                laptop.SetSize(Size);
                laptop.SetColour(Colour);
                laptop.SetYear(Year);
                laptop.SetPrice(Price);

                Console.WriteLine($" {laptop.GetProduct()} {laptop.GetSize()} {laptop.GetColour()} {laptop.GetYear()} {laptop.GetPrice()} ");

            }
            else
            {
                Console.WriteLine($"{product} is not found ");
            } 

        }

    }
}
