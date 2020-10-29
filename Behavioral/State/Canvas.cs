using System;

namespace State
{
    public class Canvas
    {
        // We need to allow Canvas behave differently according the current tool

        private ITool currentTool;
        public void mouseDown() 
        {
            currentTool.mouseDown();
        }
        public void mouseUp()
        {
            currentTool.mouseUp();
        }

        public ITool getCurrentTool() 
        {
            return currentTool;
        }

        public void setCurrentTool(ITool currentTool) 
        {
            this.currentTool = currentTool;
        } 

    }
}
