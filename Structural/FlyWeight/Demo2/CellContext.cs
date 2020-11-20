using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Demo2
{
    public class CellContext
    {
        // These are the attributes that can be shared by many cells.
        // That's why I've encapsulated them inside this class.
        // Our CellContextFactory class will ensure that every combination
        // of these attributes will only be stored once.
        private readonly String fontFamily;
        private readonly int fontSize;
        private readonly bool isBold;

        public CellContext(String fontFamily, int fontSize, bool isBold)
        {
            this.fontFamily = fontFamily;
            this.fontSize = fontSize;
            this.isBold = isBold;
        }

        public String GetFontFamily()
        {
            return fontFamily;
        }

        public int GetFontSize()
        {
            return fontSize;
        }

        public bool IsBold()
        {
            return isBold;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(fontFamily, fontSize, isBold);
        }

    }
}
