using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
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

        public static Position From(int y, int x) => new Position(y, x);

        public Position To(Direction direction)
        {
            return new Position(Row, Col);  
        }

        public Position Up()
        {
            if (Row == 0)
                return new Position(0, Col);

            return new Position(Row - 1, Col);
        }

        public Position Down()
        {
            return new Position(Row + 1, Col);
        }

        public Position Left()
        {
            if (Col == 0)
                return new Position(Row, 0);

            return new Position(Row, Col - 1);
        }

        public Position Right()
        {
            return new Position(Row, Col + 1);
        }
    }
}
