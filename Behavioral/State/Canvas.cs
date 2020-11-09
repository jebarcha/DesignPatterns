using System;

namespace State
{
    public class Canvas
    {
        // We need to allow Canvas behave differently according the current tool

        private ITool currentTool;
        public void MouseDown() 
        {
            currentTool.MouseDown();
        }
        public void MouseUp()
        {
            currentTool.MouseUp();
        }

        public ITool GetCurrentTool() 
        {
            return currentTool;
        }

        public void SetCurrentTool(ITool currentTool) 
        {
            this.currentTool = currentTool;
        } 

    }
}
