using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class DragonFight: IFight
    {
        private Dragon dragon;

        public DragonFight(Dragon dragon_)
        {
            dragon = dragon_;
        }
        public void Fight()
        {

            dragon.FightWithDragon();
        }
       
        
    }

}
