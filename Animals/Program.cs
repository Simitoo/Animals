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
using Animals.Models;

int animalsCount = 20;

Area area = new Area();

Position posP = new Position(Random.Shared.Next(0, Console.WindowWidth), Random.Shared.Next(0, Console.WindowHeight));
Predator predators = new Predator(posP);

Position posH = new Position(Random.Shared.Next(0, Console.WindowWidth), Random.Shared.Next(0, Console.WindowHeight));
Herbivore herbivores = new Herbivore(posH);

for (int i = 0; i < animalsCount; i++)
{
    predators.Predators.Add(new Position(Random.Shared.Next(0, Console.WindowWidth), Random.Shared.Next(0, Console.WindowHeight)));
    herbivores.Herbivores.Add(new Position(Random.Shared.Next(0, Console.WindowWidth), Random.Shared.Next(0, Console.WindowHeight)));
}

predators.SetStartPosition();

while (herbivores.Herbivores.Count != 0)
{
    predators.Move();
    predators.Feeding(predators.Predators, herbivores.Herbivores);

    Console.Clear();

    herbivores.Print(herbivores.Herbivores);
    predators.Print(predators.Predators);

    Thread.Sleep(100);
}

