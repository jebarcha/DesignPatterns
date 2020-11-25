using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Demo2
{
    public class VideoEditor
    {
        private float contrast = 0.5f;
        private String text;

        public void SetText(String text)
        {
            this.text = text;
        }

        public void RemoveText()
        {
            this.text = "";
        }

        public float GetContrast()
        {
            return contrast;    
        }

        public void SetContrast(float contrast)
        {
            this.contrast = contrast;
        }

        public override String ToString()
        {
            return "VideoEditor{" +
                    "contrast=" + contrast +
                    ", text='" + text + '\'' +
                    '}';
        }
    }
}
