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
                else if (userPokemon == "bunnelby")
                {
                    Bunnelby();
                }
                else if (userPokemon == "scatterbug")
                {
                    Scatterbug();
                }
                else if (userPokemon == "zigzagoon")
                {
                    Zigzagoon();
                }
                else if (userPokemon == "honedge")
                {
                    Honedge();
                }
                else if (userPokemon == "pidgey")
                {
                    Pidgey();
                }
                else if (userPokemon == "weedle")
                {
                    Weedle();
                }
                else if (userPokemon == "caterpie")
                {
                    Caterpie();
                }
                else if (userPokemon == "pansear")
                {
                    Pansear();
                }
                else if (userPokemon == "pansage")
                {
                    Pansage();
                }
                else if (userPokemon == "panpour")
                {
                    Panpour();
                }
                else if (userPokemon == "pikachu")
                {
                    Pikachu();
                }
                else if (userPokemon == "metapod")
                {
                    Metapod();
                }
                else if (userPokemon == "kakuna")
                {
                    Kakuna();
                }
                else if (userPokemon == "bidoof")
                {
                    Bidoof();
                }
                else
                {
                    Console.WriteLine("Sorry, our program does not recognize that Pokemon, or you cannot find it in the grass. \nPlease check your spelling and try again.");
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
        static void Bunnelby()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bunnelby");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 2: 20% Chance to encounter.\nRoute 3: 20% Chance to encounter.\nRoute 5: 30% Chance to encounter.\nRoute 22: 20% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Scatterbug()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Scatterbug");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 2: 20% Chance to encounter.\nSantalune Forest: 20% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Zigzagoon()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Zigzagoon");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 2: 15% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Honedge()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Honedge");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 6: 15% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Pidgey()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pidgey");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 2: 14% Chance to encounter.\nRoute 3: 10% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Weedle()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Weedle");
            Console.ResetColor();
            Console.Write("\n\nRoute 2: 11% Chance to encounter. ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(Version X Only)");
            Console.ResetColor();
            Console.Write("\nSantalune Forest: 20% Chance to encounter ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(Version X)");
            Console.ResetColor();
            Console.Write("\nSantalune Forest: 10% Chance to encounter ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("(Version Y)\n\n");
            Console.ResetColor();
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Caterpie()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Caterpie");
            Console.ResetColor();
            Console.Write("\n\nRoute 2: 11% Chance to encounter. ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("(Version Y Only)");
            Console.ResetColor();
            Console.Write("\nSantalune Forest: 20% Chance to encounter ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("(Version Y)");
            Console.ResetColor();
            Console.Write("\nSantalune Forest: 10% Chance to encounter ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(Version X)\n\n");
            Console.ResetColor();
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Pansear()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pansear");
            Console.ResetColor();
            Console.WriteLine("\n\nSantalune Forest: 10% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Pansage()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pansage");
            Console.ResetColor();
            Console.WriteLine("\n\nSantalune Forest: 10% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Panpour()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Panpour");
            Console.ResetColor();
            Console.WriteLine("\n\nSantalune Forest: 10% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Pikachu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Pikachu");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 3: 5% Chance to encounter.\nSantalune Forest: 6% Chance to encounter.\n");
            Console.WriteLine("After selecting a route to farm, press any key to continue.");
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Kakuna()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Kakuna");
            Console.ResetColor();
            Console.Write("\n\nSantalune Forest: 4% Chance to encounter. ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("(Version X Only)");
            Console.ResetColor();
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Metapod()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Metapod");
            Console.ResetColor();
            Console.Write("\n\nSantalune Forest: 4% Chance to encounter. ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("(Version Y Only)");
            Console.ResetColor();
            Console.ReadKey();

            KeepTrack();

            Console.ReadKey();
        }
        static void Bidoof()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Bidoof");
            Console.ResetColor();
            Console.WriteLine("\n\nRoute 3: 20% Chance to encounter.\nRoute 22: 10% Chance to encounter.\n");
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
