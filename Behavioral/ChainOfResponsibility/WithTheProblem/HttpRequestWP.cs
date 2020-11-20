using System;

namespace ChainOfResponsibility
{
    public class HttpRequestWP
    {
        private String username;
        private String password;
        public HttpRequestWP(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
        public String GetUsername()
        {
            return username;
        }
        public String GetPassword() 
        {
            return password;
        }

    }
}
