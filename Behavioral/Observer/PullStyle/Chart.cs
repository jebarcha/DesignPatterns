using System;
using System.Collections.Generic;
using System.Text;

namespace Observer
{
    public class Chart : IObserver
    {
        private DataSource dataSource;
        public Chart(DataSource dataSource)
        {
            this.dataSource = dataSource;
        }
        public void Update()
        {
            Console.WriteLine("Chart got Updated: " + dataSource.GetValue());
        }
    }
}
