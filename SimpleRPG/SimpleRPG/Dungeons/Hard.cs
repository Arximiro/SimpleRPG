using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Hard
    {
        //Player Specs
        public string Name { get; set; }
        public int HealthFull { get; set; }
        public int HealthCurrent { get; set; }
        public int Strength { get; set; }
        public int Vitality { get; set; }
        public int Agility { get; set; }
        public int ExpEarned { get; set; }
        public int CurrentLevel { get; set; }
        public int NextLevelExp { get; set; }
        public string Race { get; set; }


        //Monstert Specs
        public string MName { get; set; }
        public int MHealth { get; set; }
        public int Attack1 { get; set; }
        public int Attack2 { get; set; }
        public int Attack3 { get; set; }
        public int AttackDamage { get; set; }
        public int ExpYield { get; set; }
        public int PotionChance { get; set; }


        //Dungeon Specs
        public string DungeonName { get; set; }
        public int DungeonLength { get; set; }
        public int MonsterDifficulty { get; set; }
        public int PotionCount { get; set; }
        public int PotionHealAmt { get; set; }
        public int DungeonPosition { get; set; }


        //Game Statistics
        public int BattlesWon { get; set; }
        public int GoblinsFought { get; set; }
        public int SkeletonsFought { get; set; }
        public int DragonsFought { get; set; }
        public int RanAway { get; set; }



        Random RNG = new Random();


        public void Play()
        {
            Setup();
            BeginDunegon();

        }
        public void Setup()
        {
            DungeonPosition = 0;
            DungeonName = "Hard Dungeon";
            DungeonLength = 30;
            PotionCount = 1;
            PotionHealAmt = RNG.Next(35, 51);
            CurrentLevel = 1;
            NextLevelExp = 350;
            Console.Clear();
            Console.WriteLine("You Have Chosen the Hard Dungeon. Prepare to Get Fucked!");
            Console.ReadLine();
            Console.Write("In This Dungeon You Must Move 30 Spaces to Win! Battles are EVEN MORE Common AND More Difficult!");
            Console.ReadLine();
            Console.Write("\nEnter Your Name: ");
            Name = Console.ReadLine();
            RaceSelection();
        }
        public void RaceSelection()
        {
            string stats;
            Console.Clear();
            Console.Write($"Very Well, We Shall Call You {Name}. \n\nNow Pick a Race: (H)uman, (O)gre or (D)warf: ");
            Race = Console.ReadLine().ToUpper();
            if (Race == "H")
            {
                Race = "Human";
                HealthFull = 50;
                HealthCurrent = 50;
                Strength = 28;
                Vitality = 29;
                Agility = 34;
            }
            else if (Race == "O")
            {
                Race = "Ogre";
                HealthFull = 80;
                HealthCurrent = 80;
                Strength = 34;
                Vitality = 30;
                Agility = 26;
            }
            else if (Race == "D")
            {
                Race = "Dwarf";
                HealthFull = 65;
                HealthCurrent = 65;
                Strength = 24;
                Vitality = 37;
                Agility = 27;
            }
            else
            {
                Console.WriteLine("Invalid Choice! Press Enter to Start Over:");
                Console.ReadLine();
                RaceSelection();
                return;
            }

            Console.WriteLine($"\n{Name} the {Race}:\n\nHP: {HealthFull} \nStrength {Strength} \nVitality: {Vitality} \nAgility: {Agility}");
            Console.Write("\nFor a Brief Summary on Stats Press (S) or Hit Enter to Continue to the Dungeon: ");
            stats = Console.ReadLine().ToUpper();

            if (stats == "S")
            {
                Console.WriteLine("\n\nStrength Will Determine How Much You Attack For.");
                Console.WriteLine("Vitality Will Mitigate Damage From Enemy Attacks.");
                Console.WriteLine("Agility Increaes Your Chance to Evade an Attack.");
                Console.ReadLine();
            }
        }

        public void BeginDunegon()
        {
            string choice;

            int battleChance = RNG.Next(0, 4);
            int dragonChance = RNG.Next(0, 5);
            int skeletonChance = RNG.Next(0, 2);

            if (ExpEarned > 349 && CurrentLevel < 2)
            {
                CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {CurrentLevel}");
                Console.WriteLine("Health Increased By: 20");
                Console.WriteLine("Stength Increased By: 3");
                Console.WriteLine("Vitality Increased By: 4");
                Console.WriteLine("Agility Increased By: 2");
                HealthFull += 20;
                Strength += 3;
                Vitality += 4;
                Agility += 2;
                NextLevelExp = 600;
                Console.ReadLine();
                Console.Clear();
            }
            if (ExpEarned > 999 && CurrentLevel < 3)
            {
                CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {CurrentLevel}");
                Console.WriteLine("Health Increased By: 30");
                Console.WriteLine("Stength Increased By: 4");
                Console.WriteLine("Vitality Increased By: 3");
                Console.WriteLine("Agility Increased By: 1");
                HealthFull += 30;
                Strength += 4;
                Vitality += 3;
                Agility += 1;
                NextLevelExp = 2000;
                Console.ReadLine();
                Console.Clear();
            }
            if (ExpEarned > 1999 && CurrentLevel < 4)
            {
                CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {CurrentLevel}");
                Console.WriteLine("Health Increased By: 34");
                Console.WriteLine("Stength Increased By: 2");
                Console.WriteLine("Vitality Increased By: 3");
                Console.WriteLine("Agility Increased By: 1");
                HealthFull += 34;
                Strength += 2;
                Vitality += 3;
                Agility += 1;
                NextLevelExp = 3500;
                Console.ReadLine();
                Console.Clear();
            }
            if (ExpEarned > 3499 && CurrentLevel < 5)
            {
                CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {CurrentLevel}");
                Console.WriteLine("Health Increased By: 37");
                Console.WriteLine("Stength Increased By: 3");
                Console.WriteLine("Vitality Increased By: 2");
                Console.WriteLine("Agility Increased By: 3");
                HealthFull += 37;
                Strength += 3;
                Vitality += 2;
                Agility += 3;
                NextLevelExp = 10000;
                Console.ReadLine();
                Console.Clear();
            }

            if (DungeonPosition > 29)
            {
                Success();
                return;
            }

            else if (DungeonPosition < 30)
            {
                Console.Clear();
                Console.WriteLine($"Current Position in {DungeonName}: {DungeonPosition}");
                Console.WriteLine($"Health Remaining: {HealthCurrent}/{HealthFull} ");
                Console.WriteLine($"Potions Remaining: {PotionCount}");
                Console.Write("\nPress Enter to Advance One Position or (P) to use a Potion: ");
                choice = Console.ReadLine().ToUpper();

                if (choice == "P")
                {
                    if (PotionCount > 0)
                    {
                        if (HealthCurrent < HealthFull)
                        {
                            Console.WriteLine($"{Name} Recovers {PotionHealAmt} Health. \nHealth Remaining: {HealthCurrent}");
                            Console.ReadLine();
                            HealthCurrent = HealthCurrent + PotionHealAmt;
                            if (HealthCurrent > HealthFull)
                            {
                                HealthCurrent = HealthFull;
                            }
                            PotionCount--;
                            BeginDunegon();
                            return;
                        }
                        else if (HealthCurrent == HealthFull)
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
                        BeginDunegon();
                        return;
                    }

                }


                if (battleChance == 0)
                {
                    MName = "Goblin";
                    MHealth = 45;
                    ExpYield = 200;
                    PotionChance = RNG.Next(0, 6);
                    Console.WriteLine($"You encountered a {MName}!!!");
                    Console.ReadLine();
                    GoblinsFought++;
                    Fight();
                }
                else if (battleChance == 1 && skeletonChance == 1)
                {
                    MName = "Skeleton";
                    MHealth = 60;
                    ExpYield = 350;
                    PotionChance = RNG.Next(0, 4);
                    Console.WriteLine($"You encountered a {MName}!!!");
                    Console.ReadLine();
                    SkeletonsFought++;
                    Fight();
                }
                else if (battleChance == 2 && dragonChance == 1)
                {
                    MName = "Dragon";
                    MHealth = 150;
                    ExpYield = 525;
                    PotionChance = RNG.Next(0, 1);
                    Console.WriteLine($"You encountered a {MName}!!!");
                    Console.ReadLine();
                    DragonsFought++;
                    Fight();
                }
                else
                {
                    Console.WriteLine("\nYou Sucessfully Moved Up One Position Safely.");
                    Console.ReadLine();
                    DungeonPosition++;
                    BeginDunegon();
                }
            }
        }

        public void Fight()
        {
            int critChance = RNG.Next(0, 11);
            int strModifier = RNG.Next(-6, 7);
            int dodgeChance = RNG.Next(30, 61);
            Attack1 = RNG.Next(50, 70);
            Attack2 = RNG.Next(55, 85);
            Attack3 = RNG.Next(45, 90);
            string battlechoice;
            string battleMSG = "BATTLE IN PROGRESS";
            if (MName == "Goblin") { AttackDamage = Attack1 - Vitality; }
            if (MName == "Skeleton") { AttackDamage = Attack2 - Vitality; }
            if (MName == "Dragon") { AttackDamage = Attack3 - Vitality; }
            if (AttackDamage < 0) { AttackDamage = 0; }

            Console.Clear();
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (battleMSG.Length / 2)) + "}", battleMSG));
            Console.Write($"\n\nHP: {HealthCurrent}/{HealthFull} \nPotions Remaining: {PotionCount} \n\nEnter (R) to attempt to Run: \nEnter (P) to Use a Potion: \nOr Press Enter to Attack the {MName}: ");
            battlechoice = Console.ReadLine().ToUpper();

            if (battlechoice == "")
            {
                if (critChance == 3)
                {
                    Console.WriteLine($"\nCRITICAL HIT!!! The {MName} takes {(Strength + strModifier) * 2} Damage!");
                    Console.ReadLine();
                    MHealth = MHealth - (Strength + strModifier) * 2;
                }
                else
                {
                    Console.WriteLine($"\nYou Attack the {MName} for {Strength + strModifier} Damage!");
                    Console.ReadLine();
                    MHealth = MHealth - (Strength + strModifier);
                }

                if (MHealth < 1)
                {
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
                    DungeonPosition++;
                    BeginDunegon();
                    return;
                }

                if (HealthCurrent > 1 && MHealth > 1)
                {
                    if (dodgeChance + Agility > 84)
                    {
                        Console.WriteLine($"DODGE! The {MName} Misses You!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"The {MName}'s Attack Hits you for {AttackDamage} Damage!");
                        Console.ReadLine();
                        HealthCurrent = HealthCurrent - AttackDamage;
                    }
                }

                if (HealthCurrent < 1)
                {
                    Console.WriteLine("You Ded, Game OVER!");
                    Console.ReadLine();
                    GameOver();
                    return;
                }

                if (MHealth > 1 && HealthCurrent > 1)
                {
                    Fight();
                    return;
                }
            }

            else if (battlechoice == "R")
            {
                int runChance = RNG.Next(0, 4);
                if (runChance == 1)
                {
                    Console.WriteLine("You Sucessfully Escaped!");
                    Console.ReadLine();
                    RanAway++;
                    DungeonPosition++;
                    BeginDunegon();
                    return;
                }
                else
                {
                    Console.WriteLine("\nEscape Failed!");
                    Console.ReadLine();
                    if (dodgeChance + Agility > 80)
                    {
                        Console.WriteLine($"DODGE! The {MName} Misses You!");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine($"The {MName}'s Attack Hits you for {AttackDamage} Damage!");
                        Console.ReadLine();
                        HealthCurrent = HealthCurrent - AttackDamage;
                    }
                    if (HealthCurrent < 1)
                    {
                        Console.WriteLine("\nYou Ded, Game OVER!");
                        Console.ReadLine();
                        GameOver();
                        return;
                    }
                    Fight();
                    return;
                }
            }

            else if (battlechoice == "P")
            {
                if (PotionCount > 0)
                {
                    if (HealthCurrent == HealthFull)
                    {
                        Console.WriteLine("Health is Full, You Cannot Use a Potion!");
                        Fight();
                        return;
                    }
                    else if (HealthCurrent < HealthFull)
                    {
                        HealthCurrent = HealthCurrent + PotionHealAmt;
                        PotionCount--;
                        if (HealthCurrent > HealthFull)
                        {
                            HealthCurrent = HealthFull;
                            Console.WriteLine($"{Name} Recovers {PotionHealAmt} Health. \nHealth Remaining: {HealthCurrent}");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine($"{Name} Recovers {PotionHealAmt} Health. \nHealth Remaining: {HealthCurrent}");
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
            DungeonPosition++;
            BeginDunegon();
        }

        public void GameOver()
        {
            Console.Clear();
            Console.WriteLine($"You were Slain by a {MName}. You made it to position {DungeonPosition} in {DungeonName}. Nice Try!");
            Console.ReadLine();
            StatsPage();
        }
        public void Success()
        {
            Console.Clear();
            Console.WriteLine($"You survived {DungeonName} until the end! Good Job!");
            Console.ReadLine();
            StatsPage();
        }
        public void StatsPage()
        {
            Game G = new Game();
            string playAgain;
            string stats = "YOUR FINAL STATS";
            Console.Clear();

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (stats.Length / 2)) + "}", stats));
            Console.WriteLine($"Hero Name: {Name} \nHero Race: {Race} \n\nFinal Player Stats:");
            Console.Write($"Level: {CurrentLevel} \nExperience: {ExpEarned}/{NextLevelExp}");
            Console.Write($"\nHealth Remaining: {HealthCurrent}/{HealthFull} \nStrength: {Strength} \nVitality: {Vitality} \nAgility: {Agility}");
            Console.Write($"\n\nBattle Stats: \nDungeon Difficulty: {DungeonName} \nDungeon Position Reached: {DungeonPosition} \nTotal Battles: {BattlesWon} \nTimes You Ran: {RanAway}");
            Console.Write($"\nGoblins Fought: {GoblinsFought} \nSkeletons Fought: {SkeletonsFought} \nDragons Fought: {DragonsFought}");

            Console.Write("\n\nWould you like to play again? (Y) or (N): ");
            playAgain = Console.ReadLine().ToUpper();
            if (playAgain == "Y")
            {
                G.Play();
                return;
            }
            else if (playAgain == "N")
            {
                return;
            }
            else
            {
                Console.WriteLine($"\n{playAgain} is NOT a valid choice");
                Console.ReadLine();
                StatsPage();
                return;
            }
        }

    }
}
