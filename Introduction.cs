using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ParaShrekGame
{
    class Introduction
    {
        public void Intro()
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\CP\Desktop\ParaShrekGame\ParaShrekGame\TextFile1.txt"));
        }
        public void Rules()
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\CP\Desktop\ParaShrekGame\ParaShrekGame\Rules.txt"));

        }
        public void WayToDuloc()
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\CP\Desktop\ParaShrekGame\ParaShrekGame\WayToDuloc.txt"));
        }

        public void Riddle()
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\CP\Desktop\ParaShrekGame\ParaShrekGame\TextFile2.txt"));

        }

        public void Bridge()
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\CP\Desktop\ParaShrekGame\ParaShrekGame\DrogaDoZamku.txt"));

        }

        public void Dragon()
        {
            Console.WriteLine(File.ReadAllText(@"C:\Users\CP\Desktop\ParaShrekGame\ParaShrekGame\TextFile3.txt"));
        }
    }
}

           