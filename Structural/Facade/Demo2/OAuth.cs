﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.Demo2
{
    public class OAuth
    {
        public String RequestToken(String appKey, String appSecret)
        {
            Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public String GetAccessToken(String requestToken)
        {
            Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}
