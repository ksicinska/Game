using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaShrekGame
{

   
    class Hospital: IDoingSth
    {
        Excit excit = new Excit();
        protected int health_value;

        protected int add_value;
        

        public Hospital()
        {
            int health_value = 100;
            
        }
        public Hospital(int Health_value)
        {
            
            Random rnd = new Random();
            int value = rnd.Next(60, 100);
            health_value = Health_value - value;
            Console.WriteLine("Twój stan zdowia po walce: " + health_value);

            if (health_value<90)
            {
                Console.WriteLine("Przegrałeś walke. Koniec gry.");
                Console.ReadKey();
                excit.Ex();


            }
            
           

           
            


        }

        public void GetInfo()
        {
            

        }
    }
}
