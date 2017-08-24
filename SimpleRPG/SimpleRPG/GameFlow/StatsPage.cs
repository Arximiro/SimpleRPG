using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class StatsPage : SpecBox
    {

        public static void StatsReadout()
        {
            string stats = "YOUR FINAL STATS";
            Console.Clear();

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (stats.Length / 2)) + "}", stats));
            Console.WriteLine($"Hero Name: {Name} \nHero Race: {Race} \n\nFinal Player Stats:");
            Console.Write($"Level: {CurrentLevel} \nExperience: {ExpEarned}/{NextLevelExp}");
            Console.Write($"\nHealth Remaining: {HealthCurrent}/{HealthFull} \nStrength: {Strength} \nVitality: {Vitality} \nAgility: {Agility}");
            Console.Write($"\n\nBattle Stats: \nDungeon Difficulty: {DungeonName} \nDungeon Position Reached: {DungeonPosition} \nTotal Battles: {BattlesWon} \nTimes You Ran: {RanAway}");
            Console.Write($"\nGoblins Fought: {GoblinsFought} \nSkeletons Fought: {SkeletonsFought} \nDragons Fought: {DragonsFought}");

            Console.Write("\n\nWould you like to play again? (Y) or (N): ");
            string playAgain = Console.ReadLine().ToUpper();

            if (playAgain == "Y")
            {
                ExpEarned = 0;
                CurrentLevel = 1;
                NextLevelExp = 350;
                PotionCount = 0;
                DungeonPosition = 0;
                BattlesWon = 0;
                PotionsUsed = 0;
                GoblinsFought = 0;
                SkeletonsFought = 0;
                DragonsFought = 0;
                RanAway = 0;

                Game.Play();
            }

            else if (playAgain == "N")
                return;

            else
            {
                Console.WriteLine($"\n{playAgain} is NOT a valid choice");
                Console.ReadLine();
                StatsReadout();
            }
        }

    }
}
