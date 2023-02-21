namespace Animals.Models
{
    public class Cell
    {
        private readonly List<Animal> animals = new List<Animal>();

        public Cell(Position position)
        {
            Position = position ?? throw new ArgumentNullException(nameof(position));
        }

        public Position Position { get; }
        
        public IEnumerable<Animal> Animals => animals.AsReadOnly();

        public void Visit(Animal animal)
        {
            if (animals.Contains(animal)) throw new InvalidOperationException($"Cell with coordinates ({Position.Row}:{Position.Col}) already conntains annimal.");

            animals.Add(animal);
            animal.Move(this);
        }
    }
}
