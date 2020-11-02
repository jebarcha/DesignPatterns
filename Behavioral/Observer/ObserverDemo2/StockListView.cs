using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.ObserverDemo2
{
    public class StockListView: IObserver
    {
        private List<Stock> stocks = new List<Stock>();

        public void addStock(Stock stock)
        {
            stocks.Add(stock);
            stock.addObserver(this);
        }

        public void show()
        {
            Console.WriteLine("Stock List View");
            foreach (var stock in stocks)
                Console.WriteLine(stock);
        }
        public void priceChanged()
        {
            Console.WriteLine("Price Changed - Refreshing StockListView");
            show();
        }
    }
}
