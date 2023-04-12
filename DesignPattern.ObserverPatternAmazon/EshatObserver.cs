using System;

namespace DesignPattern.ObserverPatternAmazon
{
    public class EshatObserver : IObserver
    {
        public string FullName { get; set; }

        public EshatObserver(string fullName)
        {
            FullName = fullName;
        }

        public void StockUpdate(Product product)
        {
            Console.WriteLine($"{FullName}, Product {product.Name} in stock now !!");
        }
    }
}
