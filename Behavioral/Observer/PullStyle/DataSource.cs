using System;

namespace Observer
{
    public class DataSource: Subject
    {
        // We need to figure out how to notify another objects like Chart and SpreadSheet of the value changes
        // inherit from Subject, that way this DataSource class inherits all the capability of becoming a publisher or an observable object

        private int value;

        public int GetValue() 
        {
            return value;
        }
        public void SetValue(int value) 
        {
            this.value = value;
            NotifyObservers();
        }

    }
}
