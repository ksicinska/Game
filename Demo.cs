using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class Demo
    {
        public void Demontration()
        {
            Introduction intro = new Introduction();
            intro.Rules();
            Console.ReadKey();
            Console.Clear();
            intro.Intro();
            Console.ReadKey();
            Menu decyzjanabagnie = new Menu(new string[] {"Jesteś silnym ogrem więc dasz sobie radę z setką baśniowych stworów: walka",
                "Decydujesz, że porozmawiasz z Lordem Farquadem" });

            Shop decbag = new Shop(decyzjanabagnie);
            decbag.IDK();
            //Console.Clear();
            intro.WayToDuloc();
            Console.ReadKey();
            Console.WriteLine("");
            Menu WalkaWDuloc = new Menu(new string[] { "Walcz", "Uciekaj" });
            Shop WalkaWD = new Shop(WalkaWDuloc);
            WalkaWD.IDK();

            
           
            Console.ReadKey();
            intro.Bridge();

            
            
         
            Console.ReadKey();

            Bridge bridge_ = new Bridge();
            BridgeThink bridge = new BridgeThink(bridge_);
            bridge.Symulation();


            intro.Bridge();
            Console.ReadKey();

            Menu menu = new Menu(new string[] { "Zbroja", "Gaśnica", "Szczur do pieczenia" });


            Shop shop = new Shop(menu);


            shop.IDK();
           

        }
    }
}
