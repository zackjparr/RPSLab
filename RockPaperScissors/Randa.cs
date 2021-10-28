using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Randa : Player
    {
        public Randa()
        {

        }
        public override RPSEnum GetRPS()
        {
            Random r = new Random();
            int option = 0;
            option = r.Next(0, 3);

            RPSEnum pick;
            switch (option)
            {
                case 0:
                    pick = RPSEnum.Rock;
                    break;
                case 1:
                    pick = RPSEnum.Paper;
                    break;
                case 2:
                    pick = RPSEnum.Scissors;
                    break;
                default:
                    return GetRPS();     
            }
            return pick;
        }
    }
}
