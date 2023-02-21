namespace Animals.Models
{
    public class World
    {
        public World(int size)
        {
            if (size <= 0) throw new ArgumentOutOfRangeException(nameof(size));

            Size = size;
            var cells = new List<Cell>();
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    cells.Add(new Cell(Position.From(y, x)));
                }
            }

            Cells = cells;
        }

        public int Size { get; }

        public IEnumerable<Cell> Cells { get; }

        public IEnumerable<Animal> Animals { get; }

        public void Cycle()
        {
            foreach (var cell in Cells)
            {
                foreach (var animal in cell.Animals)
                {
                    var newPosition = animal.Move();
                    var newCell = Cells.FirstOrDefault(x => x.Position == newPosition);
                    if (newCell is null)
                        continue;

                    newCell.Visit(animal);
                }
            }
        }
    }
}
