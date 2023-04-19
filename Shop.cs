using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaShrekGame
{
    class Shop : IDoingSth
    {
        protected Menu menu;
        int origRow, origCol ;
        Excit excit = new Excit();

        public Shop()
        {
            menu = new Menu(new string[] { "Zbroja", "10 punktów zdrowia", "Szczur do pieczenia", "Gaśnica" });
        }

        public Shop(Menu menu_)
        {
            menu = menu_;
        }

        
        public virtual void IDK() 
        {

            //var menu = new Menu(new string[] { "Zbroja", "10 punktów zdrowia", "Szczur do pieczenia", "Gaśnica" });

            
            bool done = false;

            do
            {
                Console.Clear();
                origRow = Console.CursorTop;
                origCol = Console.CursorLeft;
                menu.Paint(origRow+10, origCol+1);
            
                var keyInfo = Console.ReadKey();

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow: menu.MoveUp(); break;
                    case ConsoleKey.DownArrow: menu.MoveDown(); break;
                    case ConsoleKey.Enter: done = true; break;
                }
            }
            while (!done);


            Console.ForegroundColor = ConsoleColor.Gray;

            Console.WriteLine("Twoja decyzja: " + (menu.SelectedOption));

            int value = menu.SelectedIndex;

            value.Equals(value);
            if (menu.SelectedOption == "")
            {
                Console.WriteLine("Nic nie zostało wybrane. Koniec gry");
                Console.ReadKey();
                
                excit.Ex();

            }
            else if (menu.SelectedOption == "Jesteś silnym ogrem więc dasz sobie radę z setką baśniowych stworów: walka")
            {
                Swamp swamp = new Swamp();
                SwampFight swampFight = new SwampFight(swamp);
                swampFight.Fight();         
            }
            else if (menu.SelectedOption == "Decydujesz, że porozmawiasz z Lordem Farquadem")
            {
                return;

            }
            else if (menu.SelectedOption == "Uciekaj")
            {
                Console.WriteLine("Przeciwników było zbyt wielu... Wracasz na Bagno");
                Console.WriteLine( "Koniec gry.");
                Console.ReadKey();
                
                excit.Ex();

            }
            else if (menu.SelectedOption == "Walcz")
            {
                Knight knight = new Knight();
                KnightFighgt knightFighgt = new KnightFighgt(knight);
                knightFighgt.Fight();
                return;
            }
            else if (menu.SelectedOption == "Zbroja")
            {
                Console.WriteLine("Gratulacje! Udało Ci się pokonać smoka i wydostać Księżniczkę! Odzyskujesz swoje Bagno.");
            }
            else if (menu.SelectedOption == "Gaśnica")
            {
                Console.WriteLine("Niestety Gaśnica nie dała rady ugasić ognia z pyska smoka. Gra skończona.");
            }
            else if (menu.SelectedOption == "Szczur do pieczenia")
            {
                Console.WriteLine("Niestety zostajsz spalony przez smoka. Gra skończona.");
            }
            else
            {
                Console.WriteLine("NIe dokonano wyboru- koniec gry");
                Console.ReadKey();
                excit.Ex();
            }



            Console.WriteLine("");
           

        }
        
        public void GetInfo()
        {
            Console.WriteLine();
            Console.WriteLine("wybierz produkt z listy");
            int value = Console.Read();
            int Value = value - 1;

            
        }
    } }


