using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    static class LevelManager
    {
        public static void Exp()
        {
            if (SpecBox.ExpEarned > 349 && SpecBox.CurrentLevel < 2)
            {
                SpecBox.CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {SpecBox.CurrentLevel}");
                Console.WriteLine("Health Increased By: 20");
                Console.WriteLine("Stength Increased By: 3");
                Console.WriteLine("Vitality Increased By: 4");
                Console.WriteLine("Agility Increased By: 2");
                SpecBox.HealthFull += 20;
                SpecBox.Strength += 3;
                SpecBox.Vitality += 4;
                SpecBox.Agility += 2;
                SpecBox.NextLevelExp = 600;
                Console.ReadLine();
                Console.Clear();
            }
            if (SpecBox.ExpEarned > 999 && SpecBox.CurrentLevel < 3)
            {
                SpecBox.CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {SpecBox.CurrentLevel}");
                Console.WriteLine("Health Increased By: 30");
                Console.WriteLine("Stength Increased By: 4");
                Console.WriteLine("Vitality Increased By: 3");
                Console.WriteLine("Agility Increased By: 1");
                SpecBox.HealthFull += 30;
                SpecBox.Strength += 4;
                SpecBox.Vitality += 3;
                SpecBox.Agility += 1;
                SpecBox.NextLevelExp = 2000;
                Console.ReadLine();
                Console.Clear();
            }
            if (SpecBox.ExpEarned > 1999 && SpecBox.CurrentLevel < 4)
            {
                SpecBox.CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {SpecBox.CurrentLevel}");
                Console.WriteLine("Health Increased By: 34");
                Console.WriteLine("Stength Increased By: 2");
                Console.WriteLine("Vitality Increased By: 3");
                Console.WriteLine("Agility Increased By: 1");
                SpecBox.HealthFull += 34;
                SpecBox.Strength += 2;
                SpecBox.Vitality += 3;
                SpecBox.Agility += 1;
                SpecBox.NextLevelExp = 3500;
                Console.ReadLine();
                Console.Clear();
            }
            if (SpecBox.ExpEarned > 3499 && SpecBox.CurrentLevel < 5)
            {
                SpecBox.CurrentLevel++;
                Console.WriteLine($"\nLEVEL UP!!! YOU'VE REACHED LEVEL: {SpecBox.CurrentLevel}");
                Console.WriteLine("Health Increased By: 37");
                Console.WriteLine("Stength Increased By: 3");
                Console.WriteLine("Vitality Increased By: 2");
                Console.WriteLine("Agility Increased By: 3");
                SpecBox.HealthFull += 37;
                SpecBox.Strength += 3;
                SpecBox.Vitality += 2;
                SpecBox.Agility += 3;
                SpecBox.NextLevelExp = 10000;
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
