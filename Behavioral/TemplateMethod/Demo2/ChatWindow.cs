using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Demo2
{
    public class ChatWindow: Window
    {
        protected override void onClosed()
        {
            Console.WriteLine("Disconnecting from the server...");
        }

        protected override void onClosing()
        {
            Console.WriteLine("Before close here to perform something in ChatWindow");
        }
    }
}
