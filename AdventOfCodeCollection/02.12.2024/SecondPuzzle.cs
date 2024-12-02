using AdventOfCodeCollection.General;

namespace AdventOfCodeCollection._02._12._2024
{
    public class SecondPuzzle : APuzzle
    {
        public override int Solve(string? input = null)
        {
            var reports = Inputs.GetReportLevels(input ?? Inputs.InputString);
            var validReports = 0;
            foreach (var report in reports)
            {
                if (ReportOrReducedReportIsValid(report))
                {
                    validReports++;
                }
            }
            return validReports;
        }

        private bool ReportOrReducedReportIsValid(int[] report)
        {
            if (ReportValidation.ResolveValidationErros(report) == 0)
            {
                return true;
            }

            var reducedReportSets = GetReducedReportSets(report);
            return reducedReportSets.Any(reducedReportSet => ReportValidation.ResolveValidationErros(reducedReportSet) == 0);
        }

        private int[][] GetReducedReportSets(int[] report)
        {
            var reducedReportSets = new int[report.Length][];
            for (int indexToSkip = 0; indexToSkip < reducedReportSets.Length; indexToSkip++)
            {
                var reducedReportSet = new int[report.Length - 1];
                var indexToFill = 0;
                for (var index = 0; index < report.Length; index++)
                {
                    if (index == indexToSkip)
                    {
                        continue;
                    }
                    reducedReportSet[indexToFill++] = report[index];
                }
                reducedReportSets[indexToSkip] = reducedReportSet;
            }
            return reducedReportSets;
        }
    }
}