using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class BridgeThink: IThink
    {
        private Bridge bridge;

        public BridgeThink(Bridge _bridge)
        {
            bridge = _bridge;
        }

        public void Symulation()
        {
            bridge.CrossTheBridge();
        }
      
        

    }
}
