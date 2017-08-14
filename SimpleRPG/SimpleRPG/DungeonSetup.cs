using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    static class DungeonSetup
    {
        
        public static void Play(int difficulty)
        {
            SpecBox.DungeonDifficulty = difficulty;
            Setup();
            DungeonFlow.BeginDunegon();
        }

        public static void Setup()
        {
            Random rng = new Random();
            SpecBox.DungeonPosition = 0;
            SpecBox.CurrentLevel = 1;
            SpecBox.NextLevelExp = 350;

            if (SpecBox.DungeonDifficulty == 1)
            {
                SpecBox.DungeonName = "Easy Dungeon";
                SpecBox.DungeonLength = 10;
                SpecBox.PotionCount = 1;
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("EASY DUNGEON");
                Console.WriteLine("-------------");
                Console.WriteLine("\nYou Must Advance 10 Spaces to Win. \nBattles are Less Frequent & Enemies are a Bit Easier.");
                Console.ReadLine();
            }
            else if (SpecBox.DungeonDifficulty == 2)
            {
                SpecBox.DungeonName = "Medium Dungeon";
                SpecBox.DungeonLength = 20;
                SpecBox.PotionCount = 2;
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("MEDIUM DUNGEON");
                Console.WriteLine("-------------");
                Console.WriteLine("\nYou Must Advance 20 Spaces to Win. \nBattles More Frequent & Enemies are Harder!");
                Console.ReadLine();
            }
            else if (SpecBox.DungeonDifficulty == 3)
            {
                SpecBox.DungeonName = "Hard Dungeon";
                SpecBox.DungeonLength = 30;
                SpecBox.PotionCount = 3;
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("HARD DUNGEON");
                Console.WriteLine("-------------");
                Console.WriteLine("\nYou Must Advance 30 Spaces to Win. \nBattles are Even More Frequent & Enemies are Even Harder!");
                Console.ReadLine();
                Console.Write("Prepare to Get Fucked!");
                Console.ReadLine();
            }
            
            NameSelection();
        }

        public static void NameSelection()
        {
            Console.Clear();
            Console.Write("Enter Your Name: ");
            SpecBox.Name = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(SpecBox.Name))
            {
                Console.WriteLine("You Must Enter a Name!");
                NameSelection();
                return;
            }

            RaceSelection();
        }

        public static void RaceSelection()
        {
            string choice;
            Console.Clear();
            Console.Write($"Very Well, We Shall Call You {SpecBox.Name}. \n\nNow Pick a Race: (H)uman, (O)gre or (D)warf: ");
            SpecBox.Race = Console.ReadLine().ToUpper();
            if (SpecBox.Race == "H")
            {
                SpecBox.Race = "Human";
                SpecBox.HealthFull = 50;
                SpecBox.HealthCurrent = 50;
                SpecBox.Strength = 28;
                SpecBox.Vitality = 29;
                SpecBox.Agility = 34;
            }
            else if (SpecBox.Race == "O")
            {
                SpecBox.Race = "Ogre";
                SpecBox.HealthFull = 80;
                SpecBox.HealthCurrent = 80;
                SpecBox.Strength = 34;
                SpecBox.Vitality = 30;
                SpecBox.Agility = 26;
            }
            else if (SpecBox.Race == "D")
            {
                SpecBox.Race = "Dwarf";
                SpecBox.HealthFull = 65;
                SpecBox.HealthCurrent = 65;
                SpecBox.Strength = 24;
                SpecBox.Vitality = 37;
                SpecBox.Agility = 27;
            }
            else
            {
                Console.Write("Invalid Choice! Press Enter to Start Over: ");
                Console.ReadLine();
                RaceSelection();
                return;
            }

            Console.WriteLine($"\n{SpecBox.Name} the {SpecBox.Race}:\n");
            Console.WriteLine($"HP: {SpecBox.HealthFull} \nStrength {SpecBox.Strength} \nVitality: {SpecBox.Vitality} \nAgility: {SpecBox.Agility}");

            Console.Write("\nFor a Brief Summary on Stats Press (S) or Hit Enter to Continue to the Dungeon: ");
            choice = Console.ReadLine().ToUpper();

            if (choice == "S")
            {
                Console.WriteLine("\n\nStrength Will Determine How Much You Attack For.");
                Console.WriteLine("Vitality Will Mitigate Damage From Enemy Attacks.");
                Console.WriteLine("Agility Increaes Your Chance to Evade an Attack.");
                Console.ReadLine();
            }
        }

    }
}
