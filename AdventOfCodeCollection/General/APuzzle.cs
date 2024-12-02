namespace AdventOfCodeCollection.General
{
    public abstract class APuzzle
    {
        public void SolvePuzzle()
        {
            var result = Solve();
            Print(result);
        }

        private void Print(int result)
        {
            Console.WriteLine($"{GetType().Name}: {result}");
        }

        public abstract int Solve(string? input = null);
    }
}
