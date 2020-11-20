using System;

namespace ChainOfResponsibility
{
    public class HttpRequest
    {
        private String username;
        private String password;
        public HttpRequest(string username, string password)
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
