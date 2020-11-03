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

        public List<Tweet> getRecentTweets()
        {
            var twitterClient = new TwitterClient();
            var tweets = twitterClient.getRecentTweets(getAccessToken());

            return tweets;
        }

        private String getAccessToken()
        {
            var oauth = new OAuth();
            var requestToken = oauth.requestToken(appKey, secret);
            var accessToken = oauth.getAccessToken(requestToken);

            return accessToken;
        }
    }
}
