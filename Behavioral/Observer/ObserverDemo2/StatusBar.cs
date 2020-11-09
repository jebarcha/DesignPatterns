using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ObserverDemo2
{
    public class StatusBar : IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void AddStock(Stock stock)
        {
            stocks.Add(stock);
            stock.AddObserver(this);
        }

        public void Show()
        {
            Console.WriteLine("Status Bar");
            foreach (var stock in stocks)
                Console.WriteLine(stock);
        }
        public void PriceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StatusBar");
            Show();
        }
    }
}
