using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Demo2
{
    public class TwitterClient
    {
        public List<Tweet> getRecentTweets(String accessToken)
        {
            Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}