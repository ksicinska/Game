using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class Bridge
    {
        Excit excit = new Excit();
        string userinput1, userinput2, userinput3;        
        public void CrossTheBridge()
        {

            Console.Clear();
            Console.WriteLine("Zgadnij kod. Cyfry w kodzie są od 1-5.");

            //Random RND = new Random();
            //int value = RND.Next(1, 5);
            //int value2 = RND.Next(1, 5);
            int value = 3;
            int value2 = 2;
           

            Console.WriteLine("Podaj pierwszą cyfrę: ");

            userinput1 = Console.ReadLine();
            int val1 = Convert.ToInt32(userinput1);

            Console.WriteLine("Podaj drugą cyfrę: ");
            userinput2 = Console.ReadLine();
            int val2 = Convert.ToInt32(userinput2);

            

            if ((value == val1) & (value2 == val2))
            {
                Console.WriteLine( "Podałeś prawidłowy kod");
                return;
            }
            else
            {
                Console.WriteLine("Spróbuj jeszcze raz [4]");
                userinput1 = Console.ReadLine();
                int val11 = Convert.ToInt32(userinput1);

                Console.WriteLine("Podaj drugą cyfrę: ");
                userinput2 = Console.ReadLine();
                int val21 = Convert.ToInt32(userinput2);

                if ((value == val1) & (value2 == val21) )
                {
                    Console.WriteLine(" Podałeś prawidłowy kod");
                    return;
                }
                else
                {
                    Console.WriteLine("Spróbuj jeszcze raz [3]");
                    userinput1 = Console.ReadLine();
                    int val13 = Convert.ToInt32(userinput1);

                    Console.WriteLine("Podaj drugą cyfrę: ");
                    userinput2 = Console.ReadLine();
                    int val23 = Convert.ToInt32(userinput2);

                    
                    if ((value == val13) & (value2 == val23) )
                    {
                        Console.WriteLine(" Podałeś prawidłowy kod");
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Spróbuj jeszcze raz[2]");
                        userinput1 = Console.ReadLine();
                        int val14 = Convert.ToInt32(userinput1);

                        Console.WriteLine("Podaj drugą cyfrę: ");
                        userinput2 = Console.ReadLine();
                        int val24 = Convert.ToInt32(userinput2);

                        

                        if ((value == val14) & (value2 == val24))
                        {
                            Console.WriteLine(" Podałeś prawidłowy kod");
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Spróbuj jeszcze raz[1]");
                            userinput1 = Console.ReadLine();
                            int val15 = Convert.ToInt32(userinput1);

                            Console.WriteLine("Podaj drugą cyfrę: ");
                            userinput2 = Console.ReadLine();
                            int val25 = Convert.ToInt32(userinput2);

                           

                            if ((value == val15) & (value2 == val25) )
                            {
                                Console.WriteLine(" Podałeś prawidłowy kod");
                                return;
                            }
                            else
                            {
                                Console.WriteLine("Wykorzystano maksymalną ilość prób");
                                Console.WriteLine("Gra skończona");

                                Console.ReadKey();
                                excit.Ex();

                            }

                                
                        }
                    }


                }
            }


        }
    }
}
