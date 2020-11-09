using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Demo2
{
    public class TwitterAPI
    {
        private String appKey;
        private String secret;

        public TwitterAPI(String appKey, String secret)
        {
            this.appKey = appKey;
            this.secret = secret;
        }

        public List<Tweet> GetRecentTweets()
        {
            var twitterClient = new TwitterClient();
            var tweets = twitterClient.GetRecentTweets(GetAccessToken());

            return tweets;
        }

        private String GetAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken(appKey, secret);
            var accessToken = oauth.GetAccessToken(requestToken);

            return accessToken;
        }
    }
}
