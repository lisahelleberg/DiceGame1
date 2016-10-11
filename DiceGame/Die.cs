﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace DiceGame
{
    // This class is supposed to represent a classic 6-sided die.
    class Die
    {
        private int value;
        private Random generator;

        public Die()
        {
            // The generator is used for generating random numbers
            generator = new Random();
            Thread.Sleep(10); // This is needed for magical purposes...
            //RollDie();  // This puts the die in a well-defined state
        }

        // Roll the die: the value will be set to a random number
        // between 1 and 6 (both included).
        public void RollDie()
        {
            value = generator.Next(6) + 1; // Add 1 as the generator uses numbers between 0 and 5
        }

        public int GetValue()
        {
            return value; // Value from the die
        }
    }
}
