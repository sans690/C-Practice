using System;

class ChallengeSix
{
    static void Main(string[] args)
    {
        int heroHealth = 10;
        int monsterHealth = 10;
        int heroAttackValue = Random.Shared.Next(1, 11);
        int monsterAttackValue = Random.Shared.Next(1, 11);
        do
        {
            monsterHealth = monsterHealth - heroAttackValue;
            Console.WriteLine($"Monster was damaged and lost {heroAttackValue} health and now has {monsterHealth} health.");

            heroHealth = heroHealth - monsterAttackValue;
            Console.WriteLine($"Hero was damaged and lost {monsterAttackValue} health and now has {heroHealth} health.");
        } while (monsterHealth > 0 && heroHealth > 0);

        if (monsterHealth > 0)
        {
            Console.WriteLine("Monster wins!");
        }

        else if (heroHealth > 0)
        {
            Console.WriteLine("Hero. wins!");
        }
    }
}