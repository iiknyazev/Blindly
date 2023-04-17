using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Health : Cell
    {
        public override Cell Reaction(PlayerManager player)
        {
            player.SetHealth(player.Health + 1);
            return new Cell();
        }
        public override void Print(char cellType = ' ', ConsoleColor color = ConsoleColor.White)
        {
            base.Print('+', ConsoleColor.Green);
        }
        public override string ToString()
        {
            return "+";
        }
    }
}
