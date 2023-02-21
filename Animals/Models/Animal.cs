using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Animals.Models;

namespace Animals
{
    public abstract class Animal
    {
        private Position position;
        private List<Position> predators;
        private List<Position> herbivores;

        public Animal(Position position)
        {
            this.position = position;
            this.predators = new List<Position>();
            this.herbivores = new List<Position>();
        }

        public List<Position> Predators => this.predators;

        public List<Position> Herbivores => this.herbivores;

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

        private Position RangeSetter(int nextRow, int nextCol)
        {
            if (nextCol < 0)
            {
                nextCol = 0;
            }
            else if (nextCol >= Console.WindowHeight)
            {
                nextCol = Console.WindowHeight - 1;
            }

            if (nextRow < 0)
            {
                nextRow = 0;
            }
            else if (nextRow >= Console.WindowWidth)
            {
                nextRow = Console.WindowWidth - 1;
            }

            Position newPosition = new Position(nextRow, nextCol);

            return newPosition;

        }

        public virtual void SetStartPosition()
        {
            foreach (Position pos in predators)
            {
                Console.SetCursorPosition(pos.Row, pos.Col);
                Console.Write("X");
            }
        }

        public virtual void Print(List<Position> list)
        {

        }
    }
}
