using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameLib
{
    public class Game
    {
        public int Dice1 { get; private set; }
        public int Dice2 { get; private set; }
        
        public bool YouAreAWinner { get; private set; }

        public int ThrowDice(int dice1, int dice2)

        {
            Dice1 = dice1;
            Dice2 = dice2;
           
            var res= Dice1 + Dice2 ;
            if (res == 7)
            {

                YouAreAWinner = true;
            }
            else throw new Exception("You will try gain");
            return res;


        }




    }
}
