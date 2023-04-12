namespace DesignPattern.ObserverPatternAmazon
{
    public interface IObserver
    {
        string FullName { get; set; }
        public void StockUpdate(Product product);
    }
}
