using System;
using System.Collections.Generic;
using System.Text;

namespace probability
{
    class Roller
    {
        private Dice dice;

        public Roller()
        {
            //instantiate dice
            this.dice = new Dice();
            //objects created here
        }

        public bool DidGet6InNumberOfRolls(int numberofRolls) //set number of times dice rolls in one experiment
        {
            for (int i = 0; i < numberofRolls; i++)
            {
                int resultOfRoll = dice.Roll();
                if (resultOfRoll == 6)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
