using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class AuditTrail
    {
        public void Record() 
        {
            Console.WriteLine("Audit");
        }
    }
}
