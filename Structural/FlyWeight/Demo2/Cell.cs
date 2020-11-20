using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Demo2
{
    public class Cell
    {
        private readonly int row;
        private readonly int column;
        private String content;
        private CellContext context;
        public Cell(int row, int column, CellContext context)
        {
            this.row = row;
            this.column = column;
            this.context = context;
        }

        public void SetContent(String content)
        {
            this.content = content;
        }

        public CellContext GetContext()
        {
            return context;
        }

        public void SetContext(CellContext context)
        {
            this.context = context;
        }

        public void Render()
        {
            //System.out.printf("(%d, %d): %s [%s]\n", row, column, content, context.getFontFamily());
            Console.WriteLine($"{row}, {column}, {content}, {context.GetFontFamily()}\n");
        }
    }
}
