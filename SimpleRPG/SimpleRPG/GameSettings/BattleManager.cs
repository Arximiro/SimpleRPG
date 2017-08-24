using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class BattleManager : SpecBox
    {
        EndGame endGame = new EndGame();
        Battle battle = new Battle();
        Random rng = new Random();
        
        

        public void RollChance()
        {
            if (DungeonDifficulty == 1)
            {
                BattleChance = rng.Next(0, 6);
                SkeletonChance = rng.Next(0, 3);
                DragonChance = rng.Next(0, 6);
            }
            else if (DungeonDifficulty == 2)
            {
                BattleChance = rng.Next(0, 5);
                SkeletonChance = rng.Next(0, 2);
                DragonChance = rng.Next(0, 5);
            }
            else if (DungeonDifficulty == 3)
            {
                BattleChance = rng.Next(0, 4);
                SkeletonChance = rng.Next(0, 2);
                DragonChance = rng.Next(0, 4);
            }
        }       

        public bool EnemySelection()
        {
            var monsterManager = new MonsterManager();
            
            if (BattleChance == 0)
            {
                MName = "Goblin";
                MHealth = 45;
                ExpYield = 200;
                PotionChance = rng.Next(0, 6);
                Console.WriteLine($"But You Encountered a {MName}!!!");
                Console.ReadLine();
                Console.Clear();
                GoblinsFought++;
                monsterManager.SetPower();
                return true;
            }
            else if (BattleChance == 1 && SkeletonChance == 1)
            {
                MName = "Skeleton";
                MHealth = 60;
                ExpYield = 350;
                PotionChance = rng.Next(0, 3);
                Console.WriteLine($"But You Encountered a {MName}!!!");
                Console.ReadLine();
                Console.Clear();
                SkeletonsFought++;
                monsterManager.SetPower();
                return true;
            }
            else if (BattleChance == 2 && DragonChance == 1)
            {
                MName = "Dragon";
                MHealth = 150;
                ExpYield = 525;
                PotionChance = rng.Next(0, 1);
                Console.WriteLine($"But You Encountered a {MName}!!!");
                Console.ReadLine();
                Console.Clear();
                DragonsFought++;
                monsterManager.SetPower();
                return true;
            }
            return false;
        }
    }
}
