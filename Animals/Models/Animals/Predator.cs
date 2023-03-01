using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models.Animals
{
    public class Predator : Animal
    {
        public Predator(Position position) : base(position)
        {
        }

        public override void Eat()
        {

        }

        //public void Feeding(List<Position> predators, List<Position> herbivores) // polymorphism ??????????????
        //{
        //    List<Position> eatenAnimals = new List<Position>();

        //    for (int i = 0; i < predators.Count; i++)
        //    {
        //        for (int j = 0; j < herbivores.Count; j++)
        //        {
        //            if (predators[i].Row == herbivores[j].Row && predators[i].Col == herbivores[j].Col)
        //            {
        //                eatenAnimals.Add(herbivores[j]);
        //            }
        //        }
        //    }

        //    for (int i = 0; i < eatenAnimals.Count; i++)
        //    {
        //        herbivores.Remove(eatenAnimals[i]);
        //    }
        //}

        public override void Print()
        {          
        }
    }
}
