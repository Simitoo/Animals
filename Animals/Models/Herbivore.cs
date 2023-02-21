using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    public class Herbivore : Animal
    {
        public Herbivore(Position position) : base(position)
        {
        }

        public override void Eat()
        {
        }

        public override void Print(List<Position> list)
        {
            foreach (Position pos in list)
            {
                Console.SetCursorPosition(pos.Row, pos.Col);
                Console.Write("O");
            }
        }
    }
}
