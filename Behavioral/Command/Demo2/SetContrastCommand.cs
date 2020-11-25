using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Demo2
{
    public class SetContrastCommand: AbstractUndoableCommand
    {
        private float prevContrast;
        private float contrast;

        public SetContrastCommand(float contrast, VideoEditor videoEditor, History history): base(videoEditor, history)
        {
            prevContrast = videoEditor.GetContrast();
            this.contrast = contrast;
        }

        protected override void DoExecute()
        {
            videoEditor.SetContrast(contrast);
        }

        public override void Undo()
        {
            videoEditor.SetContrast(prevContrast);
        }
    }
}
