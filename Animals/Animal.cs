using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Animal
    {
        public Animal(int rowIndex, int colIndex)
        {
            RowIndex = rowIndex;
            ColIndex = colIndex;
            IsEaten = false;
        }

        public int RowIndex { get; set; }
        public int ColIndex { get; set; }
        public bool IsEaten { get; set; }


        public void Move(char[,] area)
        {

        }

    }
}
