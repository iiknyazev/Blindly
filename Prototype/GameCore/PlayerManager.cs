using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Position(Position pos)
        {
            x = pos.x;
            y = pos.y;
        }
    }
    public class PlayerManager
    {
        public static Position StartPos { get; private set; }
        public Position Pos { get; private set; }
        public Position PrevPos { get; private set; }
        public int Health { get; private set; }

        public bool IsWin { get; private set; } = false;
        public PlayerManager(int x, int y, int health = 1, bool isWin = false)
        {
            Pos = new Position(x, y);
            PrevPos = new Position(x, y);
            Health = health;
            IsWin = isWin;
        }

        public void NewPosition(int x, int y)
        {
            PrevPos = new Position(Pos.x, Pos.y);
            Pos = new Position(x, y);
        }

        public void SetHealth(int v)
        {
            Health = v != 0 ? v : 1;
        }

        public void Win()
        {
            IsWin = true;
        }

        public static void SetStartPosition(Position startPos)
        {
            StartPos = new Position(startPos);
        }
    }
}