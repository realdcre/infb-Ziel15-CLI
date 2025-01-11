using System;
using System.Collections.Generic;
using System.Linq;
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

        int dice()
        {
            Random rnd = new Random();
            int rand = rnd.Next();
            return rand;
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

        }

    }
}
