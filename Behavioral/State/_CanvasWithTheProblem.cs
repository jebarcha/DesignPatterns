using System;

namespace State
{
    public class _CanvasWithTheProblem
    {
        // We have a lot of If else statements or switch case and repeating 
        // all these statements in different places in the code
        // We could have also KeyDown and KeyUp
        // Maintaining this code is difficult and is very long
        // There is a lack of extensibility, not easy to extend

        // We need to allow Canvas behave differently according the selected tool
        // or We want the method perform different code depending on the selected tool

        private ToolType currentTool;
        public void MouseDown() 
        {
            if (currentTool == ToolType.SELECTION)
            {
                Console.WriteLine("Selection icon");
            }
            else if (currentTool == ToolType.BRUSH) 
            {
                Console.WriteLine("Brush icon");
            }
            else if (currentTool == ToolType.ERASER)
            {
                Console.WriteLine("Brush eraser");
            }
        }
        public void MouseUp()
        {
            if (currentTool == ToolType.SELECTION)
            {
                Console.WriteLine("Draw dashed rectangle");
            }
            else if (currentTool == ToolType.BRUSH)
            {
                Console.WriteLine("Draw a line");
            }
            else if (currentTool == ToolType.ERASER)
            {
                Console.WriteLine("Erase something");
            }
        }

        public ToolType GetCurrentTool() 
        {
            return currentTool;
        }

    }
}
