using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    interface IDungeon
    {
        string DungeonName { get; set; }
        int DungeonLength { get; set; }
        int DungeonDifficulty { get; set; }

        int BattleChance { get; set; }
        int SkeletonChance { get; set; }
        int DragonChance { get; set; }
        int MonsterDifficulty { get; set; }
        int PotionCount { get; set; }
        int PotionHealAmt { get; set; }
        int DungeonPosition { get; set; }
    }
}
