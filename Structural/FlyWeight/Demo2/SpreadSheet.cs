using System;
using System.Collections.Generic;
using System.Text;

namespace FlyWeight.Demo2
{
    public class SpreadSheet
    {
        private static int MAX_ROWS = 3;
        private static int MAX_COLS = 3;
        private Cell[,] cells = new Cell[MAX_ROWS, MAX_COLS];
        private CellContextFactory contextFactory;

        public SpreadSheet(CellContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;

            GenerateCells();
        }

        public void SetContent(int row, int col, String content)
        {
            EnsureCellExists(row, col);

            cells[row,col].SetContent(content);
        }

        // We could have a similar method font setting the fontSize or isBold
        // for a given cell. I've omitted that here.
        public void SetFontFamily(int row, int col, String fontFamily)
        {
            EnsureCellExists(row, col);

            var cell = cells[row,col];
            var currentContext = cell.GetContext();
            var context = contextFactory.getContext(fontFamily, currentContext.GetFontSize(), currentContext.IsBold());
            cells[row,col].SetContext(context);
        }

        private void EnsureCellExists(int row, int col)
        {
            if (row < 0 || row >= MAX_ROWS)
                throw new ArgumentException();

            if (col < 0 || col >= MAX_COLS)
                throw new ArgumentException();
        }

        private void GenerateCells()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row,col] = new Cell(row, col, GetDefaultContext());
        }

        private CellContext GetDefaultContext()
        {
            // In a real app, these values should not be hardcoded here.
            // They should be read from a configuration file.
            return new CellContext("Times New Roman", 12, false);
        }

        public void Render()
        {
            for (var row = 0; row < MAX_ROWS; row++)
                for (var col = 0; col < MAX_COLS; col++)
                    cells[row, col].Render();
        }

    }
}
