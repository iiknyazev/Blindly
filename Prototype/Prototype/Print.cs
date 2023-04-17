using GameCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore
{
    public static class Print
    {
        static public void PrintGameState(Cell[,] map, Cell cellBuffer, int health)
        {
            PrintBuffer(map, cellBuffer);
            PrintHealth(map, health);
            PrintMapCell(map);
        }

        static public void PrintBorderLine(Cell[,] map)
        {
            for (int i = 0; i < map.GetLength(1) + 2; i++)
                Console.Write(
                    i != 0 && i != map.GetLength(1) + 1
                    ? "-"
                    : "+"
                    );
            Console.WriteLine();
        }

        static public void PrintBuffer(Cell[,] map, Cell cellBuffer)
        {
            PrintBorderLine(map);
            Console.Write("|Buffer: "); cellBuffer.Print();
            for (int i = 10; i < map.GetLength(1) + 1; i++)
                Console.Write(" ");
            Console.WriteLine("|");
        }

        static public void PrintHealth(Cell[,] map, int health)
        {
            PrintBorderLine(map);
            Console.Write("|Health: " + health.ToString());
            for (int i = 10; i < map.GetLength(1) + 1; i++)
                Console.Write(" ");
            Console.WriteLine("|");

        }

        static public void PrintMapCell(Cell[,] map)
        {
            PrintBorderLine(map);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                Console.Write("|");
                for (int j = 0; j < map.GetLength(1); j++)
                    map[i, j].Print();
                Console.WriteLine("|");
            }
            PrintBorderLine(map);
        }

        static public void PrintMapChar(char[,] map)
        {
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                    Console.Write(map[i, j]);
                Console.WriteLine();
            }
        }
    }
}
