using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleRPG
{
    class Game
    {
        string choice;
        int random;

        public void Play()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Simple RPG");
            Console.WriteLine("\nChoose Your Dungeon:");
            Console.Write("\n(1) Easy \n(2) Medium \n(3) Hard \n(4) Random \nEnter Your Choice: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Easy Easy = new Easy();
                Easy.Play();
            }
            else if (choice == "2")
            {
                Medium Medium = new Medium();
                Medium.Play();
            }
            else if (choice == "3")
            {
                Hard Hard = new Hard();
                Hard.Play();
            }
            else if (choice == "4")
            {
                Random RNG = new Random();
                random = RNG.Next(0, 4);
                if (random == 1)
                {
                    Easy Easy = new Easy();
                    Easy.Play();
                }
                else if (random == 2)
                {
                    Medium Medium = new Medium();
                    Medium.Play();
                }
                else
                {
                    Hard Hard = new Hard();
                    Hard.Play();
                }
            }
            else
            {
                Play();
            }

        }
    }
}
