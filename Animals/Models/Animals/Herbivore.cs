using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models.Animals
{
    public class Herbivore : Animal
    {
        public Herbivore(Position position) : base(position)
        {
        }

        public override void Eat()
        {
        }

        public override void Print()
        {
            Console.Write("O");
        }
    }
}
