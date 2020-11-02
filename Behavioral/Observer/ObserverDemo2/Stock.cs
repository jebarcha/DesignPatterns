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

        public void addObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void notifyObservers()
        {
            foreach (var observer in observers)
                observer.priceChanged();
        }

        public float getPrice()
        {
            return price;
        }

        public void setPrice(float price)
        {
            this.price = price;
            notifyObservers();
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
