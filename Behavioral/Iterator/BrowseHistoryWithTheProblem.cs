using System;
using System.Collections.Generic;

namespace Iterator
{
    public class BrowseHistoryWithTheProblem
    {
        private List<String> urls = new List<String>();
        public void Push(String url) 
        {
            urls.Add(url);
        }
        public String Pop() 
        {
            var lastIndex = urls.Count - 1;
            var lastUrl = urls[lastIndex];
            urls.Remove(lastUrl);

            return lastUrl;
        }
        public List<String> GetUrls()
        {
            return urls;
        }

    }
}
