using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParaShrekGame
{

   
    public class Menu
    {
        public int origCol, origRow;
        public Menu(IEnumerable<string> items)
        {
            Items = items.ToArray();
        }


        public IReadOnlyList<string> Items { get; set; }

        public int SelectedIndex { get; private set; } = -1; // nothing selected

        public string SelectedOption => SelectedIndex != -1 ? Items[SelectedIndex] : null;


        public void MoveUp() => SelectedIndex = Math.Max(SelectedIndex - 1, 0);

        public void MoveDown() => SelectedIndex = Math.Min(SelectedIndex + 1, Items.Count - 1);

      
        
       
        public void Paint(int x, int y)
        {
           
            for (int i = 0; i < Items.Count; i++)
            {
                

                

                Console.SetCursorPosition(x, y + i);

                var color = SelectedIndex == i ? ConsoleColor.Red : ConsoleColor.Blue;

                Console.ForegroundColor = color;
                Console.WriteLine(Items[i]);

            }
        }




    }


    


}
