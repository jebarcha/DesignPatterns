using System;

namespace TemplateMethod
{
    public class TransferMoneyTask: Task
    {
        protected override void doExecute()
        {
            Console.WriteLine("Transfer Money");
        }

    }
}
