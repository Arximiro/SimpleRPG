using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    interface IStatistics
    {
        int BattlesWon { get; set; }
        int RanAway { get; set; }
        int GoblinsFought { get; set; }
        int SkeletonsFought { get; set; }
        int DragonsFought { get; set; }
    }
}
