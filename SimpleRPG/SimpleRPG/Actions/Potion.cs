using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class Potion : SpecBox
    {
        public void UsePotion()
        {
            var rng = new Random();
            var battle = new Battle();

            PotionHealAmt = rng.Next(40, 51);

            if (PotionCount > 0)
            {
                if (HealthCurrent < HealthFull)
                {
                    HealthCurrent += PotionHealAmt;
                    if (HealthCurrent > HealthFull)
                    {
                        HealthCurrent = HealthFull;
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n{Name} Recovers {PotionHealAmt} Health.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    PotionCount--;
                    PotionsUsed++;
                    battle.Fight();
                }
                else if (HealthCurrent == HealthFull)
                {
                    Console.WriteLine("\nHealth is Full, You Cannot Use a Potion!");
                    Console.ReadLine();
                    battle.Fight();
                }
            }
            else
            {
                Console.WriteLine("\nYou Have No Potions!");
                Console.ReadLine();
                battle.Fight();
            }
        }
    }
}
