using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Player : Cell
    {
        public override void Print(char cellType = ' ', ConsoleColor color = ConsoleColor.White)
        {
            base.Print('@', ConsoleColor.Yellow);
        }

        public override string ToString()
        {
            return "@";
        }
    }
}
