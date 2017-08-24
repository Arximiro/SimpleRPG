using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class Run : SpecBox
    {
        public void RunAway()
        {
            var rng = new Random();
            var dungeonFlow = new DungeonFlow();
            var battle = new Battle();
            var endGame = new EndGame();

            int runChance = rng.Next(0, 4);

            if (runChance == 1)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("You Sucessfully Escaped!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                RanAway++;
                DungeonPosition++;
                dungeonFlow.Advance();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nEscape Failed!");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
                if (DodgeChance + Agility > 80)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"DODGE! The {MName} Misses You!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"The {MName}'s Attack Hits you for {AttackDamage} Damage!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    HealthCurrent = HealthCurrent - AttackDamage;
                }
                if (HealthCurrent < 1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nYou Ded, Game OVER!");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    endGame.GameOver();
                }
                battle.Fight();
            }
        }
    }
}
