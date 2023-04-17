using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class End : Cell
    {
        public override Cell Reaction(PlayerManager player)
        {
            player.Win();
            return this;
        }
        public override void Print(char cellType = ' ', ConsoleColor color = ConsoleColor.White)
        {
            base.Print('$', ConsoleColor.Cyan);
        }

        public override string ToString()
        {
            return "$";
        }
    }
}
