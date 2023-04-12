using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ObserverPatternAmazon
{
    public class Amazon
    {
        private Dictionary<IObserver, Product> observerList = new Dictionary<IObserver, Product>();
        public void Register( IObserver observer, Product product)
        {
            observerList.TryAdd(observer, product);
        }
        public void UnRegister(IObserver observer)
        {
            observerList.Remove(observer);

        }

        public void NotifyAll()
        {
            foreach (var observer in observerList)
            {
                observer.Key.StockUpdate(observer.Value);
            }
        }

        public void NotifyForProductName(string productName)
        {
            foreach (var kv in observerList)
            {
                if (kv.Value.Name==productName)
                    kv.Key.StockUpdate(kv.Value);                
            }
        }

    }
}
