using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ObserverDemo2
{
     public class Stock
    {
        private String symbol;
        private float price;
        private List<IObserver> observers = new List<IObserver>();

        public Stock(String symbol, float price)
        {
            this.symbol = symbol;
            this.price = price;
        }

        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers()
        {
            foreach (var observer in observers)
                observer.PriceChanged();
        }

        public float GetPrice()
        {
            return price;
        }

        public void SetPrice(float price)
        {
            this.price = price;
            NotifyObservers();
        }

        public String toString()
        {
            return "Stock{" +
                    "symbol='" + symbol + '\'' +
                    ", price=" + price +
                    '}';
        }
    }
}
