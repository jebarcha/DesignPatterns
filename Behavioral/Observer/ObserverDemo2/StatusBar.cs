using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ObserverDemo2
{
    public class StatusBar : IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void addStock(Stock stock)
        {
            stocks.Add(stock);
            stock.addObserver(this);
        }

        public void show()
        {
            Console.WriteLine("Status Bar");
            foreach (var stock in stocks)
                Console.WriteLine(stock);
        }
        public void priceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StatusBar");
            show();
        }
    }
}
