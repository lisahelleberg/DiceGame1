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
            //Die die1 = new Die();
            //die1.RollDie();
            //Console.WriteLine("The value of the dice is {0}", die1.GetValue());

            //die1.RollDie();
            //Console.WriteLine("The value of the dice is {0}", die1.GetValue());

            DiceCup diceCup = new DiceCup();
            diceCup.RollAllDiceInCup();
            Console.WriteLine("Value of dicecup is {0}", diceCup.GetTotalValue());

            int value1 = 10;
            bool resultat = diceCup.IsTotalValueLargerThan(value1);
            Console.WriteLine("Is the total value of the dice larger than {0} the result is: {1}", value1, resultat);

            // The LAST line of code should be ABOVE this line
        }
    }
}
