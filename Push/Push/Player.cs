using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Push
{
    public class Player
    {
        public string name { get; set; }
        public int moves { get; set; }

        public override string ToString()
        {
            return string.Format("{0} - {1} points", name, moves);
        }
    }
}
