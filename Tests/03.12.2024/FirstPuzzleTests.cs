using AdventOfCodeCollection._03._12._2024;
using Tests._03._12._2024;

namespace AdventOfCodeCollectionTests._03._12._2024
{
    internal class FirstPuzzleTests
    {
        [Ignore("Not ready yet")]
        public void CalculateSafeReports()
        {
            // arrange
            const int expected = -1;
            var firstTest = new FirstPuzzle();

            // act
            var result = firstTest.Solve(Inputs.TestInputString);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
