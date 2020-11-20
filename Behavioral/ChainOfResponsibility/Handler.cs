using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public abstract class Handler
    {
        private Handler next;
        public Handler(Handler next)
        {
            this.next = next;
        }
        public void handle(HttpRequest request) 
        {
            if (DoHandle(request)) 
            {
                return;
            }
            if (next != null) 
            {
                next.handle(request);
            }
        }
        public abstract bool DoHandle(HttpRequest request);
    }
}
