using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class LevelManager : SpecBox
    {
        public void Exp()
        {
            if (ExpEarned > 349 && CurrentLevel < 2)
            {
                CurrentLevel++;
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
            if (ExpEarned > 999 && CurrentLevel < 3)
            {
                CurrentLevel++;
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
            if (ExpEarned > 1999 && CurrentLevel < 4)
            {
                CurrentLevel++;
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
            if (ExpEarned > 3499 && CurrentLevel < 5)
            {
                CurrentLevel++;
                Console.ForegroundColor = ConsoleColor.Yellow;
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
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear();
            }
        }
    }
}
