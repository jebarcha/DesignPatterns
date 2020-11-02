using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class SpreadSheet : IObserver
    {
        private DataSource dataSource;  // this is coupled, but it is not a bad type of coupling, we can deal with it in the observer pattern

        public SpreadSheet(DataSource dataSource) 
        {
            this.dataSource = dataSource;
        }
        public void update()
        {
            Console.WriteLine("Spreadsheet got notified: " + dataSource.getValue());
        }
    }
}
