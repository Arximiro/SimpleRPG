using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    interface IMonster
    {
        string MName { get; set; }
        int MHealth { get; set; }

        int Attack1 { get; set; }
        int Attack2 { get; set; }
        int Attack3 { get; set; }
        int PotionChance { get; set; }

        int AttackDamage { get; set; }

        int ExpYield { get; set; }
    }
}
