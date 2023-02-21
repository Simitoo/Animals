namespace Animals.Models
{
    public class Direction : IEquatable<Direction>
    {
        Direction(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException($"'{nameof(value)}' cannot be null or whitespace.", nameof(value));

            Value = value;
        }

        public string Value { get; }

        public readonly static Direction Up = new ("up");
        public readonly static Direction Down = new("down");
        public readonly static Direction Left = new("left");
        public readonly static Direction Right = new("right");

        public static Direction Random()
        {
            int directions = System.Random.Shared.Next(0, 4);
            switch (directions)
            {
                case 0:
                    return Up;
                case 1:
                    return Down;
                case 2:
                    return Left;
                case 3:
                    return Right;
                default:
                    throw new NotSupportedException($"Not supppoorted direction '{directions}'");
            }
        }

        public bool Equals(Direction other)
        {
            if (ReferenceEquals(null, other)) 
                return false;

            return Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as Direction);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public static bool operator ==(Direction obj1, Direction obj2)
        {
            return obj1.Equals(obj2);
        }

        public static bool operator !=(Direction obj1, Direction obj2)
        {
            return (obj1 == obj2) == false;
        }
    }
}
