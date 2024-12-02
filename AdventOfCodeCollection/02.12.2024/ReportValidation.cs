namespace AdventOfCodeCollection._02._12._2024
{
    internal static class ReportValidation
    {
        public static int ResolveValidationErros(int[] report)
        {
            var increasing = false;
            var validationErrors = 0;
            for (var index = 0; index < report.Length - 1; index++)
            {
                var currentNumber = report[index];
                var nextNumber = report[index + 1];
                if (index == 0)
                {
                    increasing = currentNumber < nextNumber;
                }
                if (NumbersAreEquall(currentNumber, nextNumber))
                {
                    validationErrors++;
                }
                if (!LevelDistanceAreOkay(currentNumber, nextNumber))
                {
                    validationErrors++;
                }
                if (!DirectionIsOkay(currentNumber, nextNumber, increasing))
                {
                    validationErrors++;
                }
                currentNumber = nextNumber;
                nextNumber = report[index + 1];
            }
            return validationErrors;
        }

        private static bool DirectionIsOkay(int currentNumber, int nextNumber, bool increasing)
        {
            if (increasing)
            {
                return nextNumber > currentNumber;
            }
            else
            {
                return nextNumber < currentNumber;
            }

        }

        private static bool NumbersAreEquall(int first, int second)
        {
            return first == second;
        }

        private static bool LevelDistanceAreOkay(int first, int second)
        {
            var dist = Math.Abs(first - second);
            return dist > 0 && dist <= 3;
        }
    }
}
