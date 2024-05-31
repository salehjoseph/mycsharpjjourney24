Random random = new Random();
int current = random.Next(1, 11);

do
{
    current = random.Next(1, 11);

    if (current >= 8)
        continue;

    Console.WriteLine(current);
} while (current != 7);

/*
Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!

while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
*/

int Herohealth = 10;
int Monsterhealth = 10;
do
{
    Random dice = new Random();

    int roll1 = dice.Next(1, 11); // Heroes attack
    Monsterhealth -= roll1;
    Console.WriteLine(
        $"Monster was damaged and lost {roll1} health and now has {Monsterhealth} health."
    );
    if(Monsterhealth <= 0) continue;
   //Monsters attack
    Herohealth -= roll1;
    Console.WriteLine($"Hero was damaged and lost {roll1} health and now has {Herohealth} health.");
} while (((Herohealth > 0) && (Monsterhealth > 0)));

if (Herohealth > Monsterhealth)
{
    Console.WriteLine("Hero wins");
}
else
{
    Console.WriteLine("Monster Wins");
}
