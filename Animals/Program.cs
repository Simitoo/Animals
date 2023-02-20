//1st set position on all animals -> random indexes
//range when moving
// Only predators can move?

//2nd moving predators and everytime they move, matrix should be changed
//predators "X", herbivores "O"
//when moving you should check if X is on O 
//  -> if O then have a 30% chance to be eaten => E(eaten) we should do something
//  -> what happens when X is on X? 

//moving stop when there isn't left any O





using Animals;


Console.BufferHeight = Console.WindowHeight;
Console.BufferWidth = Console.WindowWidth;


Positions[] positions = new Positions[]
{
    new Positions(-1, 0), // u
    new Positions(1, 0), // d
    new Positions(0, -1), // l 
    new Positions(0, 1), // r   
};

int currPosition = 0;


Random random = new Random();

List<Positions> predators = new List<Positions>();
List<Positions> herbivores = new List<Positions>();

for (int i = 0; i < 30; i++)
{
    predators.Add(new Positions(random.Next(0, Console.WindowWidth), random.Next(0, Console.WindowHeight)));
    herbivores.Add(new Positions(random.Next(0, Console.WindowWidth), random.Next(0, Console.WindowHeight)));
}

foreach (Positions pos in predators)
{
    Console.SetCursorPosition(pos.Row, pos.Col);
    Console.Write("X");
}

while (herbivores.Count != 0)
{
    Positions nextMove;

    for (int i = 0; i < predators.Count; i++)
    {
        int directions = random.Next(0, 4);

        switch (directions)
        {
            case 0:
                currPosition = 0;
                break;
            case 1:
                currPosition = 1;
                break;
            case 2:
                currPosition = 2;
                break;
            case 3:
                currPosition = 3;
                break;
        }

        nextMove = positions[currPosition];

        Positions newPredatorsPos = RangeSetter(predators[i].Row + nextMove.Row, predators[i].Col + nextMove.Col);

        predators.Remove(predators[i]);
        predators.Add(newPredatorsPos);

        if (predators[i] == herbivores[i])
        {
            herbivores.RemoveAt(i);
        }
    }

    Console.Clear();

    foreach (Positions pos in predators)
    {
        Console.SetCursorPosition(pos.Row, pos.Col);
        Console.Write("X");
    }

    foreach (Positions pos in herbivores)
    {
        Console.SetCursorPosition(pos.Row, pos.Col);
        Console.Write("O");
    }

    Thread.Sleep(300);
}


Positions RangeSetter(int nextRow, int nextCol)
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

    Positions newPosition = new Positions(nextRow, nextCol);

    return newPosition;

}