using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class KnightFighgt : IFight
    {

        Knight Knight;
        public KnightFighgt(Knight knight)
        {
            Knight = knight;
        }
        public void Fight()
        {
            Knight.FightWithKnights();


        }
    } 
}
