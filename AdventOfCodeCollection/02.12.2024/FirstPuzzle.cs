using AdventOfCodeCollection.General;

namespace AdventOfCodeCollection._02._12._2024
{
    public class FirstPuzzle : APuzzle
    {
        public override int Solve(string? input = null)
        {
            var reports = Inputs.GetReportLevels(input ?? Inputs.InputString);
            var validReports = 0;
            foreach (var report in reports)
            {
                if (ReportIsValid(report))
                {
                    validReports++;
                }
            }
            return validReports;
        }

        private bool ReportIsValid(int[] report)
        {
            return ReportValidation.ResolveValidationErros(report) == 0;
        }
    }
}
