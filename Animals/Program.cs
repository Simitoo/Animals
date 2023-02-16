//1st set position on all animals -> random indexes
//range when moving
// Only predators can move?

//2nd moving predators and everytime they move, matrix should be changed
// empty spaces with "_", predators "X", herbivores "O"
//when moving you should check if X is on O or is on _
//  -> if is _ then the symbol should be X
//  -> else if O then have a 30% chance to be eaten => O changed to X or E(eaten) or _ because we should do something when is E
//  -> what happens when X is on X? =>

//moving stop when there isn't left any O

char[,] area = new char[10,10];

for(int row = 0; row < area.GetLength(0); row++)
{
    for(int col = 0; col < area.GetLength(1); col++)
    {
        area[row, col] = '_';
    }
}

PrintMatrix(area);

static void PrintMatrix(char[,] area)
{
    for(int row = 0; row < area.GetLength(0); row++)
    {
        for(int col = 0; col < area.GetLength(1); col++)
        {
            Console.Write(area[row, col]);
        }

        Console.WriteLine();
    }
}
