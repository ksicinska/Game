using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class SwampFight: IFight
    {
        Swamp swamp;

        public SwampFight(Swamp swamp_)
        {
            swamp = swamp_;
        }


        public void Fight()
        {
            swamp.FightWithCreatures();
        }
        
    }
}
