using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    static class StatsPage
    {

        public static void StatsReadout()
        {
            string playAgain;
            string stats = "YOUR FINAL STATS";
            Console.Clear();

            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (stats.Length / 2)) + "}", stats));
            Console.WriteLine($"Hero Name: {SpecBox.Name} \nHero Race: {SpecBox.Race} \n\nFinal Player Stats:");
            Console.Write($"Level: {SpecBox.CurrentLevel} \nExperience: {SpecBox.ExpEarned}/{SpecBox.NextLevelExp}");
            Console.Write($"\nHealth Remaining: {SpecBox.HealthCurrent}/{SpecBox.HealthFull} \nStrength: {SpecBox.Strength} \nVitality: {SpecBox.Vitality} \nAgility: {SpecBox.Agility}");
            Console.Write($"\n\nBattle Stats: \nDungeon Difficulty: {SpecBox.DungeonName} \nDungeon Position Reached: {SpecBox.DungeonPosition} \nTotal Battles: {SpecBox.BattlesWon} \nTimes You Ran: {SpecBox.RanAway}");
            Console.Write($"\nGoblins Fought: {SpecBox.GoblinsFought} \nSkeletons Fought: {SpecBox.SkeletonsFought} \nDragons Fought: {SpecBox.DragonsFought}");

            Console.Write("\n\nWould you like to play again? (Y) or (N): ");
            playAgain = Console.ReadLine().ToUpper();
            if (playAgain == "Y")
            {
                Game.Play();
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
                StatsReadout();
                return;
            }
        }

    }
}
