using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Game
    {
        public void Play()
        {
            Dungeon Dungeon = new Dungeon();
            string choice;
            int random;

            Console.Clear();
            Console.WriteLine("Welcome to Simple RPG");
            Console.WriteLine("\nChoose Your Dungeon:");
            Console.Write("\n(1) Easy \n(2) Medium \n(3) Hard \n(4) Random Difficulty \nEnter Your Choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Dungeon.Play(1);
            }
            else if (choice == "2")
            {
                Dungeon.Play(2);
            }
            else if (choice == "3")
            {
                Dungeon.Play(3);
            }
            else if (choice == "4")
            {
                Random RNG = new Random();
                random = RNG.Next(0, 4);
                Dungeon.Play(random);
            }
            else
            {
                Console.Write("\nInvalid Choice!");
                Console.ReadLine();
                Play();
            }

        }
    }
}
