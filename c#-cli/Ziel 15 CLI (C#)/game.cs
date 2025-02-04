﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;


namespace Ziel_15_CLI__C__
{
    internal class game
    {
        public int turns { get; set; }
        public int skips {  get; set; }
        public int playerAmount { get; set; }
        public int turnsDone;
        public bool gameOver;
        public string victor;
        void init()
        {
            turnsDone = 0;
            gameOver = false;
            victor = String.Empty;
            Console.Clear();
        }

        public int dice()
        {
            Random rnd = new Random();
            int rand = rnd.Next();
            return rand;
        }

        int manageTurn(int previousID)
        {
            if (previousID < playerAmount)
            {
                previousID++;
                return previousID;
            } else if (previousID == playerAmount) {
                return 1;
            }
            return previousID++;
        }

        public static string GetPlayerName(int id)
        {

            player player = playerManager.GetPlayers().Find(p => p.ID == id);
            if (player != null)
            {
                return (player.name);
            } else {
                return (string.Empty);
            }
        }
        
        public static int getPlayerSkips(int id)
        {
            player player = playerManager.GetPlayers().Find(player => player.ID == id);
            if (player != null)
            {
                return player.denyAmount;
            }
            return 0;
        }
            
            
           
        int getCurrentScore(int ID)
        {
            return scoreboard.getScore(ID);
        }

        void playTurn(int playerID)
        {
            int result;
            string playerName = "Player";
            Console.WriteLine($"It is {playerName}'s turn!");
            Console.WriteLine("Press Enter to roll the dice");
            string input = Console.ReadLine();
            if (input == String.Empty)
            {
                Console.Clear();
                result = dice();
            }
            else
            {

                result = dice();
                Console.Clear();
            }

            Console.WriteLine($"The dice has landed on {result}!");
            Console.WriteLine("Press K to keep or N to skip!");
            input = Console.ReadLine();
            int score;
            int remainingTurns = turns - turnsDone;
            int remainingSkips = skips - getPlayerSkips(playerID);
            if (input == "K" || input == "k")
            {
                score = getCurrentScore(playerID);
                score = score + result;

                Console.WriteLine($"Accepted the Result, your total score is {score} now, there are {remainingTurns} Turns and {remainingSkips} Skips left.");
            }
            else if (input == "N" || input == "n")
            {
                if (remainingSkips <= 0)
                {
                    score = getCurrentScore(playerID);
                    score = score + result;
                    Console.WriteLine($"Uh Oh! You cant skip anymore! Your total score is {score} and there are {remainingTurns}TUrns remaining!");
                }
                else
                {
                    player.deny(playerID);
                    Console.WriteLine($"Yep, skipped! You have {remainingSkips - 1} Skips and {remainingTurns} remaining!");

                }

            }
        }
        


        public game()
        {
            

            Console.WriteLine(" You will be presented a random number in each round ");
            Console.WriteLine(" The choice is yours! Will you keep the number and   ");
            Console.WriteLine(" add it to your stack that has to be as close to 15  ");
            Console.WriteLine(" or skip your turn! Be careful though, you can only  ");
            Console.WriteLine(" skip a certain number of times in the game. The one ");
            Console.WriteLine(" player closest to 15 at the end of the turns WINS!! ");
            Thread.Sleep(4000);
            Console.Clear();
            init();
            scoreboard scoreboard = new scoreboard(playerAmount); 

        }

    }
}
