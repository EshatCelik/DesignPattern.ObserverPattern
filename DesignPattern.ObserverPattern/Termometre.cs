using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPattern
{
    public class Termometre:Observable
    {

        public int InstantTemp { get; set; } = 24;
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public Termometre( int minTemp, int maxTemp)
        {
            MinTemp = minTemp;
            MaxTemp = maxTemp;
        }

        public int InstantTemperature()
        {
            return InstantTemp;
        }
        public void UpdateTemperature(int temp)
        {
            InstantTemp = temp;

            Console.WriteLine("Sıcaklık : "+InstantTemp);
            CheckTemperature();
        }
        public void CheckTemperature()
        {
            var maxTemp = InstantTemp.CompareTo(MaxTemp) >= 0;
            var minTemp = InstantTemp.CompareTo(MinTemp) <= 0;
            if (maxTemp||minTemp)
            {
                NotifyObserver();
            }
        }

    }
}
