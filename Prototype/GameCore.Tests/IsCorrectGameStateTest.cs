namespace GameCore.Tests
{
    [TestFixture]
    public class IsCorrectGameStateTest
    {
        public void Test(string map, bool expected)
        {
            var coreManager = new CoreManager();
            var actual = coreManager.IsCorrectGameState(map);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(@"
....@...@..
..@...@..@.
", false)]

        [TestCase(@"
@..........
..........@
", false)]
        [TestCase(@"
...........
...........
", false)]
        public void OnlyOnePlayer(string map, bool expected)
        {
            Test(map, expected);
        }

        [TestCase(@"
....@...#.
..$...#..
", false)]

        [TestCase(@"
..........
.
", false)]
        [TestCase(@"
@
.
", true)]
        public void RectangleMap(string map, bool expected)
        {
            Test(map, expected);
        }

        [TestCase(@"
.t..@...#
..$...#..
", false)]
        [TestCase(@"
.t..@...#
..$. .#..
", false)]
        [TestCase(@"
.t..@...#
3.$...#..
", false)]
        [TestCase(@"
.t..@...#
..$...#.!
", false)]
        public void OnlyCorrectSymbols(string map, bool expected)
        {
            Test(map, expected);
        }
    }
}