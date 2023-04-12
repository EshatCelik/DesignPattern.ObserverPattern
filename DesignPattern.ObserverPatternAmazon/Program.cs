using System;

namespace DesignPattern.ObserverPatternAmazon
{
    class Program
    {
        static void Main(string[] args)
        {
            var samsung = new Product("Samsung S23", 1000);
            var observer = new EshatObserver("Eshat Çelik");

            var amazon = new Amazon();

            amazon.Register(observer, samsung);
            amazon.NotifyForProductName("Samsung S23");

            Console.ReadLine();
        }
    }
}
