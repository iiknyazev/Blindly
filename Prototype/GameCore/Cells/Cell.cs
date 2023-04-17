using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Cell
    {
        public Cell() { }

        public virtual Cell Reaction(PlayerManager player) 
        {
            return this;
        }

        public virtual void Print(char cellType = '.', ConsoleColor color = ConsoleColor.White) 
        {
            Console.ForegroundColor = color;
            Console.Write(cellType);
            Console.ResetColor();
        }

        public override string ToString()
        {
            return ".";
        }
    }
}
