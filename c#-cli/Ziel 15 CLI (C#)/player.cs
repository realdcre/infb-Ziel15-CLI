using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziel_15_CLI__C__
{
    internal class player
    {
        public string name { get; }
        public int pos { get; set; }
        public int denyAmount { get; set; }
        
        public int deny(int skips)
        {
            denyAmount++;
            int left = skips - denyAmount;
            return left;

        }

        public int position(int add)
        {
            pos = pos + add;
            return pos;
        }

    }
}
