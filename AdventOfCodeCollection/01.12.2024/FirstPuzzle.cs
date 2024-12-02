
using AdventOfCode;
using AdventOfCodeCollection.General;

namespace AdventOfCodeCollection._01._12._2024
{

    public class FirstPuzzle : APuzzle
    {
        public override int Solve(string? input = null)
        {
            var (firstList, secondList) = Inputs.GetLists(input ?? Inputs.InputValues);

            firstList.Sort();
            secondList.Sort();

            var distance = 0;
            for (var i = 0; i < firstList.Count; i++)
            {
                var firstValue = firstList[i];
                var secondValue = secondList[i];
                distance += Math.Abs(firstValue - secondValue);
            }
            return distance;
        }
    }
}
