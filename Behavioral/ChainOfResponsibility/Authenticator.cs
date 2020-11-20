using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Authenticator: Handler
    {
        public Authenticator(Handler next) : base(next)
        {
        }

        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.GetUsername() == "admin" &&
                             request.GetPassword() == "1234");

            Console.WriteLine("Authentication");

            return !isValid;
        }
    }
}
