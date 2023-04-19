using System;
using System.Collections.Generic;
using System.Text;

namespace ParaShrekGame
{
    class Knight
    {

        Excit excit = new Excit();
        public void FightWithKnights()
        {
            Console.WriteLine("Rozpoczynasz walkę z Rycerzami ");

            Console.WriteLine();
            Introduction intr = new Introduction();
            intr.Riddle();
            string answer = Console.ReadLine();
            int ans = Convert.ToInt32(answer);

            if (ans == 55)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Gratulacje! Udało ci się rozwiązać zagadkę!"  );
                Console.ForegroundColor = ConsoleColor.White;
                Hospital hospital = new Hospital(200);



            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Zła odpowiedź! Spróbuj jeszcze raz.");
                Console.ForegroundColor = ConsoleColor.White;
                string answer1 = Console.ReadLine();
                int ans1 = Convert.ToInt32(answer1);

                    if (ans1 == 55)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Gratulacje! Udało ci się rozwiązać zagadkę!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Hospital hospital = new Hospital(150);

                }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Zła odpowiedź... Rycerze zabijają Shreka..");
                        Console.ReadKey();
                        excit.Ex();



                }
                return;

            }



            
           


            

        }
    }
}
