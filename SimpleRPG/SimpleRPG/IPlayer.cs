using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    interface IPlayer
    {
        string Name { get; set; }

        int HealthFull { get; set; }
        int HealthCurrent { get; set; }
        int Strength { get; set; }
        int Vitality { get; set; }
        int Agility { get; set; }
        int ExpEarned { get; set; }
        int CurrentLevel { get; set; }
        int NextLevelExp { get; set; }
        string Race { get; set; }
    }
}
