using System;
using System.Collections.Generic;

namespace Iterator
{
    public class BrowseHistory
    {
        //private List<String> urls = new List<String>();
        private String[] urls = new String[10];
        private int count;
        public void Push(String url) 
        {
            //urls.Add(url);
            urls[count] = url;
            count++;
        }
        public String Pop() 
        {
            //var lastIndex = urls.Count - 1;
            //var lastUrl = urls[lastIndex];
            //urls.Remove(lastUrl);

            //return lastUrl;

            count--;
            return urls[count];
        }
        public IIterator<String> CreateIterator()
        {
            //return new ListIterator(this);
            return new ArrayIterator(this);
        }

        //public class ListIterator : IIterator<String>
        //{
        //    private BrowseHistory history;
        //    private int index;
        //    public ListIterator(BrowseHistory history)
        //    {
        //        this.history = history;
        //    }
        //    public string Current()
        //    {
        //        return history.urls[index];
        //    }

        //    public bool HasNext()
        //    {
        //        return (index < history.urls.Count);
        //    }

        //    public void Next()
        //    {
        //        index++;
        //    }
        //}

        public class ArrayIterator : IIterator<String>
        {
            private BrowseHistory history;
            private int index;
            public ArrayIterator(BrowseHistory history) 
            {
                this.history = history;
            }
            public string Current()
            {
                return history.urls[index];
            }

            public bool HasNext()
            {
                return (index < history.count);
            }

            public void Next()
            {
                index++;
            }
        }
    }
}
