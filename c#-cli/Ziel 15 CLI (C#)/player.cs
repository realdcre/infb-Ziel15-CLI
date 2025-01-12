using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ziel_15_CLI__C__
{
    public class player
    {
        public string name { get; }
        public int denyAmount { get; set; }
        public int ID { get;  }
        
        public int deny(int skips)
        {
            denyAmount++;
            int left = skips - denyAmount;
            return left;

        }
    }
}
