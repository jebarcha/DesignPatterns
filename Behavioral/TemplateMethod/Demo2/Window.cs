using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethod.Demo2
{
    public abstract class Window
    {
        public void close()
        {
            // custom windows may need to execute some code before the window is closed.
            OnClosing();

            Console.WriteLine("Removing the window from the screen");

            // custom windows may need to execute some code after the window is closed.
            OnClosed();
        }

        protected abstract void OnClosing();
        protected abstract void OnClosed();
    }
}
