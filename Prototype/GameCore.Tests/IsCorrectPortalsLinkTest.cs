using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCore.Tests
{
    internal class IsCorrectPortalsLinkTest
    {
        const string baseGameState = @"
.#..++............0...
~###..#.0.............
.#.0@.#....0..........
...####$..............
";

        public void Test(string links, string gameState, bool expected)
        {
            var coreManager = new CoreManager();
            var actual = coreManager.IsCorrectPortalLinks(links, gameState);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(@"
2 3 1 8 
2 11 > 18
", baseGameState, false)]
        [TestCase(@"
2 3 1 8 
2 1d 0 18
", baseGameState, false)]
        public void AllArgumentIsInt(string links, string gameState, bool expected)
        {
            Test(links, gameState, expected);
        }

        [TestCase(@"
2 3 1 8 
2 11 0 18 5 6
", baseGameState, false)]
        [TestCase(@"
2 3 1 8 12
2 11 0 18
", baseGameState, false)]
        public void OnlyFourLinkArgument(string links, string gameState, bool expected)
        {
            Test(links, gameState, expected);
        }

        [TestCase(@"
2 3 1 8
2 11 0 100
", baseGameState, false)]
        [TestCase(@"
2 43 1 8
2 11 0 18
", baseGameState, false)]
        [TestCase(@"
24 3 1 8
2 11 0 18
", baseGameState, false)]
        [TestCase(@"
-1 3 1 8
2 11 0 18
", baseGameState, false)]
        [TestCase(@"
1 3 1 8
2 -7 0 18
", baseGameState, false)]
        public void CoordinatesDoNotGoBeyondTheMap(string links, string gameState, bool expected)
        {
            Test(links, gameState, expected);
        }

        [TestCase(@"
2 3 1 8 
2 3 0 18
", baseGameState, false)]
        [TestCase(@"
2 3 1 8 
2 11 1 8
", baseGameState, false)]
        [TestCase(@"
2 3 0 18 
2 11 0 18
", baseGameState, false)]
        [TestCase(@"
2 3 1 8 
2 11 0 18
2 3 0 18
", baseGameState, false)]
        public void CoordinatesAreNotRepeated(string links, string gameState, bool expected)
        {
            Test(links, gameState, expected);
        }

        [TestCase(@"
2 3 1 9 
2 11 0 18
", baseGameState, false)]
        [TestCase(@"
2 3 1 8 
2 11 2 18
", baseGameState, false)]
        public void LinksToPortalsOnly(string links, string gameState, bool expected)
        {
            Test(links, gameState, expected);
        }
    }
}
