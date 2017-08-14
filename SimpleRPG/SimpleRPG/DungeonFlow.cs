using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    static class DungeonFlow
    {
        public static void BeginDunegon()
        {
            string choice;
            Random rng = new Random();
            SpecBox.PotionHealAmt = rng.Next(40, 51);
            LevelManager.Exp();

            if (SpecBox.DungeonDifficulty == 1)
            {
                SpecBox.BattleChance = rng.Next(0, 6);
                SpecBox.SkeletonChance = rng.Next(0, 3);
                SpecBox.DragonChance = rng.Next(0, 6);
            }
            else if (SpecBox.DungeonDifficulty == 2)
            {
                SpecBox.BattleChance = rng.Next(0, 5);
                SpecBox.SkeletonChance = rng.Next(0, 2);
                SpecBox.DragonChance = rng.Next(0, 5);
            }
            else if (SpecBox.DungeonDifficulty == 3)
            {
                SpecBox.BattleChance = rng.Next(0, 4);
                SpecBox.SkeletonChance = rng.Next(0, 2);
                SpecBox.DragonChance = rng.Next(0, 4);
            }

            
            if (SpecBox.DungeonPosition > SpecBox.DungeonLength - 1)
            {
                EndGame.Success();
                return;
            }

            else if (SpecBox.DungeonPosition < SpecBox.DungeonLength)
            {
                Console.Clear();
                Console.WriteLine($"Current Position in {SpecBox.DungeonName}: {SpecBox.DungeonPosition}");
                Console.WriteLine($"Health Remaining: {SpecBox.HealthCurrent}/{SpecBox.HealthFull} ");
                Console.WriteLine($"Potions Remaining: {SpecBox.PotionCount}");
                Console.Write("\nPress Enter to Advance One Position or (P) to use a Potion: ");
                choice = Console.ReadLine().ToUpper();

                if (choice == "P")
                {
                    if (SpecBox.PotionCount > 0)
                    {
                        if (SpecBox.HealthCurrent < SpecBox.HealthFull)
                        {
                            SpecBox.HealthCurrent = SpecBox.HealthCurrent + SpecBox.PotionHealAmt;
                            if (SpecBox.HealthCurrent > SpecBox.HealthFull)
                            {
                                SpecBox.HealthCurrent = SpecBox.HealthFull;
                            }
                            Console.WriteLine($"{SpecBox.Name} Recovers {SpecBox.PotionHealAmt} Health. \nHealth Remaining: {SpecBox.HealthCurrent}");
                            Console.ReadLine();
                            SpecBox.PotionCount--;
                            SpecBox.PotionsUsed++;
                            BeginDunegon();
                            return;
                        }
                        else if (SpecBox.HealthCurrent == SpecBox.HealthFull)
                        {
                            Console.WriteLine("Health is Full, You Cannot Use a Potion!");
                            Console.ReadLine();
                            BeginDunegon();
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You Have No Potions!");
                        Console.ReadLine();
                        BeginDunegon();
                        return;
                    }

                }


                if (SpecBox.BattleChance == 0)
                {
                    SpecBox.MName = "Goblin";
                    SpecBox.MHealth = 45;
                    SpecBox.ExpYield = 200;
                    SpecBox.PotionChance = rng.Next(0, 6);
                    Console.WriteLine($"You encountered a {SpecBox.MName}!!!");
                    Console.ReadLine();
                    SpecBox.GoblinsFought++;
                    Battle.Fight();
                }
                else if (SpecBox.BattleChance == 1 && SpecBox.SkeletonChance == 1)
                {
                    SpecBox.MName = "Skeleton";
                    SpecBox.MHealth = 60;
                    SpecBox.ExpYield = 350;
                    SpecBox.PotionChance = rng.Next(0, 3);
                    Console.WriteLine($"You encountered a {SpecBox.MName}!!!");
                    Console.ReadLine();
                    SpecBox.SkeletonsFought++;
                    Battle.Fight();
                }
                else if (SpecBox.BattleChance == 2 && SpecBox.DragonChance == 1)
                {
                    SpecBox.MName = "Dragon";
                    SpecBox.MHealth = 150;
                    SpecBox.ExpYield = 525;
                    SpecBox.PotionChance = rng.Next(0, 1);
                    Console.WriteLine($"You encountered a {SpecBox.MName}!!!");
                    Console.ReadLine();
                    SpecBox.DragonsFought++;
                    Battle.Fight();
                }
                else
                {
                    Console.WriteLine("\nYou Sucessfully Moved Up One Position Safely.");
                    Console.ReadLine();
                    SpecBox.DungeonPosition++;
                    BeginDunegon();
                }
            }
        }
    }
}
