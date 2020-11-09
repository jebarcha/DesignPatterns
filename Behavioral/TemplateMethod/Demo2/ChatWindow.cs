using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Demo2
{
    public class ChatWindow: Window
    {
        protected override void OnClosed()
        {
            Console.WriteLine("Disconnecting from the server...");
        }

        protected override void OnClosing()
        {
            Console.WriteLine("Before close here to perform something in ChatWindow");
        }
    }
}
