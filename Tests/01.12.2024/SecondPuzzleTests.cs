

using AdventOfCodeCollection._01._12._2024;
using Tests._01._12._2024;

namespace AdventOfCodeCollectionTests._01._12._2024
{
    internal class SecondPuzzleTests
    {
        [Test]
        public void CalculateSimilarityScore()
        {
            // arrange
            const int expected = 31;
            var firstTest = new SecondPuzzle();

            // act
            var result = firstTest.Solve(Inputs.TestInputString);

            // assert
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
