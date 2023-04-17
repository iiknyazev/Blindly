using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public class Border : Cell
    {
        public override Cell Reaction(PlayerManager player)
        { 
            player.NewPosition(player.PrevPos.x, player.PrevPos.y);
            return this;
        }

        public override void Print(char cellType = ' ', ConsoleColor color = ConsoleColor.White)
        {
            base.Print('#', ConsoleColor.Red);
        }

        public override string ToString()
        {
            return "#";
        }
    }
}
