using System;
using System.Collections.Generic;
using System.Text;

namespace State
{
    public class BrushTool : ITool
    {
        public void mouseDown()
        {
            Console.WriteLine("Brush icon");
        }

        public void mouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
