using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class Attack : SpecBox
    {
        public void AttackMonster()
        {
            var dungeonFlow = new DungeonFlow();
            var endGame = new EndGame();
            var battle = new Battle();
            var rng = new Random();

            CritChance = rng.Next(0, 9);
            StrModifier = rng.Next(-6, 7);
            DodgeChance = rng.Next(30, 61);

            if (CritChance == 3)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"\nCRITICAL HIT!!! The {MName} takes {(Strength + StrModifier) * 2} Damage!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                MHealth -= (Strength + StrModifier) * 2;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine($"\nYou Attack the {MName} for {Strength + StrModifier} Damage!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                MHealth -= (Strength + StrModifier);
            }

            if (MHealth < 1)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"You have Defeated the {MName}!");
                Console.ReadLine();
                Console.Write($"You Earned {ExpYield} Experience Points!");
                Console.ReadLine();
                if (PotionChance == 0)
                {
                    Console.WriteLine($"You Find a Potion on the {MName}");
                    PotionCount++;
                    Console.ReadLine();
                }
                ExpEarned += ExpYield;
                BattlesWon++;
                Console.ForegroundColor = ConsoleColor.White;
                dungeonFlow.Advance();
            }

            if (HealthCurrent > 0 && MHealth > 1)
            {
                if (DodgeChance + Agility > 84)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"DODGE! The {MName} Misses You!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The {MName}'s Attack Hits you for {AttackDamage} Damage!");
                    Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    HealthCurrent -= AttackDamage;
                }
            }

            if (HealthCurrent < 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("You Ded, Game OVER!");
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                endGame.GameOver();
            }

            if (MHealth > 0 && HealthCurrent > 0)
            {
                battle.Fight();
            }
        }
    }
}
