using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class EndGame : SpecBox
    {
        public void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"You were Slain by a {MName}. You made it to position {DungeonPosition} in {DungeonName}. Nice Try!");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            StatsPage.StatsReadout();
        }

        public void Success()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"You Survived {DungeonName} Until the End! Good Job!");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            StatsPage.StatsReadout();
        }
    }
}
