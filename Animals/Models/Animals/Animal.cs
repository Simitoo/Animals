using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Models;
using Animals.Models.Enum;

namespace Animals.Models.Animals
{
    public abstract class Animal
    {
        private Position position;

        public Animal(Position position)
        {
            this.position = position;
        }

        public string Type => this.GetType().Name;

        public Gender Gender { get; }

        public Cell CurrentCell { get; private set; }

        public Position CurrentPosition => CurrentCell.Position;

        public virtual Position Move()
        {
            var direction = Direction.Random();
            var nextMove = CurrentPosition.To(direction);

            return nextMove;
        }

        public virtual void Move(Cell cell)
        {
            CurrentCell = cell;
        }

        public abstract void Eat();

        public Animal Multiply(Animal animal)
        {
            Animal newAnimal = null;

            if (this.Type == animal.Type &&
                this.Gender != animal.Gender)
            {
                //babyyy
            }

            return newAnimal;
        }


        //foreach (var animal in world.Animals.Models)
        //{
        //   Console.SetCursorPosition(animal.CurrentPosition.Row, animal.CurrentPosition.Col);
        //   Console.Write("X");
        //}

        public virtual void Print()
        {
            Console.SetCursorPosition(CurrentPosition.Row, CurrentPosition.Col);
            Console.Write("X");
        }     
    }
}
