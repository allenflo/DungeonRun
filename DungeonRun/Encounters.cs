﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DungeonRun
{
    class Encounters
    {
        //Encounter Generic


        //Encounters
        public static void FirstEncounter()
        {
            Console.WriteLine("You throw open the door and grab a rusty metal sword, while chargine toward your captor");
            Console.WriteLine("He turns...");
            Console.ReadKey();  //wait for them to press a button


        }

        //Encounter Tools
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = "";
            int p = 0;
            int h = 0;
            if (random)
            {
            }
            else
            {
                n = name;
                p = power;
                h = health;
            }
            while (h > 0)
            {
                Console.WriteLine("=======================");
                Console.WriteLine("| (A)ttack (D)efend   |");
                Console.WriteLine("| (R)un    (H)eal     |");
                Console.WriteLine("=======================");
                Console.WriteLine(" Potions: "+Program.currentPlayer.potions+"  Health: "+Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    // Attack
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    // Defend              
                }

                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                }

                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                { 
                }
            }

        }
    }

}
