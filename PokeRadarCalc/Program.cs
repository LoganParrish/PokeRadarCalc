using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PokeRadarCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            

            
            bool keepGoing = true;

            while (keepGoing)
            {
                Console.WriteLine("Welcome to the PokeRadar Percentage Calculator!\n\nEnter the name of the Pokemon you wish to start chaining!");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("=============================================================\n\n\n");
                Console.ResetColor();
                string userPokemon = Console.ReadLine().ToLower();
                Console.Clear();

                if (userPokemon == "espurr")
                {
                    Espurr();
                }
                else
                {
                    Console.WriteLine("Sorry, our program does not recognize that Pokemon. \nPlease check your spelling and try again.");
                    Console.WriteLine("\n\n\nPress any key to restart...");
                    Console.ReadKey();
                    Console.Clear();
                    keepGoing = true;
                }
            }
        }
        static void Espurr()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Espurr");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 6: 20% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void KeepTrack()
        {
            decimal shinyChance = 0;
            int encounter = 0;
            bool reset = true;

            while(reset)
            {
                Console.Clear();
                Console.Write("Pokemon encountered: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(encounter);
                Console.ResetColor();
                Console.Write(" Chance for a shiny: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(shinyChance);
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n_____________________________________________________________________\n\n\n");
                Console.ResetColor();
                Console.WriteLine("Press 'enter' every time you encounter the Pokemon\n You may also type 'reset' if you break your chain.\n\n\n");
                
                string userInput = Console.ReadLine().ToLower();
                if (userInput == "")
                {
                    encounter++;
                    if (encounter > 40)
                    {
                        
                    }
                    else if (encounter > 1)
                    {
                        shinyChance = ((65536) / (8200 - ((Decimal)encounter * 200)) / 65536) * 100;
                    }
                    
                }
                else if (userInput == "reset")
                {
                    reset = true;
                    encounter = 0;
                    shinyChance = 0;
                }
            }
        }
    }
}
