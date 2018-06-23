using static BenchmarkDotNet.Running.BenchmarkRunner;

namespace Benchmarks
{
    public static class Program
    {
        public static void Main(string[] args = default)
            => Run<Tests>();
    }
}
