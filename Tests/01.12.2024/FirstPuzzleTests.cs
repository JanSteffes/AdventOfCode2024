

using AdventOfCodeCollection._01._12._2024;
using Tests._01._12._2024;

namespace AdventOfCodeCollectionTests._01._12._2024
{
    internal class FirstPuzzleTests
    {
        [Test]
        public void CalculateDistance()
        {
            // arrange
            const int expected = 11;
            var firstTest = new FirstPuzzle();

            // act
            var result = firstTest.Solve(Inputs.TestInputString);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
