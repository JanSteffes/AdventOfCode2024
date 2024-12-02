using AdventOfCodeCollection._02._12._2024;
using Tests._02._12._2024;

namespace AdventOfCodeCollectionTests._02._12._2024
{
    internal class FirstPuzzleTests
    {
        [Test]
        public void CalculateSafeReports()
        {
            // arrange
            const int expected = 2;
            var firstTest = new FirstPuzzle();

            // act
            var result = firstTest.Solve(Inputs.TestInputString);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
