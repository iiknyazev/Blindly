using GameCore;

namespace GameCore
{
    public class Programm
    {
        static string mapTest = @"
...#@$+~0
@####..$~
";
        static string mapTest1 = @"
....@....
.........
.........
.........
";

        static string mapTest2 = @"
.#..++............0...
~###..#.0.............
.#.0@.#....0..........
...####$..............
!
2 3 1 8 
2 11 0 18
";

        static string mapTest3 = @"
...@#..$..#
..++..0....
";

        static public void EndGame(CoreManager coreManager, string map)
        {
            Console.WriteLine("\nWin!");
            StreamWriter sr = new StreamWriter(@"Level1_out.txt", false);
            sr.WriteLine(coreManager._GameState);
            if (map.Contains('!'))
            {
                var portalLinks = map.Substring(map.IndexOf('!'));
                sr.Write(portalLinks);
            }
            sr.Close();
        }

        static public CoreManager Step(CoreManager coreManager)
        {
            Console.WriteLine("\nВведите направление хода (w, a, s, d) или q (выход): ");
            var move = Console.ReadLine();
            switch (move)
            {
                case "w":
                    return coreManager.Move(DivMove.up);
                case "a":
                    return coreManager.Move(DivMove.left);
                case "s":
                    return coreManager.Move(DivMove.down);
                case "d":
                    return coreManager.Move(DivMove.right);
                case "q":
                    return null;
                default:
                    throw new ArgumentException();
            }
        }

        static public void Main()
        {
            var map = new StreamReader(@"Level1_in.txt").ReadToEnd();
            CoreManager coreManager = new CoreManager(map);
            while(true)
            {
                Console.Clear();
                Print.PrintGameState(
                    coreManager._LogicManager.Map, 
                    coreManager._LogicManager.CellBuffer, 
                    coreManager._LogicManager.Player.Health
                    );

                if (coreManager._LogicManager.Player.IsWin)
                {
                    EndGame(coreManager, map);
                    break;
                }

                coreManager = Step(coreManager);
                if (coreManager == null)
                    break;
            }
        }
    }
}