using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Ziel_15_CLI__C__
{
    internal class playerManager
    {
        private static List<player> players = new List<player>();

        public static void AddPlayer(player player)
        {
            players.Add(player);

        }

        public static void removePlayer(int ID)
        {
            player playerToRemove = players.Find(p => p.ID == ID);
            if (playerToRemove != null)
            {
                players.Remove(playerToRemove);
            }
        }

        public static List<player> GetPlayers()
        {

            return new List<player>(players); // Return a copy of the list

        }
    }
}
