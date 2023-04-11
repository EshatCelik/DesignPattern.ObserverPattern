using System;

namespace DesignPattern.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Termometre termometre = new Termometre(23, 28);

            Ebeveyn anne = new Ebeveyn("Anne");
            Ebeveyn baba = new Ebeveyn("Baba");

            termometre.AddObserver(anne);

            for (int i = termometre.InstantTemp; i <= 30; i++)
            {
                termometre.UpdateTemperature(i);
            }
            Console.WriteLine("------------------------------------------");
            for (int i = termometre.InstantTemp; i >= 22; i--)
            {
                termometre.UpdateTemperature(i);
            }



            Console.ReadLine();
        }
    }
}
