using AdventOfCode;
using AdventOfCodeCollection.General;

namespace AdventOfCodeCollection._01._12._2024
{
    public class SecondPuzzle : APuzzle
    {
        public override int Solve(string? input = null)
        {
            var (firstList, secondList) = Inputs.GetLists(input ?? Inputs.InputValues);
            var secondListOccurances = secondList.GroupBy(s => s).ToDictionary(s => s.Key, s => s.Key * s.Count());

            var similarityScore = 0;
            foreach (var firstListValue in firstList)
            {
                if (secondListOccurances.ContainsKey(firstListValue))
                {
                    similarityScore += secondListOccurances[firstListValue];
                }
            }
            return similarityScore;
        }
    }
}
