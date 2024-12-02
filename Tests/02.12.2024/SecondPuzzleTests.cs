using AdventOfCodeCollection._02._12._2024;
using Tests._02._12._2024;

namespace AdventOfCodeCollectionTests._02._12._2024
{
    internal class SecondPuzzleTests
    {
        [Test]
        public void CalculateSafeReports()
        {
            // arrange
            const int expected = 4;
            var firstTest = new SecondPuzzle();

            // act
            var result = firstTest.Solve(Inputs.TestInputString);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
