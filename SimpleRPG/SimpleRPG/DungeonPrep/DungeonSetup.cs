using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class DungeonSetup : SpecBox
    {

        public void Play(int difficulty)
        {
            var dungeonFlow = new DungeonFlow();
            DungeonDifficulty = difficulty;
            Setup();
            dungeonFlow.Advance();
        }

        public void Setup()
        {
            Random rng = new Random();
            DungeonPosition = -1;
            CurrentLevel = 1;

            if (DungeonDifficulty == 1)
            {
                DungeonName = "Easy Dungeon";
                DungeonLength = 10;
                PotionCount = 1;
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("EASY DUNGEON");
                Console.WriteLine("-------------");
                Console.WriteLine("\nYou Must Advance 10 Spaces to Win. \nBattles are Less Frequent & Enemies are a Bit Easier.");
                Console.ReadLine();
            }
            else if (DungeonDifficulty == 2)
            {
                DungeonName = "Medium Dungeon";
                DungeonLength = 20;
                PotionCount = 2;
                Console.Clear();
                Console.WriteLine("-------------");
                Console.WriteLine("MEDIUM DUNGEON");
                Console.WriteLine("-------------");
                Console.WriteLine("\nYou Must Advance 20 Spaces to Win. \nBattles More Frequent & Enemies are Harder!");
                Console.ReadLine();
            }
            else if (DungeonDifficulty == 3)
            {
                DungeonName = "Hard Dungeon";
                DungeonLength = 30;
                PotionCount = 3;
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

        public void NameSelection()
        {
            Console.Clear();
            Console.Write("Enter Your Name: ");
            Name = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(Name))
            {
                Console.WriteLine("You Must Enter a Name!");
                NameSelection();
                return;
            }

            RaceSelection();
        }

        public void RaceSelection()
        {
            string choice;
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
                Agility = 36;
            }
            else if (Race == "O")
            {
                Race = "Ogre";
                HealthFull = 80;
                HealthCurrent = 80;
                Strength = 35;
                Vitality = 29;
                Agility = 25;
            }
            else if (Race == "D")
            {
                Race = "Dwarf";
                HealthFull = 65;
                HealthCurrent = 65;
                Strength = 24;
                Vitality = 37;
                Agility = 28;
            }
            else
            {
                Console.Write("Invalid Choice! Press Enter to Start Over: ");
                Console.ReadLine();
                RaceSelection();
                return;
            }

            Console.WriteLine($"\n{Name} the {Race}:\n");
            Console.WriteLine($"HP: {HealthFull} \nStrength {Strength} \nVitality: {Vitality} \nAgility: {Agility}");

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
