using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class MonsterManager : SpecBox
    {
        public void SetPower()
        {
            var rng = new Random();

            if (DungeonDifficulty == 1)
            {
                Attack1 = rng.Next(43, 54);
                Attack2 = rng.Next(44, 76);
                Attack3 = rng.Next(36, 75);
            }
            else if (DungeonDifficulty == 2)
            {
                Attack1 = rng.Next(45, 62);
                Attack2 = rng.Next(50, 68);
                Attack3 = rng.Next(41, 82);
            }
            else if (DungeonDifficulty == 3)
            {
                Attack1 = rng.Next(50, 70);
                Attack2 = rng.Next(55, 85);
                Attack3 = rng.Next(45, 90);
            }

            if (MName == "Goblin") { AttackDamage = Attack1 - Vitality; }
            if (MName == "Skeleton") { AttackDamage = Attack2 - Vitality; }
            if (MName == "Dragon") { AttackDamage = Attack3 - Vitality; }
            if (AttackDamage < 0) { AttackDamage = 0; }
            
        }
    }
}
