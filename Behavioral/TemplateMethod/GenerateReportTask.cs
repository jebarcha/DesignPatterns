using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod
{
    public class GenerateReportTask: Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Generate Report");
        }

        //private AuditTrail auditTrail;

        //public GenerateReportTask(AuditTrail auditTrail)
        //{
        //    this.auditTrail = auditTrail;
        //}

        //public void Execute() 
        //{
        //    auditTrail.Record();
        //    Console.WriteLine("Generate Report");
        //}
    }
}
