using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class RollDice
    {
        //Random variable 
        private static Random r = new Random();

        //Method returns nothing. Takes in integer named roll
        public int[] Rolls(int roll)
        {
            //Create array of integers named combos that is 11 "segments long"
            int[] combos = new int[11];

            //For every numnber in between 1 and the integer passed
            for (int i = 0; i < roll ; i++ ) 
            {
                //Initiate two dice
                int dice1 = 0;
                int dice2 = 0;

                //Choose a random number between 1-6 for each die
                dice1 = r.Next(1,7);
                dice2 = r.Next(1, 7);

                //Adds sum of dice
                int dicesum = dice2 + dice1;

                //Stores counts of dice sum 
                combos[(dicesum - 2)]++;
            }
            return combos;
        }
    }
}
