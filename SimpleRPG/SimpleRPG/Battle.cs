using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Battle
    {
        public static void Fight()
        {
            Random rng = new Random();
            var Attack1 = 0;
            var Attack2 = 0;
            var Attack3 = 0;
            var AttackDamage = 0;

            if (SpecBox.DungeonDifficulty == 1)
            {
                Attack1 = rng.Next(43, 54);
                Attack2 = rng.Next(44, 76);
                Attack3 = rng.Next(36, 75);
            }
            else if (SpecBox.DungeonDifficulty == 2)
            {
               Attack1 = rng.Next(45, 62);
               Attack2 = rng.Next(50, 68);
               Attack3 = rng.Next(41, 82);
            }
            else if (SpecBox.DungeonDifficulty == 3)
            {
                Attack1 = rng.Next(50, 70);
                Attack2 = rng.Next(55, 85);
                Attack3 = rng.Next(45, 90);
            }

            int critChance = rng.Next(0, 11);
            int strModifier = rng.Next(-6, 7);
            int dodgeChance = rng.Next(30, 61);

            string battlechoice;
            string battleMSG = "BATTLE IN PROGRESS";
            if (SpecBox.MName == "Goblin") { AttackDamage = Attack1 - SpecBox.Vitality; }
            if (SpecBox.MName == "Skeleton") { AttackDamage = Attack2 - SpecBox.Vitality; }
            if (SpecBox.MName == "Dragon") { AttackDamage = Attack3 - SpecBox.Vitality; }
            if (AttackDamage < 0) { AttackDamage = 0; }

            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (battleMSG.Length / 2)) + "}", battleMSG));
            Console.Write($"\n\nHP: {SpecBox.HealthCurrent}/{SpecBox.HealthFull} \n\nEnter (R) to attempt to Run: \nEnter (P) to Use a Potion: \nOr Press Enter to Attack the {SpecBox.MName}: ");
            battlechoice = Console.ReadLine().ToUpper();

            if (battlechoice == "")
            {
                if (critChance == 3)
                {
                    Console.WriteLine($"\nCRITICAL HIT!!! The {SpecBox.MName} takes {(SpecBox.Strength + strModifier) * 2} Damage!");
                    Console.ReadLine();
                    SpecBox.MHealth = SpecBox.MHealth - (SpecBox.Strength + strModifier) * 2;
                }
                else
                {
                    Console.WriteLine($"\nYou Attack the {SpecBox.MName} for {SpecBox.Strength + strModifier} Damage!");
                    Console.ReadLine();
                    SpecBox.MHealth = SpecBox.MHealth - (SpecBox.Strength + strModifier);
                }

                if (SpecBox.MHealth < 1)
                {
                    Console.WriteLine($"You have Defeated the {SpecBox.MName}!");
                    Console.ReadLine();
                    Console.Write($"You Earned {SpecBox.ExpYield} Experience Points!");
                    Console.ReadLine();
                    if (SpecBox.PotionChance == 0)
                    {
                        Console.WriteLine($"You Find a Potion on the {SpecBox.MName}");
                        SpecBox.PotionCount++;
                        Console.ReadLine();
                    }
                    SpecBox.ExpEarned += SpecBox.ExpYield;
                    SpecBox.BattlesWon++;
                    SpecBox.DungeonPosition++;
                    DungeonFlow.BeginDunegon();
                    return;
                }

                if (SpecBox.HealthCurrent > 1 && SpecBox.MHealth > 1)
                {
                    if (dodgeChance + SpecBox.Agility > 84)
                    {
                        Console.WriteLine($"DODGE! The {SpecBox.MName} Misses You!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"The {SpecBox.MName}'s Attack Hits you for {AttackDamage} Damage!");
                        Console.ReadLine();
                        SpecBox.HealthCurrent = SpecBox.HealthCurrent - AttackDamage;
                    }
                }

                if (SpecBox.HealthCurrent < 1)
                {
                    Console.WriteLine("You Ded, Game OVER!");
                    Console.ReadLine();
                    EndGame.GameOver();
                    return;
                }

                if (SpecBox.MHealth > 1 && SpecBox.HealthCurrent > 1)
                {
                    Fight();
                    return;
                }
            }

            else if (battlechoice == "R")
            {
                int runChance = rng.Next(0, 4);
                if (runChance == 1)
                {
                    Console.WriteLine("You Sucessfully Escaped!");
                    Console.ReadLine();
                    SpecBox.RanAway++;
                    SpecBox.DungeonPosition++;
                    DungeonFlow.BeginDunegon();
                    return;
                }
                else
                {
                    Console.WriteLine("\nEscape Failed!");
                    Console.ReadLine();
                    if (dodgeChance + SpecBox.Agility > 80)
                    {
                        Console.WriteLine($"DODGE! The {SpecBox.MName} Misses You!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"The {SpecBox.MName}'s Attack Hits you for {AttackDamage} Damage!");
                        Console.ReadLine();
                        SpecBox.HealthCurrent = SpecBox.HealthCurrent - AttackDamage;
                    }
                    if (SpecBox.HealthCurrent < 1)
                    {
                        Console.WriteLine("\nYou Ded, Game OVER!");
                        Console.ReadLine();
                        EndGame.GameOver();
                        return;
                    }
                    Fight();
                    return;
                }
            }

            else if (battlechoice == "P")
            {
                if (SpecBox.PotionCount > 0)
                {
                    if (SpecBox.HealthCurrent == SpecBox.HealthFull)
                    {
                        Console.WriteLine("Health is Full, You Cannot Use a Potion!");
                        Fight();
                        return;
                    }
                    else if (SpecBox.HealthCurrent < SpecBox.HealthFull)
                    {
                        SpecBox.HealthCurrent = SpecBox.HealthCurrent + SpecBox.PotionHealAmt;
                        SpecBox.PotionCount--;
                        SpecBox.PotionsUsed++;
                        if (SpecBox.HealthCurrent > SpecBox.HealthFull)
                        {
                            SpecBox.HealthCurrent = SpecBox.HealthFull;
                            Console.WriteLine($"{SpecBox.Name} Recovers {SpecBox.PotionHealAmt} Health. \nHealth Remaining: {SpecBox.HealthCurrent}");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"{SpecBox.Name} Recovers {SpecBox.PotionHealAmt} Health. \nHealth Remaining: {SpecBox.HealthCurrent}");
                            Console.ReadLine();
                        }
                        Fight();
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("You Have No Potions!");
                    Console.ReadLine();
                    Fight();
                    return;
                }

            }

            else
            {
                Console.WriteLine("That is NOT a valid choice!");
                Console.ReadLine();
                Fight();
                return;
            }

            SpecBox.DungeonPosition++;
            DungeonFlow.BeginDunegon();
        }
    }
}
