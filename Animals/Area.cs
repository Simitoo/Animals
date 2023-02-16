using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Area
    {
        private int _rowRange, _colRange;

        public Area(int rowRange, int columnRange)
        {
            RowRange = rowRange;
            ColumnRange = columnRange;
            CreateArea();
        }

        public int RowRange
        {
            get { return _rowRange; }
            set { _rowRange = value; }
        }
        public int ColumnRange
        {
            get { return _colRange; }
            set { _colRange = value; }
        }

        private void CreateArea()
        {
            char[,] area = new char[_rowRange, _colRange];

            for (int row = 0; row < area.GetLength(0); row++)
            {
                for (int col = 0; col < area.GetLength(1); col++)
                {
                    area[row, col] = '_';
                }
            }
        }
    }
}
