using System;
using System.Threading;

namespace Ziel_15_CLI__C__
{
    class Program
    {
        public int ID; // Instance variable
        private static PlayerManager playerManager = new PlayerManager(); // Assuming you have a PlayerManager class

        static void Main()
        {
            Program programInstance = new Program(); // Create an instance of Program

            while (true)
            {
                Console.WriteLine("<---------- WELCOME TO ZIEL 15 BETA ---------->");
                Console.WriteLine("<                                             >");
                Console.WriteLine("< The Game is Written in C# and .NET and will >");
                Console.WriteLine("< be fully open source according to the Close >");
                Console.WriteLine("< License-OpenSource License as a Github repo >");
                Console.WriteLine("<                                             >");
                Console.WriteLine("< (C) 2025 realdcre, ugm-jacobco and Partners >");
                Console.WriteLine("<                                             >");
                Console.WriteLine("<--------------------------------------------->");
                Console.WriteLine("");
                Console.WriteLine("Commands used for interacting with this CLI");
                Console.WriteLine("> start");
                Console.WriteLine("> exit");
                Console.WriteLine("> setup player add <name>");
                Console.WriteLine("> setup player remove <name>");
                Console.WriteLine("> setup turns <amount>");
                Console.WriteLine("> setup skips <amount>");
                Console.WriteLine("> credits");

                string input = Console.ReadLine();

                if (input == "start")
                {
                    // Start the game logic here
                    Console.WriteLine("Game started!");
                }
                else if (input == "exit")
                {
                    Environment.Exit(0);
                }
                else if (input.Contains("setup player add"))
                {
                    string name = GetNameFromCommand(input);
                    Console.WriteLine($"Player added: {name}");
                    programInstance.addPlayer(name); // Call the instance method
                }
                else if (input.Contains("setup player remove"))
                {
                    string name = GetNameFromCommand(input);
                    Console.WriteLine($"Player removed: {name}");
                }
                else if (input.Contains("setup turns"))
                {
                    int number = GetNumberFromCommand(input);
                    Console.WriteLine($"Turns set to: {number}");
                }
                else if (input.Contains("setup skips"))
                {
                    int number = GetNumberFromCommand(input);
                    Console.WriteLine($"Skips set to: {number}");
                }
                else if (input == "credits")
                {
                    Console.Clear();
                    Console.WriteLine("<------------------------------------------------->");
                    Console.WriteLine("<          ZIEL 15 (C#/.NET CLI) Edition          >");
                    Console.WriteLine("< (C) 2025 dcre                                   >");
                    Console.WriteLine("< Written in C# .NET by Microsoft                 >");
                    Console.WriteLine("< BETA VERSION: THIS APP IS NOT FINISHED YET!!!!  >");
                    Console.WriteLine("<------------------------------------------------->");
                    Thread.Sleep(3000);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("Unknown command. Please try again.");
                }
            }
        }

        void addPlayer(string name)
        {
            player newPlayer = new player(ID, name); // Use the instance variable ID
            ID++;
            playerManager.AddPlayer(newPlayer); // Assuming you have a method to add players
        }

        static string GetNameFromCommand(string command)
        {
            int lastSpaceIndex = command.LastIndexOf(' ');
            if (lastSpaceIndex != -1 && lastSpaceIndex < command.Length)
            {
                return command.Substring(lastSpaceIndex + 1);
            }
            return String.Empty;
        }

        static int GetNumberFromCommand(string command)
        {
            int lastSpaceIndex = command.LastIndexOf(' ');
            if (lastSpaceIndex != -1 && lastSpaceIndex < command.Length - 1)
            {
                string numberString = command.Substring(lastSpaceIndex + 1);
                if (int.TryParse(numberString, out int number))
                {
                    return number;
                }
            }
            return 0; // Default value if parsing fails
        }

        public class player
        {
            public int ID;
            public string name;

            public player(int ID, string name)
            {
                this.ID = ID;
                this.name = name;
            }
        }

        public class PlayerManager
        {
            private List<player> players = new List<player>();

            public void AddPlayer(player newPlayer)
            {
                players.Add(newPlayer);
            }

            // Additional methods for managing players can be added here
        }

        public class game
        {
            private int turns;
            private int skips;
            private int playerAmount;

            public game(int turns, int skips, int playerAmount)
            {
                this.turns = turns;
                this.skips = skips;
                this.playerAmount = playerAmount;
            }
        }
    }
}