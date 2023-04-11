using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    public class Ebeveyn : IObserver
    {
        public string Name { get; set; }
        public Ebeveyn( string name)
        {
            Name = name;
        }
        public void Update( Observable observable)
        {
            Termometre termometre = (Termometre)observable;

            Console.WriteLine( Name +" Dedi ki : Sıcaklık "+termometre.InstantTemperature() +" derece olmuş !!!");
        }
    }
}
