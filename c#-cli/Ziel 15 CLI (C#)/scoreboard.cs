using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziel_15_CLI__C__
{
    internal class scoreboard
    {
        private int[] scores;

        public scoreboard(int size)
        {
            scores = new int[size];
        }
        public void setScore(int ID, int score)
        {
            if (ID >= 0 && ID < scores.Length)
            {
                scores[ID] = score;
            } else
            {
                Environment.Exit(9);
            }
        }
        public int getScore(int ID)
        {
            if (ID >= 0 && ID < scores.Length)
            {
                return scores[ID];
            } else
            {
                
                Environment.Exit(9);
                return 0;

            }

        }

    }
}
