using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class SpecBox
    {
        //Player Specs
        public static string Name { get; set; }
        public static string Race { get; set; }
        public static int HealthFull { get; set; }
        public static int HealthCurrent { get; set; }

        public static int Strength { get; set; }
        public static int Vitality { get; set; }
        public static int Agility { get; set; }

        public static int ExpEarned { get; set; }
        public static int CurrentLevel { get; set; }
        public static int NextLevelExp { get; set; }
        
        public static int CritChance { get; set; }
        public static int StrModifier { get; set; }
        public static int DodgeChance { get; set; } 


        //Monster Specs
        public static string MName { get; set; }
        public static int MHealth { get; set; }

        public static int ExpYield { get; set; }
        public static int PotionChance { get; set; }

        public static int Attack1 { get; set; }
        public static int Attack2 { get; set; }
        public static int Attack3 { get; set; }
        public static int AttackDamage { get; set; }


        //Dungeon Specs
        public static string DungeonName { get; set; }
        public static int DungeonLength { get; set; }
        public static int DungeonDifficulty { get; set; }
        public static int BattleChance { get; set; }
        public static int SkeletonChance { get; set; }
        public static int DragonChance { get; set; }
        public static int MonsterDifficulty { get; set; }
        public static int PotionCount { get; set; }
        public static int PotionHealAmt { get; set; }
        public static int DungeonPosition { get; set; }


        //Game Statistics
        public static int BattlesWon { get; set; }
        public static int PotionsUsed { get; set; }
        public static int GoblinsFought { get; set; }
        public static int SkeletonsFought { get; set; }
        public static int DragonsFought { get; set; }
        public static int RanAway { get; set; }
    }
}
