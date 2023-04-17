using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Hole : Cell
    {
        public override Cell Reaction(PlayerManager player)
        {
            player.SetHealth(player.Health - 1);
            player.NewPosition(PlayerManager.StartPos.x, PlayerManager.StartPos.y);
            return this;
        }
        public override void Print(char cellType = ' ', ConsoleColor color = ConsoleColor.White)
        {
            base.Print('~', ConsoleColor.Blue);
        }

        public override string ToString()
        {
            return "~";
        }
    }
}
