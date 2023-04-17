using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Portal : Cell
    {
        public Position TeleportTo { get; private set; }
        public Portal(int xTo = 0, int yTo = 0) : base() 
        {
            TeleportTo = new Position(xTo, yTo);
        }

        public override Cell Reaction(PlayerManager player)
        {
            player.NewPosition(TeleportTo.x, TeleportTo.y);
            return this;
        }

        public override void Print(char cellType = '.', ConsoleColor color = ConsoleColor.White)
        {
            base.Print('0', ConsoleColor.Magenta);
        }

        public override string ToString()
        {
            return "0";
        }
    }
}
