using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPatternAmazon
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

    }
}
