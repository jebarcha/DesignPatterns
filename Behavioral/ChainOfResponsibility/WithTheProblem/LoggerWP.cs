using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class LoggerWP
    {
        public void Log(HttpRequest request) 
        {
            Console.WriteLine("Log");
        }
    }
}
