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
        public int position { get; set; }
        public int denyAmount { get; set; }
        
        public void deny()
        {
            denyAmount++;
        }
    }
}
