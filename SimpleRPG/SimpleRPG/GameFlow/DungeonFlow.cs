using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class DungeonFlow : SpecBox
    {
        public void Advance()
        {
            var endGame = new EndGame();
            var potion = new Potion();
            var levelManager = new LevelManager();
            var battleManager = new BattleManager();
            var battle = new Battle();

            levelManager.Exp();

            DungeonPosition++;
            
            if (DungeonPosition > DungeonLength - 1)
            {
                endGame.Success();
                return;
            }
                

            Console.Clear();
            Console.WriteLine($"Current Position in {DungeonName}: {DungeonPosition}");
            Console.WriteLine($"Health Remaining: {HealthCurrent}/{HealthFull} ");
            Console.WriteLine($"Potions Remaining: {PotionCount}");
            Console.Write("\nPress Enter to Advance One Position: ");
            string choice = Console.ReadLine().ToUpper();
            
            Console.WriteLine("\nYou Moved Up One Position.");
            Console.ReadLine();

            battleManager.RollChance();
            if (battleManager.EnemySelection())
                battle.Fight();
            
            else
            Advance();
        }
    }
}
