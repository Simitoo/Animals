using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Position
    {
        public Position(int row, int col)
        {
            //if (row < 0) throw new ArgumentOutOfRangeException(nameof(row));
            //if (col < 0) throw new ArgumentOutOfRangeException(nameof(col));

            Row = row;
            Col = col;
        }

        public int Row { get; }

        public int Col { get; }
    }
}
