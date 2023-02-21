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
            this.herbivores= new List<Position>();
        }

        public List<Position> Predators => this.predators;

        public List<Position> Herbivores => this.herbivores;

        public virtual void Move()
        {       
            Position nextMove = new Position(0, 0);

            for (int i = 0; i < predators.Count; i++)
            {
                int directions = Random.Shared.Next(0, 4);

                switch (directions)
                {
                    case 0:
                        nextMove = new Position(-1, 0);
                        break;
                    case 1:
                        nextMove = new Position(1, 0);
                        break;
                    case 2:
                        nextMove = new Position(0, -1);
                        break;
                    case 3:
                        nextMove = new Position(0, 1);
                        break;
                }
             
                Position newPredatorsPos = RangeSetter(predators[i].Row + nextMove.Row, predators[i].Col + nextMove.Col);

                predators.Remove(predators[i]);
                predators.Add(newPredatorsPos);
            }
        }

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
