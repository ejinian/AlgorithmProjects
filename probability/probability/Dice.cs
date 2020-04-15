using System;
using System.Collections.Generic;
using System.Text;

namespace probability
{
    class Dice
    {
        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, 7);
        }
    }
}
