using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    static class EndGame
    {
        public static void GameOver()
        {
            Console.Clear();
            Console.WriteLine($"You were Slain by a {SpecBox.MName}. You made it to position {SpecBox.DungeonPosition} in {SpecBox.DungeonName}. Nice Try!");
            Console.ReadLine();
            StatsPage.StatsReadout();
        }
        public static void Success()
        {
            Console.Clear();
            Console.WriteLine($"You survived {SpecBox.DungeonName} until the end! Good Job!");
            Console.ReadLine();
            StatsPage.StatsReadout();
        }
    }
}
