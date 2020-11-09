using System;

namespace TemplateMethod
{
    public class TransferMoneyTask: Task
    {
        protected override void DoExecute()
        {
            Console.WriteLine("Transfer Money");
        }

    }
}
