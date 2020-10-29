using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class EraserTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Eraser icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Erase something");
        }
    }
}
