

using AdventOfCodeCollection._01._12._2024;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;

namespace AdventOfCodeCollectionTests._01._12._2024
{
    [TestFixture]
    internal class FirstPuzzleTests
    {
        [TestMethod]
        public void CalculateDistance()
        {
            // arrange
            const int expected = 11;
            var firstTest = new FirstPuzzle();

            // act
            var result = firstTest.Solve(TestInputString);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }

        private const string TestInputString =
            @"3   4
4   3
2   5
1   3
3   9
3   3";
    }
}
