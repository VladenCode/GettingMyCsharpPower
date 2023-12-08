/*
This program uses randomly generated number to simulate damages inflicted in a battle between hero and monster. 
*/

//Mine solution
/*
Random random = new Random();


int hero = 10;
int monster = 10;

do
{
  int damage = random.Next(1,11);
  Console.WriteLine($"Hero attacks monster inflicting {damage} damage points");
  monster -= damage;
  Console.WriteLine($"Monster health: {monster}");

  if(monster > 0)
  {
    damage = random.Next(1,11);
    Console.WriteLine($"Monster attacks hero inflicting {damage} damage points");
    hero -= damage;
    Console.WriteLine($"Hero health: {hero}");
  }
  else
  {
    Console.WriteLine($"Monster is dead");
    Console.WriteLine($"Hero remaining health: {hero}");
    break;
  }
}while(hero > 0);

if(hero <= 0)
Console.WriteLine($"Hero is dead");
*/

//Other solution

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");