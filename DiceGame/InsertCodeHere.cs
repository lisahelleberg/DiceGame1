using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            // New die
            Die die1 = new Die();
            die1.RollDie();
            Console.WriteLine("The value of the dice is {0}", die1.GetValue());

            Die die2 = new Die();
            die2.RollDie();
            Console.WriteLine("The value of the dice is {0}", die2.GetValue());

            Die die3 = new Die();
            die2.RollDie();
            Console.WriteLine("The value of the dice is {0}", die3.GetValue());


            // The LAST line of code should be ABOVE this line
        }
    }
}
