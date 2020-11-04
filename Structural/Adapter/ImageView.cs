using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class ImageView
    {
        private Image image;

        public ImageView(Image image)
        {
            this.image = image;
        }

        public void apply(IFilter filter)
        {
            filter.apply(image);
        }
    }
}
