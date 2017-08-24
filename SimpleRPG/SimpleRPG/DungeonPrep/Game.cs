using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    static class Game
    {
        public static void Play()
        {
            var dungeonSetup = new DungeonSetup();

            Console.Clear();
            Console.WriteLine("Welcome to Simple RPG");
            Console.WriteLine("\nChoose Your Dungeon:");
            Console.Write("\n(1) Easy \n(2) Medium \n(3) Hard \n(4) Random Difficulty \nEnter Your Choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                dungeonSetup.Play(1);
            }
            else if (choice == "2")
            {
                dungeonSetup.Play(2);
            }
            else if (choice == "3")
            {
                dungeonSetup.Play(3);
            }
            else if (choice == "4")
            {
                var rng = new Random();
                int random = rng.Next(1, 4);
                dungeonSetup.Play(random);
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
