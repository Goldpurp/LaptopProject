using System;
using System.Collections.Generic;
using System.Text;

namespace Laptop
{
   public class Laptop
    {
        private string Product;

        private int Size;

        private string Colour;

        private int Year;

        private double Price;

        public Laptop(string Product, int Size, string Colour, int Year, double Price)
        {
            this.Product = Product;

            this.Size = Size;

            this.Colour = Colour;

            this.Year = Year;

            this.Price = Price;
        }
        public string GetProduct()
        {
            return Product;
        }
        public void SetProduct( string productName)
        {
            Product = productName;
        }

        public int GetSize()
        {
            return Size;
        }
        public void SetSize(int productSize)
        {
            Size = productSize;
        }
        public string GetColour()
        {
            return Colour;
        }
        public void SetColour(string productColour)
        {
            Colour = productColour;
        }
        public int GetYear()
        {
            return Year;
        }
        public void SetYear(int productYear)
        {
            Year = productYear;
        }
        public double GetPrice()
        {
            return Price;
        }
        public void SetPrice( double productPrice)
        {
            Price = productPrice;
        }
            
    }
}
