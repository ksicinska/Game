using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaShrekGame
{
    class Do //Saving File
    {

        string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

        public static void AppendAllLines(string path, IEnumerable<string> contents)
        {
            contents.ToList();
        }
    }
}
