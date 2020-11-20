using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class AuthenticatorWP
    {
        public bool authenticate(HttpRequest request) 
        {
            var isValid = (request.GetUsername() == "admin" &&
                           request.GetPassword() == "1234");

            Console.WriteLine("Authentication");
            return isValid;
        }
    }
}
