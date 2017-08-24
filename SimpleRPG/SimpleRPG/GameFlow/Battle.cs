using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    public class Battle : SpecBox
    {
        public void Fight()
        {
            var attack = new Attack();
            var run = new Run();
            var potion = new Potion();
            var dungeonFlow = new DungeonFlow();
            
            Console.Clear();
            string battleMSG = "BATTLE IN PROGRESS";
            Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (battleMSG.Length / 2)) + "}", battleMSG));
            Console.Write($"\n\nHP: {HealthCurrent}/{HealthFull} \nPotions Remaining: {PotionCount}");
            Console.Write($"\n\nEnter(R) to attempt to Run: \nEnter(P) to Use a Potion: \nOr Press Enter to Attack the {MName}: ");
            string battlechoice = Console.ReadLine().ToUpper();

            if (battlechoice == "")
                attack.AttackMonster();
            
            else if (battlechoice == "R")
                run.RunAway();

            else if (battlechoice == "P")
                potion.UsePotion();

            else
            {
                Console.WriteLine("That is NOT a valid choice!");
                Console.ReadLine();
                Fight();
            }
        }
    }
}
